using Business.Abstracts;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class RoleUserManager : IRoleUserService
    {
        IRoleUserDal _roleUserDal;

        public RoleUserManager(IRoleUserDal roleUserDal)
        {
            _roleUserDal = roleUserDal;
        }

        public void Add(RoleUser roleUser)
        {
            _roleUserDal.Add(roleUser);
        }

        public RoleUser GetByMail(string email)
        {
            return _roleUserDal.Get(r => r.Email == email);
        }

        public List<OperationClaim> GetClaims(RoleUser roleUser)
        {
           return _roleUserDal.GetClaims(roleUser);
        }
    }
}
