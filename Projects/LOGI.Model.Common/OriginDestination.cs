using System;
using System.Runtime.Serialization;

namespace LOGI.Core.Domain.Model.Common
{
    [Serializable]
    [DataContract]
    public class OriginDestination
    {

        /// <summary>
        /// LocationType
        /// </summary>
        [DataMember]
        public virtual string LocationType { get; set; }

        /// <summary>
        /// LocationValue
        /// </summary>
        [DataMember]
        public virtual string LocationValue { get; set; }

        /// <summary>
        /// LocationText
        /// </summary>
        [DataMember]
        public virtual string LocationText { get; set; }

        /// <summary>
        /// Kalkış ve varış noktası ile ilgili herhangi bir bilgi tutmak için
        /// </summary>
        [DataMember]
        public virtual string Tag { get; set; }
    }
}
