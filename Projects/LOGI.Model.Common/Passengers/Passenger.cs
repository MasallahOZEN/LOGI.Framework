using System.Runtime.Serialization;
using LOGI.Framework.Toolkit.Core.Common.Collections;

namespace LOGI.Core.Domain.Model.Common.Passengers
{
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    [DataContract]
    public class Passenger
    {
        [DataMember]
        public string EMail { get; set; }

        [DataMember]
        public PassengerGender Gender { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public PassengerType Type { get; set; }

        /// <summary>
        /// Extra parametre taşımak istenirse
        /// </summary>
        [DataMember]
        public SerializableDictionary<string, string> ExtendedValues { get; set; }
    }
}

