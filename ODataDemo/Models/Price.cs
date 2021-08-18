using System;
using System.Collections.Generic;

#nullable disable

namespace ODataDemo.Models
{
    public partial class Price
    {
        public string Etag { get; set; }
        public long Id { get; set; }
        public string Comment { get; set; }
        public string InvestigationChecksApplied { get; set; }
        public DateTime? InvestigationCreationDate { get; set; }
        public string ICurrency { get; set; }
        public long? IId { get; set; }
        public long? IInstrumentIdentityId { get; set; }
        public string IPricingMethod { get; set; }
        public string IReferencePriceDate { get; set; }
        public DateTime? LastModificationTimestamp { get; set; }
        public long? MarketId { get; set; }
        public string ModificationReasonCode { get; set; }
        public string PriceSourceInformationFallback { get; set; }
        public string PriceSourceInformationPart1 { get; set; }
        public string PriceUnitCode { get; set; }
        public string ProviderCode { get; set; }
        public DateTime? ProviderPriceDate { get; set; }
        public DateTime? ProviderPriceTime { get; set; }
        public string QuotationMode { get; set; }
        public string QuotationTypeCode { get; set; }
        public string RequestCode { get; set; }
        public DateTime? SnapshotTime { get; set; }
        public decimal? Spread { get; set; }
        public decimal? Value { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Yield { get; set; }
        public string LinkedCustomProperties { get; set; }
        public string LinkedSilverCopies { get; set; }
    }
}
