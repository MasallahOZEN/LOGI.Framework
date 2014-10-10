using System;
using System.Runtime.Serialization;

namespace LOGI.Core.Domain.Model.Common.Base
{
    [Serializable]
    [DataContract]
    public abstract class BaseFare : PriceInfoType
    {
        #region Implementation of IPriceInfo

        /// <summary>
        /// PriceInfo'ya dönüştürülen gerçek obje
        /// </summary>
        public string SerializedOriginalObject { get; set; }

        #endregion
    }
}