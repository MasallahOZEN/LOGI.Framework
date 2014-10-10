using System.Runtime.Serialization;

namespace LOGI.Core.Domain.Model.Common.Passengers
{
    using System;
    [DataContract]
 public enum PassengerGender
    {
        [EnumMemberAttribute]
        Bay=0,
        [EnumMemberAttribute]
        Bayan=1
    }
}

