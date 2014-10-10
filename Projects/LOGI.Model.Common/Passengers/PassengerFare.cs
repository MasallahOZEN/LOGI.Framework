using System;
using System.Runtime.Serialization;
using LOGI.Core.Domain.Model.Common.Base;

namespace LOGI.Core.Domain.Model.Common.Passengers
{
    ///<summary>
    /// Yolcu ücret bilgisi
    ///</summary>
    [Serializable]
    [DataContract]
    public class PassengerFare
    {
        ///<summary>
        /// Yolcu ücret bilgisi (Son kullanıcı)
        ///</summary>
        [DataMember]
        public PriceInfoType PriceInfo { get; set; }

        ///<summary>
        /// Yolcu ücret bilgisi (Servis gercek degeri)
        ///</summary>
        [DataMember]
        public PriceInfoType PriceInfoOriginal { get; set; }

        ///<summary>
        /// Yolcu tipi (Adult,Child)
        ///</summary>
        [DataMember]
        public PassengerType Type { get; set; }
        
        /// <summary>
        /// Yolcu tipindeki kişi sayısı
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }
    }
}
