using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace LOGI.Core.Domain.Model.Common.Base
{
    /// <summary>
    /// Base dönüş tipi
    /// </summary>
    [DataContract]
    [Serializable]
    public abstract class BaseResponse : BaseValidatable
    {
        #region Constructors
        public BaseResponse()
            : this("")//TODO: xml serialization için eklendi
        {
                
        }

        protected BaseResponse(string serviceName)
        {
            this.ServiceName = serviceName;
            this.ResponseExeptions=new BaseResponseExeptionItems();
        }

        protected BaseResponse(string serviceName, ResponseStatusType responseStatusType, BaseResponseExeptionItems errors)
        {
            if (errors==null)
            {
                ResponseExeptions=new BaseResponseExeptionItems();
            }
            this._responseStatus = responseStatusType;
            this.ResponseExeptions = errors;
            this.ServiceName = serviceName;
        } 
        #endregion
        
        #region Fields

        [DataMember]
        private ResponseStatusType _responseStatus;

        #endregion

        #region Properties
        /// <summary>
        /// Cevap durumu
        /// </summary>
        [DataMember]
        public virtual ResponseStatusType ResponseStatus
        {
            get
            {
                _responseStatus = HasErrors ? ResponseStatusType.Error : _responseStatus;
                return _responseStatus;
            }
            set { _responseStatus=value; }
        }

        /// <summary>
        /// Istek sonucu hata oluştu mu ?
        /// </summary>
        [DataMember]
        public virtual bool HasErrors
        {
            get
            {
                if (ResponseExeptions == null)
                {
                    ResponseExeptions =new BaseResponseExeptionItems();
                }
                return (ResponseExeptions.Count(x => x.StatusType == ResponseStatusType.Error || x.StatusType == ResponseStatusType.Unknown) > 0);
            }
            set{}
        }         

        /// <summary>
        /// Istek sonucu oluşan hata listesi
        /// </summary>
        [DataMember]
        public virtual BaseResponseExeptionItems ResponseExeptions { get; set; }
        

        /// <summary>
        /// ServiceName
        /// </summary>
        [DataMember]
        public string ServiceName { get; set; }
        
        /// <summary>
        /// ReferenceNumber
        /// </summary>
        [DataMember]
        public string ReferenceNumber { get; set; }

        #endregion
    }
}
