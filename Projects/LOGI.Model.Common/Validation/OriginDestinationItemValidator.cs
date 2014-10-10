using System;
using FluentValidation;
using FluentValidation.Results;
using LOGI.Framework.Toolkit.Core.Extensions.ExtString;

namespace LOGI.Core.Domain.Model.Common.Validation
{
    ///<summary>
    /// FlightOriginDestinationItemValidator
    ///</summary>

    public class OriginDestinationItemValidator : AbstractValidator<OriginDestinationItem>
    {
        public override FluentValidation.Results.ValidationResult Validate(OriginDestinationItem instance)
        {
            RuleFor(flightOriginDestinationItem => flightOriginDestinationItem.Date).NotNull().Must(x => x >= DateTime.Today).WithMessage("FlightMessageResource.FlightMessage_FlightRequest_SearchParameters_FlightOriginDestinations_Date_Required");
            RuleFor(flightOriginDestinationItem => flightOriginDestinationItem.Destination).
                NotNull().WithMessage(
                    "FlightMessageResource.FlightMessage_FlightRequest_SearchParameters_FlightOriginDestinations_Destination_Required").
                Must(x => x.LocationValue.IsNotNullOrNotEmpty()).WithMessage(
                    "FlightMessageResource.FlightMessage_FlightRequest_SearchParameters_FlightOriginDestinations_Destination_Required");

            RuleFor(flightOriginDestinationItem => flightOriginDestinationItem.Origin).
                NotNull().WithMessage(
                    "FlightMessageResource.FlightMessage_FlightRequest_SearchParameters_FlightOriginDestinations_Origin_Required").
                Must(x => x.LocationValue.IsNotNullOrNotEmpty()).WithMessage(
                    "FlightMessageResource.FlightMessage_FlightRequest_SearchParameters_FlightOriginDestinations_Origin_Required");

            base.Custom(x => x.Origin.LocationValue == x.Destination.LocationValue
                                 ? new ValidationFailure(" [{PropertyName}]","Kalkış ve varış aynı noktalar olamaz !")
                                 : null);

            return base.Validate(instance);
        }
    }
}
