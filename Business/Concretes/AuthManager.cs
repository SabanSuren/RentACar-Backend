using Business.Abstract;
using Business.Abstracts;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IRoleUserService _roleUserservice;
        private ITokenHelper _tokenHelper;

        public AuthManager(IRoleUserService roleUserservice, ITokenHelper tokenHelper)
        {
            _roleUserservice = roleUserservice;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<RoleUser> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var rolUser = new RoleUser
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _roleUserservice.Add(rolUser);
            return new SuccessDataResult<RoleUser>(rolUser, Messages.UserRegistered);
        }

        public IDataResult<RoleUser> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _roleUserservice.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<RoleUser>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<RoleUser>(Messages.PasswordError);
            }

            return new SuccessDataResult<RoleUser>(userToCheck, Messages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_roleUserservice.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(RoleUser roleUser)
        {
            var claims = _roleUserservice.GetClaims(roleUser);
            var accessToken = _tokenHelper.CreateToken(roleUser, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}
