using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace LOGI.Core.Domain.Model.Common
{

  [DataContract]
 public class LocalizedValue
  {

      /// <summary>
        /// Item ın culture değeri
        /// </summary>
        [DataMember]
        public string Culture { get; set; }
        /// <summary>
        /// Item ın culture değeri
        /// </summary>
        [DataMember]
        public string Value { get; set; }
        /// <summary>
        /// Varsa Item Açıklaması
        /// </summary>
        [DataMember]
        public string Definition { get; set; }


    }
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(ElementName = "LocalizedValues")]
    [DataContract]
    public class LocalizedValues
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "LocalizedValue", IsNullable = true)]
        [DataMember]
        public List<LocalizedValue> LocalizedValue { get; set; }
    }
  }

