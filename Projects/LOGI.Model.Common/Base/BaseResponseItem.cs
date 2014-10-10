using System;
using System.Runtime.Serialization;
using LOGI.Framework.Toolkit.Core.Common.Collections;
using LOGI.Framework.Toolkit.Core.Threading;

namespace LOGI.Core.Domain.Model.Common.Base
{
    /// <summary>
    /// Base response item, book yada ticket işlemlerinden dönüş
    /// </summary>
    [Serializable]
    [DataContract]
    public abstract class BaseResponseItem
    {
        //private static object _sharedLock = new object();

        public BaseResponseItem()
        {
            RetryCount = -1;
        }
        #region Fields
        private string _transactionIdentifier;
        #endregion

        /// <summary>
        /// Servislerden rezervasyon sonucu dönen pnr numarası
        /// </summary>
        [DataMember]
        public string PnrNumber { get; set; }

        /// <summary>
        /// İşlem zamanı
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }

        /// <summary>
        /// Pnr'ın custom olduğunu belirtir.
        /// </summary>
        [DataMember]
        public bool isDummyPnr { get; set; }

        /// <summary>
        /// Servislerden rezervasyon sonucu dönen pnr'a karşılık soyisim
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Tekrar deneme sayısı
        /// </summary>
        [DataMember]
        public short RetryCount { get; set; }

        /// <summary>
        /// Transaction Identifier
        /// </summary>
        [DataMember]
        public string TransactionIdentifier { get; set; }

        #region Methods
        /// <summary>
        /// Transaction tekil değeri
        /// </summary>
        public string GetTransactionIdentifier()
        {
            using (TimedLock.Lock(this, new TimeSpan(0, 0, 6), string.Format("Basket=>{0}",this.GetType().Name)))//TODO: timeout süresini config'e al
            {
                if (string.IsNullOrEmpty(_transactionIdentifier))
                {
                    _transactionIdentifier = DateTime.Now.Ticks.ToString();
                    TransactionIdentifier = _transactionIdentifier;
                }
                return _transactionIdentifier;
            }
        }

        /// <summary>
        /// Transaction tekil değeri setlenir
        /// </summary>
        public bool SetTransactionIdentifier(string transactionIdentifier)
        {
            using (TimedLock.Lock(this, new TimeSpan(0, 0, 6), string.Format("Basket=>{0}", this.GetType().Name)))//TODO: timeout süresini config'e al
            {
                _transactionIdentifier = transactionIdentifier;
                TransactionIdentifier = _transactionIdentifier;
                this.Date=DateTime.Now;
                return true;
            }
        }
        #endregion

		#region NOTE
		/********************
		
		NOTE
		
        By:Masallah OZEN
        Date:01.12.2011 09:03
        Desc:Rezervasyonlarım sayfasında,rezervasyonun hangi provider'a ait olduğu bilgisi
		
		********************/
		#endregion
		
        /// <summary>
        /// Rezervasyonu sağlayan servis
        /// <example>
        /// Ucak=>THY/Atlas gibi
        /// </example>
        /// </summary>
        [DataMember]
        public string ServiceRegisterName { get; set; }

        ///<summary>
        /// TimeLimit
        ///</summary>
        [DataMember]
        public DateTime TimeLimit { get; set; }

        [DataMember]
        public string SerializedOriginalObject { get; set; }

        /// <summary>
        /// Extra parametre taşımak istenirse
        /// </summary>
        [DataMember]
        public SerializableDictionary<string, string> ExtendedValues { get; set; }
    }
}
