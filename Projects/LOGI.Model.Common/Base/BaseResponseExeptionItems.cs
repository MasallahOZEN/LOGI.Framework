using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using LOGI.Framework.Toolkit.Core.Common.Collections;

namespace LOGI.Core.Domain.Model.Common.Base
{
    /// <summary>
    /// Base dönüş tipi
    /// </summary>
    [Serializable]
    [CollectionDataContract]
    public sealed class BaseResponseExeptionItems : BusinessObjectCollection<BaseResponseExeptionItem>
    {
        public BaseResponseExeptionItems()
        {
            this._innerArray = new List<BaseResponseExeptionItem>();
        }
    }
}
