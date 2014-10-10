using System.Runtime.Serialization;

namespace LOGI.Core.Domain.Model.Common.Passengers
{

    ///<summary>
    /// Yolcu tipleri
    ///</summary>
    [DataContract]
    public enum PassengerType
    {
        /// <summary>
        /// Default Type
        /// </summary>
        [EnumMemberAttribute]
        None=0,

        /// <summary>
        /// Yetişkin
        /// </summary>
        [EnumMemberAttribute]
        Adult=1,

        /// <summary>
        /// Çocuk (2 ve 12 yaş arası)
        /// </summary>
        [EnumMemberAttribute]
        Child=2,

        /// <summary>
        /// Bebek (0 ve 2 yaş arası)
        /// </summary>
        [EnumMemberAttribute]
        Infant=3,
        
        /// <summary>
        /// Öğrenci
        /// </summary>
        [EnumMemberAttribute]
        Student=4,

        /// <summary>
        /// Genç (12 ve 20 yaş arası)
        /// </summary>
        [EnumMemberAttribute]
        Youth = 5,

        /// <summary>
        /// TSK
        /// </summary>
        [EnumMemberAttribute]
        TSK = 6,

        /// <summary>
        /// Yaşlı (65 yaş üstü)
        /// </summary>
        [EnumMemberAttribute]
        Senior=7
    }
}

