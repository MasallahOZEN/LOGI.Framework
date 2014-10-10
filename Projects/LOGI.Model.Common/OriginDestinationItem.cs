using System;
using System.Runtime.Serialization;

namespace LOGI.Core.Domain.Model.Common
{
    [Serializable]
    [DataContract]
    public class OriginDestinationItem
    {
        public OriginDestinationItem()
        {
            Origin=new OriginDestination();
            Destination=new OriginDestination();
        }
        /// <summary>
        /// Kalkış Noktası
        /// </summary>
        [DataMember]
        public virtual OriginDestination Origin { get; set; }

        /// <summary>
        /// Varış Noktası
        /// </summary>
        [DataMember]
        public virtual OriginDestination Destination { get; set; }

        [DataMember]
        public virtual DateTime Date { get; set; }
    }
}
