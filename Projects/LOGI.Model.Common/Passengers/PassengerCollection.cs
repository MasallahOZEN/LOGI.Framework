using System;
using System.Runtime.Serialization;
using System.Linq;
using LOGI.Framework.Toolkit.Core.Common.Collections;

namespace LOGI.Core.Domain.Model.Common.Passengers
{

    [Serializable]
    [CollectionDataContract]
    public class PassengerCollection : BusinessObjectCollection<Passenger>
    {
        public int PassengerCountByType(PassengerType type)
        {
            return this.Where(x=>x.Type == type).Count();
        }
    }
}

