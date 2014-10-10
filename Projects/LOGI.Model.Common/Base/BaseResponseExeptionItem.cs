using System;
using System.Runtime.Serialization;

namespace LOGI.Core.Domain.Model.Common.Base
{
    [DataContract]
    [Serializable]
    public class BaseResponseExeptionItem
    {
        public BaseResponseExeptionItem()
        {
            this.StatusType = ResponseStatusType.Error;
        }
        [DataMember]
        public string ErrorCode { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Details { get; set; }

        [DataMember]
        public ResponseStatusType StatusType { get; set; }
    }
}
