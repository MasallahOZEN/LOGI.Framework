using System;
using System.Runtime.Serialization;
using LOGI.Framework.Toolkit.Foundation.Validations;

namespace LOGI.Core.Domain.Model.Common.Base
{
    /// <summary>
    /// Base gidiş tipi
    /// </summary>
    [Serializable]
    [DataContract]
    public class BaseValidatable : IValidatable
    {
        /// <summary>
        /// Custom MyProperty
        /// </summary>
        [DataMember]
        public string MyProperty { get; set; }

        #region Implementation of IValidatable

        public virtual void Validate()
        {
            
        }

        #endregion

        //public ValidationResult ValidateWithBase(params ValidationResult[] validationResults)
        //{
        //    IList<ValidationFailure> failures = new List<ValidationFailure>();

        //    foreach (var validationResult in validationResults)
        //    {
        //        validationResult.Errors.ForEach(failures.Add);
        //    }

        //    var result = new FluentValidation.Results.ValidationResult(failures);


        //    return result;
        //}

    }
}
