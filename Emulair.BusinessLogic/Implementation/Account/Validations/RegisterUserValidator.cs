using FluentValidation;

namespace Emulair.BusinessLogic.Implementation.Account
{
    public class RegisterUserValidator : AbstractValidator<RegisterModel>
    {
        public RegisterUserValidator()
        {
            RuleFor(r => r.Email)
                .NotEmpty().WithMessage("Camp obligatoriu!")
                .Must(NotAlreadyExist)
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);
            RuleFor(r => r.Password)
                .NotEmpty().WithMessage("Camp obligatoriu!");
            RuleFor(r => r.FirstName)
                .NotEmpty().WithMessage("Camp obligatoriu!");
            RuleFor(r => r.LastName)
                .NotEmpty().WithMessage("Camp obligatoriu!");
        }

        public bool NotAlreadyExist(string email)
        {
            return true;
        }
    }
}
