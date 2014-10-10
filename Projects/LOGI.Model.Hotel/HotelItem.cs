using System;

namespace LOGI.Core.Domain.Model.Hotel
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class HotelItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public byte RateValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int RateCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Subtitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Location { get; set; }
    }
}