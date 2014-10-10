using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using LOGI.Framework.Toolkit.Core.Common.Collections;
using Newtonsoft.Json;

namespace LOGI.Core.Domain.Model.Common.Base
{
    /// <summary>
    /// Base gidiş tipi
    /// </summary>
    [Serializable]
    [DataContract]
    public class BaseRequest : BaseValidatable
    {
        public BaseRequest()
        {
            ExtraTypeForSerialization=new List<Type>();
            RequestSource = "WebApp";
            ReferenceNumber = Guid.NewGuid().ToString();

        }

        /// <summary>
        /// Loglama işleminde isteğin kimden geldiğini belirtir. (WebApp/Service/Test)
        /// </summary>
        [DataMember]
        public string RequestSource { get; set; }
        
        /// <summary>
        /// Arama yapıldığında oluşan search token değeri 
        /// </summary>
        [DataMember]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Extra parametre taşımak istenirse
        /// </summary>
        [DataMember]
        public SerializableDictionary<string, string> ExtendedValues { get; set; }

        private List<Type> _extraTypeForSerialization;
        /// <summary>
        /// Serialization işlemlerinde,serilize edilecek tipin serialize işleminde hata vermemesi adına içerebileceği type'ları belirtir. 
        /// </summary>
        [IgnoreDataMember]
        [XmlIgnore]
        [JsonIgnore]
        public List<Type> ExtraTypeForSerialization
        {
            get
            {
                if (_extraTypeForSerialization == null)
                {
                    return _extraTypeForSerialization = new List<Type>();
                }
                return _extraTypeForSerialization;
            }
            set { _extraTypeForSerialization = value; }
        }

    }
}
