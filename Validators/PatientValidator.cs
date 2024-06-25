using CovidVaccinationSystem.Models;
using FluentValidation;

namespace CovidVaccinationSystem.Validators
{
    public class PatientValidator : AbstractValidator<Patient>
    {
        public PatientValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name is a mandatory field");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Please enter valid email address");
        }
    }

}
