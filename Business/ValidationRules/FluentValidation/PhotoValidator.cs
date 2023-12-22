using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PhotoValidator:AbstractValidator<Photo>
    {
        public PhotoValidator()
        {
            RuleFor(p => p.PhotoId).NotEmpty();
            RuleFor(p=>p.CarId).NotEmpty();
            RuleFor(p=>p.ImagePath).NotEmpty();
            RuleFor(p=>p.Date).NotEmpty();
            
        }
    }
}
