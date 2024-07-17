using FluentValidation;
using Para.Data.Domain;

namespace Para.Bussiness.Validations
{
    public class CustomerDetailValidator : AbstractValidator<CustomerDetail>
    {
        public CustomerDetailValidator()
        {
            RuleFor(x => x.FatherName)
                .NotEmpty()
                .WithMessage("Father's name is required")
                .MaximumLength(25)
                .WithMessage("Father name can be up to 25 characters long!");

            RuleFor(x => x.MotherName)
                .NotEmpty()
                .WithMessage("Mother's name is required")
                .MaximumLength(25)
                .WithMessage("Mother name can be up to 25 characters long!");

            RuleFor(x => x.MontlyIncome)
                .NotEmpty()
                .WithMessage("Monthly income is required")
                .MaximumLength(15)
                .WithMessage("Monthly income must be maximum 15 characters long!");
                
            RuleFor(x => x.Occupation)
                .NotEmpty()
                .WithMessage("Occupation is required")
                .MaximumLength(30)
                .WithMessage("The profession can be up to 30 characters long!");
        }
    }
}
