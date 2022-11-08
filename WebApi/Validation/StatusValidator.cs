﻿using Core.Entities;
using FluentValidation;

namespace Validation
{
    public class StatusValidator : AbstractValidator<Status>
    {
        public StatusValidator()
        {
            // Check name is not null, empty and is between 1 and 250 characters
            RuleFor(customer => customer.Title).NotNull().NotEmpty().WithMessage("تست").Length(1, 10).WithMessage("کمتر از 10");
            //RuleFor(customer => customer.LastName).NotNull().NotEmpty().Length(1, 250);

            //// Validate Phone with a custom error message
            //RuleFor(customer => customer.Phone).NotEmpty().WithMessage("Please add a phone number");

            //// Validate Age for submitted customer has to be between 21 and 100 years old
            //RuleFor(customer => customer.Age).InclusiveBetween(21, 100);

            //// Validate the address (its a complex property)
            //RuleFor(customer => customer.Address).InjectValidator();
        }
    }
}