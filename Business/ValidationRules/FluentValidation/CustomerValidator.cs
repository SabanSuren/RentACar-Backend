using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CustomerName).NotEmpty();
            RuleFor(c => c.CustomerCity).NotEmpty();
            RuleFor(c => c.CustomerEmail).NotEmpty();
            RuleFor(c => c.CustomerPhone).NotEmpty();
            RuleFor(c => c.CustomerPhone).MinimumLength(7).NotEmpty();
            RuleFor(c=>c.CompanyName).NotEmpty().MaximumLength(30);
           


        }
    }
}
