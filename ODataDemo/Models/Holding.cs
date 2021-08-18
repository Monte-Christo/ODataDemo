using System;
using System.Collections.Generic;

#nullable disable

namespace ODataDemo.Models
{
    public partial class Holding
    {
        public string Etag { get; set; }
        public long Id { get; set; }
        public bool? AssimilatedAsset { get; set; }
        public bool? CollateralAsset { get; set; }
        public int? GplineStatus { get; set; }
        public string GpvalueStatus { get; set; }
        public string HoldingStatus { get; set; }
        public long? InstrumentIdentityId { get; set; }
        public string ICurrency { get; set; }
        public long? IId { get; set; }
        public long? IInstrumentIdentityId { get; set; }
        public string PortfolioCode { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string ShortLong { get; set; }
        public float? Weight { get; set; }
        public long? PortfolioId { get; set; }
        public string LinkedCustomProperties { get; set; }
        public string LinkedPortfolio { get; set; }
        public string LinkedSilverCopies { get; set; }
    }
}
