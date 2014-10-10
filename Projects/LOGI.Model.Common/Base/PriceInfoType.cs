using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using LOGI.Framework.Toolkit.Core.Common.Collections;

namespace LOGI.Core.Domain.Model.Common.Base
{
    [Serializable]
    [DataContract]
    public partial class PriceInfoType
    {
        public PriceInfoType()
        {            
            ExtendedValues=new SerializableDictionary<string, string>();
        }

        #region View Price
        /// <summary>
        /// Toplam Ücret (servisin gönderdiği birimin TL karşılığı)
        /// </summary>
        [DataMember]
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Para birimi (servisin gönderdiği birimin gösterilmek istenen birim karşılığı)
        /// </summary>
        [DataMember]
        public string Currency { get; set; }

        /// <summary>
        /// Para birimi (servisin gönderdiği birimin gösterilmek istenen birim karşılığı) kur değeri
        /// </summary>
        [DataMember]
        public decimal CurrencyExchangeRate { get; set; } 
        #endregion

        /// <summary>
        /// Extra parametre taşımak istenirse
        /// </summary>
        [DataMember]
        public SerializableDictionary<string, string> ExtendedValues { get; set; }
    }
}