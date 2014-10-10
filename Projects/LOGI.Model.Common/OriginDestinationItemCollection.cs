using System;
using System.Runtime.Serialization;
using LOGI.Framework.Toolkit.Core.Common.Collections;

namespace LOGI.Core.Domain.Model.Common
{
    [Serializable]
    [CollectionDataContract]
    public class OriginDestinationItemCollection : BusinessObjectCollection<OriginDestinationItem>
    {
    }
}
