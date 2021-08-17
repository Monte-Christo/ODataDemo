using System;
using System.Collections.Generic;

#nullable disable

namespace ODataDemo.Models
{
    public partial class Exchange
    {
        public string Etag { get; set; }
        public long Id { get; set; }
        public string BbgpricingSource { get; set; }
        public string CountryCode { get; set; }
        public string Description { get; set; }
        public string ExchangeTypeCode { get; set; }
        public long? HolidayCalendarId { get; set; }
        public string IdcexchangeCode { get; set; }
        public string IGainExchangeId { get; set; }
        public long? IId { get; set; }
        public string Mic { get; set; }
        public string Name { get; set; }
        public long? ParentExchangeId { get; set; }
        public string SixBcncode { get; set; }
        public string StatusCode { get; set; }
        public string TrexchangeCode { get; set; }
        public string Url { get; set; }
        public string WeekendCode { get; set; }
        public string WmExchangeCode { get; set; }
        public string LinkedCustomProperties { get; set; }
        public string LinkedSilverCopies { get; set; }
    }
}
