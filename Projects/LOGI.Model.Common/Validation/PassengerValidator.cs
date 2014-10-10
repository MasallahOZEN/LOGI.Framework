using System;
using FluentValidation;
using LOGI.Core.Domain.Model.Common.Passengers;

namespace LOGI.Core.Domain.Model.Common.Validation
{
    ///<summary>
    /// Flight Request Validator
    ///</summary>
    public class PassengerValidator : AbstractValidator<Passenger>
    {
        public override FluentValidation.Results.ValidationResult Validate(Passenger instance)
        {
            //RuleFor(passenger => passenger.Birthday).NotNull().NotEmpty().
            //    Must(type => type != default(DateTime)).
            //    WithMessage("FlightMessageResource.Passenger_Birthday_Required");
            //RuleFor(passenger => passenger.EMail).NotNull().NotEmpty().
            //    Must(type => !string.IsNullOrEmpty(type)).
            //    EmailAddress().
            //    WithMessage("FlightMessageResource.Passenger_Email_Required");
            //RuleFor(passenger => passenger.FirstName).NotNull().NotEmpty().
            //    WithMessage("FlightMessageResource.Passenger_FirstName_Required");
            //RuleFor(passenger => passenger.LastName).NotNull().NotEmpty().
            //    WithMessage("FlightMessageResource.Passenger_LastName_Required");  
            return base.Validate(instance);
        }
    }
}
