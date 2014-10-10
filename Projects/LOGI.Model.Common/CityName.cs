//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using YKM.Toolkit.Foundation.Repository;

namespace YKM.TravelPortal.Core.Model.Common
{
    public partial class CityName : EntityBase
    {
        #region Primitive Properties
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual string CityCode
        {
            get { return _cityCode; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_cityCode != value)
                    {
                        if (City != null && City.CityCode != value)
                        {
                            City = null;
                        }
                        _cityCode = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private string _cityCode;
    
        public virtual string Culture
        {
            get;
            set;
        }
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual string CreatedBy
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> CreatedDate
        {
            get;
            set;
        }
    
        public virtual string ModifiedBy
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> ModifiedDate
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> IsActive
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual City City
        {
            get { return _city; }
            set
            {
                if (!ReferenceEquals(_city, value))
                {
                    var previousValue = _city;
                    _city = value;
                    FixupCity(previousValue);
                }
            }
        }
        private City _city;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupCity(City previousValue)
        {
            if (previousValue != null && previousValue.CityName1.Contains(this))
            {
                previousValue.CityName1.Remove(this);
            }
    
            if (City != null)
            {
                if (!City.CityName1.Contains(this))
                {
                    City.CityName1.Add(this);
                }
                if (CityCode != City.CityCode)
                {
                    CityCode = City.CityCode;
                }
            }
            else if (!_settingFK)
            {
                CityCode = null;
            }
        }

        #endregion
    }
}