using Application.Features.Clients.Commands.CreateRestaurant;
using FluentValidation;
using System.IO;

namespace Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantCommandValidator : AbstractValidator<CreateRestaurantCommand>
    {
        public CreateRestaurantCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} cant be empty")
                .MaximumLength(80).WithMessage("{PropertyName} cant be more than {MaxLength}");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("{PropertyName} cant be empty")
                .MaximumLength(100).WithMessage("{PropertyName} cant be more than {MaxLength}");

            RuleFor(p => p.PhoneNumber)
                .NotEmpty().WithMessage("{PropertyName} cant be empty")
                .MaximumLength(9).WithMessage("{PropertyName} cant be more than {MaxLength}");

            RuleFor(p => p.Street)
               .NotEmpty().WithMessage("{PropertyName} cant be empty")
               .MaximumLength(100).WithMessage("{PropertyName} cant be more than {MaxLength}");

            RuleFor(p => p.City)
               .NotEmpty().WithMessage("{PropertyName} cant be empty")
               .MaximumLength(50).WithMessage("{PropertyName} cant be more than {MaxLength}");

            RuleFor(p => p.Country)
               .NotEmpty().WithMessage("{PropertyName} cant be empty")
               .MaximumLength(50).WithMessage("{PropertyName} cant be more than {MaxLength}");

            RuleFor(p => p.PostalCode)
               .NotEmpty().WithMessage("{PropertyName} cant be empty")
               .MaximumLength(50).WithMessage("{PropertyName} cant be more than {MaxLength}");
        }
        
    }
}

