using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOGI.Core.Domain.Model.Common.Base
{
    /// <summary>
    /// Response status type
    /// </summary>
    public enum ResponseStatusType
    {
        /// <summary>
        /// Uyarı
        /// </summary>
        Warning = 2,

        /// <summary>
        /// Başarılı
        /// </summary>
        Successful = 1,

        /// <summary>
        /// Hatalı
        /// </summary>
        Error = -1,

        /// <summary>
        /// Bilinmiyor (default)
        /// </summary>
        Unknown = 0
    }
}
