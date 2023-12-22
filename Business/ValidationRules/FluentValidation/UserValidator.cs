using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u=>u.FirstName).MinimumLength(2).MaximumLength(20);
            RuleFor(u=>u.FirstName).NotEmpty();
            RuleFor(u=>u.LastName).NotEmpty();
            RuleFor(u=>u.Email).NotEmpty();
            RuleFor(u=>u.Password).MinimumLength(8).MaximumLength(36);
            RuleFor(u => u.Email).Must(IsValidEmail).WithMessage("Geçerli bir e-posta adresi giriniz.");
            RuleFor(c => c.Password).Must(IsPasswordValid).WithMessage("Şifre en az bir büyük harf ve bir rakam içermelidir.");
            RuleFor(c => c.Password).Must(IsPasswordValid2).WithMessage("Şifre en az Özel karakter içermelidir.");


        }

        private bool IsValidEmail(string email)
        {
            // E-posta adresinde '@' karakteri kontrolü
            return email.Contains("@");
        }

        private bool IsPasswordValid(string password)
        {
            // Şifrenin en az bir büyük harf, bir rakam  içermemesi kontrolü
            return password.Any(char.IsUpper) && password.Any(char.IsDigit) ;
        }

        private bool IsPasswordValid2(string password)
        {
            // Şifrenin en az  özel karakter içermemesi kontrolü
            return password.Any(char.IsPunctuation);
        }
        

    }
}
