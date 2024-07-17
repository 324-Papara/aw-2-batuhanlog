using FluentValidation;
using Para.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para.Bussiness.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name is required")
                .Length(2, 30)
                .WithMessage("First name length must be between 2-30 characters !");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last name is required")
                .Length(2, 30)
                .WithMessage("Last name length must be between 2-30 characters !");

            RuleFor(x => x.IdentityNumber)
                .NotEmpty()
                .WithMessage("Identity number is required")
                .Length(11)
                .WithMessage("Identity number must be 11 characters!");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email is required")
                .Length(1, 30)
                .WithMessage("Email must be between 1-30 characters !");

            RuleFor(x => x.CustomerNumber)
                .NotEmpty()
                .WithMessage("Number is required")
                .InclusiveBetween(1, 10000)
                .WithMessage("Customer number must be between 1-10000");
        }
    }
}
