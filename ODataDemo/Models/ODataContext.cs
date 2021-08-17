using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ODataDemo.Models
{
    public partial class ODataContext : DbContext
    {
        public ODataContext()
        {
        }

        public ODataContext(DbContextOptions<ODataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Exchange> Exchanges { get; set; }
        public virtual DbSet<Holding> Holdings { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Instrument> Instruments { get; set; }
        public virtual DbSet<Price> Prices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOData("URL=http://10.205.224.17:8000/odata;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("Event", "OData");

                entity.HasIndex(e => e.Id, "CDATA_ODATA_EVENT_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint");

                entity.Property(e => e.AccruedInterestDays).HasColumnType("int");

                entity.Property(e => e.ActualContractualCode).HasColumnType("varchar");

                entity.Property(e => e.AdditionalTaxIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("AdditionalTax_IsSet");

                entity.Property(e => e.AdditionalTaxPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("AdditionalTax_PrimaryCurrencyCode");

                entity.Property(e => e.AdditionalTaxPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("AdditionalTax_PrimaryValue");

                entity.Property(e => e.AdditionalTaxSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("AdditionalTax_SecondaryCurrencyCode");

                entity.Property(e => e.AdditionalTaxSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("AdditionalTax_SecondaryValue");

                entity.Property(e => e.AdditionalTaxType)
                    .HasColumnType("varchar")
                    .HasColumnName("AdditionalTax_Type");

                entity.Property(e => e.Affidavit).HasColumnType("bool");

                entity.Property(e => e.Aftcode)
                    .HasColumnType("varchar")
                    .HasColumnName("AFTCode");

                entity.Property(e => e.AftmanualSetCode)
                    .HasColumnType("varchar")
                    .HasColumnName("AFTManualSetCode");

                entity.Property(e => e.AnnouncementDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("AnnouncementDate_IsSet");

                entity.Property(e => e.AnnouncementDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("AnnouncementDate_Type");

                entity.Property(e => e.AnnouncementDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("AnnouncementDate_UtcOffset");

                entity.Property(e => e.AnnouncementDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("AnnouncementDate_Value");

                entity.Property(e => e.BbgDividendTypeCode).HasColumnType("varchar");

                entity.Property(e => e.BidIntervalRateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("BidIntervalRate_IsSet");

                entity.Property(e => e.BidIntervalRatePrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BidIntervalRate_PrimaryCurrencyCode");

                entity.Property(e => e.BidIntervalRatePrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("BidIntervalRate_PrimaryValue");

                entity.Property(e => e.BidIntervalRateSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BidIntervalRate_SecondaryCurrencyCode");

                entity.Property(e => e.BidIntervalRateSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("BidIntervalRate_SecondaryValue");

                entity.Property(e => e.BidIntervalRateType)
                    .HasColumnType("varchar")
                    .HasColumnName("BidIntervalRate_Type");

                entity.Property(e => e.BlockingPeriodEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BlockingPeriod_EndDate");

                entity.Property(e => e.BlockingPeriodIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("BlockingPeriod_IsSet");

                entity.Property(e => e.BlockingPeriodStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BlockingPeriod_StartDate");

                entity.Property(e => e.BlockingPeriodType)
                    .HasColumnType("varchar")
                    .HasColumnName("BlockingPeriod_Type");

                entity.Property(e => e.BookClosureperiodEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BookClosureperiod_EndDate");

                entity.Property(e => e.BookClosureperiodIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("BookClosureperiod_IsSet");

                entity.Property(e => e.BookClosureperiodStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BookClosureperiod_StartDate");

                entity.Property(e => e.BookClosureperiodType)
                    .HasColumnType("varchar")
                    .HasColumnName("BookClosureperiod_Type");

                entity.Property(e => e.CashflowSetId).HasColumnType("varchar");

                entity.Property(e => e.CashflowSetTypeCode).HasColumnType("varchar");

                entity.Property(e => e.ChangeTypeCode).HasColumnType("varchar");

                entity.Property(e => e.CodeEventisCode).HasColumnType("varchar");

                entity.Property(e => e.CorporateActionEventStageCode).HasColumnType("varchar");

                entity.Property(e => e.CouponNumber).HasColumnType("varchar");

                entity.Property(e => e.DefaultTaxRate).HasColumnType("varchar");

                entity.Property(e => e.DenominationCode).HasColumnType("varchar");

                entity.Property(e => e.DepartmentCode).HasColumnType("varchar");

                entity.Property(e => e.DepositorysuspensionperiodforwithdrawalatagentEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Depositorysuspensionperiodforwithdrawalatagent_EndDate");

                entity.Property(e => e.DepositorysuspensionperiodforwithdrawalatagentIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("Depositorysuspensionperiodforwithdrawalatagent_IsSet");

                entity.Property(e => e.DepositorysuspensionperiodforwithdrawalatagentStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Depositorysuspensionperiodforwithdrawalatagent_StartDate");

                entity.Property(e => e.DepositorysuspensionperiodforwithdrawalatagentType)
                    .HasColumnType("varchar")
                    .HasColumnName("Depositorysuspensionperiodforwithdrawalatagent_Type");

                entity.Property(e => e.DerivedEffectiveDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("DerivedEffectiveDate_IsSet");

                entity.Property(e => e.DerivedEffectiveDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("DerivedEffectiveDate_Type");

                entity.Property(e => e.DerivedEffectiveDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("DerivedEffectiveDate_UtcOffset");

                entity.Property(e => e.DerivedEffectiveDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("DerivedEffectiveDate_Value");

                entity.Property(e => e.DerivedExDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("DerivedExDate_IsSet");

                entity.Property(e => e.DerivedExDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("DerivedExDate_Type");

                entity.Property(e => e.DerivedExDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("DerivedExDate_UtcOffset");

                entity.Property(e => e.DerivedExDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("DerivedExDate_Value");

                entity.Property(e => e.DistributionTypeCode).HasColumnType("varchar");

                entity.Property(e => e.DividendFrequencyCode).HasColumnType("varchar");

                entity.Property(e => e.DueDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("DueDate_IsSet");

                entity.Property(e => e.DueDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("DueDate_Type");

                entity.Property(e => e.DueDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("DueDate_UtcOffset");

                entity.Property(e => e.DueDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("DueDate_Value");

                entity.Property(e => e.EffectiveDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("EffectiveDate_IsSet");

                entity.Property(e => e.EffectiveDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("EffectiveDate_Type");

                entity.Property(e => e.EffectiveDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("EffectiveDate_UtcOffset");

                entity.Property(e => e.EffectiveDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("EffectiveDate_Value");

                entity.Property(e => e.EntitlementPeriodEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EntitlementPeriod_EndDate");

                entity.Property(e => e.EntitlementPeriodIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("EntitlementPeriod_IsSet");

                entity.Property(e => e.EntitlementPeriodStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EntitlementPeriod_StartDate");

                entity.Property(e => e.EntitlementPeriodType)
                    .HasColumnType("varchar")
                    .HasColumnName("EntitlementPeriod_Type");

                entity.Property(e => e.Etag)
                    .HasColumnType("varchar")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EusdInterestProportionChIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("EusdInterestProportionCh_IsSet");

                entity.Property(e => e.EusdInterestProportionChPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("EusdInterestProportionCh_PrimaryCurrencyCode");

                entity.Property(e => e.EusdInterestProportionChPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("EusdInterestProportionCh_PrimaryValue");

                entity.Property(e => e.EusdInterestProportionChSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("EusdInterestProportionCh_SecondaryCurrencyCode");

                entity.Property(e => e.EusdInterestProportionChSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("EusdInterestProportionCh_SecondaryValue");

                entity.Property(e => e.EusdInterestProportionChType)
                    .HasColumnType("varchar")
                    .HasColumnName("EusdInterestProportionCh_Type");

                entity.Property(e => e.EusdInterestProportionEuIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("EusdInterestProportionEu_IsSet");

                entity.Property(e => e.EusdInterestProportionEuPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("EusdInterestProportionEu_PrimaryCurrencyCode");

                entity.Property(e => e.EusdInterestProportionEuPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("EusdInterestProportionEu_PrimaryValue");

                entity.Property(e => e.EusdInterestProportionEuSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("EusdInterestProportionEu_SecondaryCurrencyCode");

                entity.Property(e => e.EusdInterestProportionEuSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("EusdInterestProportionEu_SecondaryValue");

                entity.Property(e => e.EusdInterestProportionEuType)
                    .HasColumnType("varchar")
                    .HasColumnName("EusdInterestProportionEu_Type");

                entity.Property(e => e.EventDeadline).HasColumnType("datetime");

                entity.Property(e => e.EventTypeCode).HasColumnType("varchar");

                entity.Property(e => e.ExDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("ExDate_IsSet");

                entity.Property(e => e.ExDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("ExDate_Type");

                entity.Property(e => e.ExDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("ExDate_UtcOffset");

                entity.Property(e => e.ExDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("ExDate_Value");

                entity.Property(e => e.ExemptionCode).HasColumnType("int");

                entity.Property(e => e.ExpiryDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("ExpiryDate_IsSet");

                entity.Property(e => e.ExpiryDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("ExpiryDate_Type");

                entity.Property(e => e.ExpiryDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("ExpiryDate_UtcOffset");

                entity.Property(e => e.ExpiryDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("ExpiryDate_Value");

                entity.Property(e => e.ExtendedNarrativeSerialized).HasColumnType("varchar");

                entity.Property(e => e.FamilyCode).HasColumnType("varchar");

                entity.Property(e => e.FeesIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("Fees_IsSet");

                entity.Property(e => e.FeesPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("Fees_PrimaryCurrencyCode");

                entity.Property(e => e.FeesPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("Fees_PrimaryValue");

                entity.Property(e => e.FeesSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("Fees_SecondaryCurrencyCode");

                entity.Property(e => e.FeesSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("Fees_SecondaryValue");

                entity.Property(e => e.FeesType)
                    .HasColumnType("varchar")
                    .HasColumnName("Fees_Type");

                entity.Property(e => e.FilingDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("FilingDate_IsSet");

                entity.Property(e => e.FilingDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("FilingDate_Type");

                entity.Property(e => e.FilingDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("FilingDate_UtcOffset");

                entity.Property(e => e.FilingDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("FilingDate_Value");

                entity.Property(e => e.FiscalStampIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("FiscalStamp_IsSet");

                entity.Property(e => e.FiscalStampPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("FiscalStamp_PrimaryCurrencyCode");

                entity.Property(e => e.FiscalStampPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("FiscalStamp_PrimaryValue");

                entity.Property(e => e.FiscalStampSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("FiscalStamp_SecondaryCurrencyCode");

                entity.Property(e => e.FiscalStampSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("FiscalStamp_SecondaryValue");

                entity.Property(e => e.FiscalStampType)
                    .HasColumnType("varchar")
                    .HasColumnName("FiscalStamp_Type");

                entity.Property(e => e.FixingDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("FixingDate_IsSet");

                entity.Property(e => e.FixingDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("FixingDate_Type");

                entity.Property(e => e.FixingDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("FixingDate_UtcOffset");

                entity.Property(e => e.FixingDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("FixingDate_Value");

                entity.Property(e => e.FloatingRateFixingDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("FloatingRateFixingDate_IsSet");

                entity.Property(e => e.FloatingRateFixingDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("FloatingRateFixingDate_Type");

                entity.Property(e => e.FloatingRateFixingDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("FloatingRateFixingDate_UtcOffset");

                entity.Property(e => e.FloatingRateFixingDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("FloatingRateFixingDate_Value");

                entity.Property(e => e.Forexo).HasColumnType("bool");

                entity.Property(e => e.FrenchTaxRateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("FrenchTaxRate_IsSet");

                entity.Property(e => e.FrenchTaxRatePrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("FrenchTaxRate_PrimaryCurrencyCode");

                entity.Property(e => e.FrenchTaxRatePrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("FrenchTaxRate_PrimaryValue");

                entity.Property(e => e.FrenchTaxRateSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("FrenchTaxRate_SecondaryCurrencyCode");

                entity.Property(e => e.FrenchTaxRateSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("FrenchTaxRate_SecondaryValue");

                entity.Property(e => e.FrenchTaxRateType)
                    .HasColumnType("varchar")
                    .HasColumnName("FrenchTaxRate_Type");

                entity.Property(e => e.Guid).HasColumnType("varchar");

                entity.Property(e => e.HasNoConflicts).HasColumnType("bool");

                entity.Property(e => e.IEventId)
                    .HasColumnType("varchar")
                    .HasColumnName("I_EventId");

                entity.Property(e => e.IId)
                    .HasColumnType("bigint")
                    .HasColumnName("I_Id");

                entity.Property(e => e.IncomeCode).HasColumnType("int");

                entity.Property(e => e.IncomeTypeCode).HasColumnType("varchar");

                entity.Property(e => e.InformationStatusCode).HasColumnType("varchar");

                entity.Property(e => e.InformationStatusTypeCode).HasColumnType("varchar");

                entity.Property(e => e.InstrumentIdentityId).HasColumnType("bigint");

                entity.Property(e => e.InterestAmount).HasColumnType("decimal");

                entity.Property(e => e.InterestCalculationMethodCode).HasColumnType("varchar");

                entity.Property(e => e.InterestDaysPerAnnum).HasColumnType("decimal");

                entity.Property(e => e.InterestFractionIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("InterestFraction_IsSet");

                entity.Property(e => e.InterestFractionPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("InterestFraction_PrimaryCurrencyCode");

                entity.Property(e => e.InterestFractionPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("InterestFraction_PrimaryValue");

                entity.Property(e => e.InterestFractionSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("InterestFraction_SecondaryCurrencyCode");

                entity.Property(e => e.InterestFractionSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("InterestFraction_SecondaryValue");

                entity.Property(e => e.InterestFractionType)
                    .HasColumnType("varchar")
                    .HasColumnName("InterestFraction_Type");

                entity.Property(e => e.InterestPeriodEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("InterestPeriod_EndDate");

                entity.Property(e => e.InterestPeriodIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("InterestPeriod_IsSet");

                entity.Property(e => e.InterestPeriodStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("InterestPeriod_StartDate");

                entity.Property(e => e.InterestPeriodType)
                    .HasColumnType("varchar")
                    .HasColumnName("InterestPeriod_Type");

                entity.Property(e => e.InterestRateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("InterestRate_IsSet");

                entity.Property(e => e.InterestRatePrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("InterestRate_PrimaryCurrencyCode");

                entity.Property(e => e.InterestRatePrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("InterestRate_PrimaryValue");

                entity.Property(e => e.InterestRateSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("InterestRate_SecondaryCurrencyCode");

                entity.Property(e => e.InterestRateSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("InterestRate_SecondaryValue");

                entity.Property(e => e.InterestRateType)
                    .HasColumnType("varchar")
                    .HasColumnName("InterestRate_Type");

                entity.Property(e => e.IntermediateInstrumentIdentityId).HasColumnType("bigint");

                entity.Property(e => e.IntermediateSecuritiesDispositionOfFractionCode).HasColumnType("varchar");

                entity.Property(e => e.IntermediateSecuritiesDistributionTypeCode).HasColumnType("varchar");

                entity.Property(e => e.IntermediateSecuritiesExpiryDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("IntermediateSecuritiesExpiryDate_IsSet");

                entity.Property(e => e.IntermediateSecuritiesExpiryDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("IntermediateSecuritiesExpiryDate_Type");

                entity.Property(e => e.IntermediateSecuritiesExpiryDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("IntermediateSecuritiesExpiryDate_UtcOffset");

                entity.Property(e => e.IntermediateSecuritiesExpiryDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("IntermediateSecuritiesExpiryDate_Value");

                entity.Property(e => e.IntermediateSecuritiesRenounceableIndicatorCode).HasColumnType("varchar");

                entity.Property(e => e.IntermediateSecuritiesToUnderlyingRatioIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("IntermediateSecuritiesToUnderlyingRatio_IsSet");

                entity.Property(e => e.IntermediateSecuritiesToUnderlyingRatioPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("IntermediateSecuritiesToUnderlyingRatio_PrimaryCurrencyCode");

                entity.Property(e => e.IntermediateSecuritiesToUnderlyingRatioPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("IntermediateSecuritiesToUnderlyingRatio_PrimaryValue");

                entity.Property(e => e.IntermediateSecuritiesToUnderlyingRatioSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("IntermediateSecuritiesToUnderlyingRatio_SecondaryCurrencyCode");

                entity.Property(e => e.IntermediateSecuritiesToUnderlyingRatioSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("IntermediateSecuritiesToUnderlyingRatio_SecondaryValue");

                entity.Property(e => e.IntermediateSecuritiesToUnderlyingRatioType)
                    .HasColumnType("varchar")
                    .HasColumnName("IntermediateSecuritiesToUnderlyingRatio_Type");

                entity.Property(e => e.IntermediateSecuritiesTradingPeriodEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("IntermediateSecuritiesTradingPeriod_EndDate");

                entity.Property(e => e.IntermediateSecuritiesTradingPeriodIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("IntermediateSecuritiesTradingPeriod_IsSet");

                entity.Property(e => e.IntermediateSecuritiesTradingPeriodStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("IntermediateSecuritiesTradingPeriod_StartDate");

                entity.Property(e => e.IntermediateSecuritiesTradingPeriodType)
                    .HasColumnType("varchar")
                    .HasColumnName("IntermediateSecuritiesTradingPeriod_Type");

                entity.Property(e => e.IsComplete).HasColumnType("bool");

                entity.Property(e => e.IsConfirmed).HasColumnType("bool");

                entity.Property(e => e.IsNarrativeChecked).HasColumnType("bool");

                entity.Property(e => e.JsonAdditionalTax).HasColumnType("varchar");

                entity.Property(e => e.JsonBidIntervalRate).HasColumnType("varchar");

                entity.Property(e => e.JsonBookClosureperiod).HasColumnType("varchar");

                entity.Property(e => e.JsonDepositorysuspensionperiodforwithdrawalatagent).HasColumnType("varchar");

                entity.Property(e => e.JsonEusdInterestProportionCh).HasColumnType("varchar");

                entity.Property(e => e.JsonEusdInterestProportionEu).HasColumnType("varchar");

                entity.Property(e => e.JsonFees).HasColumnType("varchar");

                entity.Property(e => e.JsonFilingDate).HasColumnType("varchar");

                entity.Property(e => e.JsonFiscalStamp).HasColumnType("varchar");

                entity.Property(e => e.JsonFrenchTaxRate).HasColumnType("varchar");

                entity.Property(e => e.JsonInterestFraction).HasColumnType("varchar");

                entity.Property(e => e.JsonInterestRate).HasColumnType("varchar");

                entity.Property(e => e.JsonIntermediateSecuritiesToUnderlyingRatio).HasColumnType("varchar");

                entity.Property(e => e.JsonLotteryDateTime).HasColumnType("varchar");

                entity.Property(e => e.JsonMarketclaimtrackingenddate).HasColumnType("varchar");

                entity.Property(e => e.JsonMaximumPrice).HasColumnType("varchar");

                entity.Property(e => e.JsonMaximumquantityofsecurities).HasColumnType("varchar");

                entity.Property(e => e.JsonMinimumPrice).HasColumnType("varchar");

                entity.Property(e => e.JsonMinimumQuantitysought).HasColumnType("varchar");

                entity.Property(e => e.JsonNewPoolFactor).HasColumnType("varchar");

                entity.Property(e => e.JsonNraamount)
                    .HasColumnType("varchar")
                    .HasColumnName("JsonNRAAmount");

                entity.Property(e => e.JsonNrarate)
                    .HasColumnType("varchar")
                    .HasColumnName("JsonNRARate");

                entity.Property(e => e.JsonOfficialAnnouncementPublicationDateTime).HasColumnType("varchar");

                entity.Property(e => e.JsonOldPoolFactor).HasColumnType("varchar");

                entity.Property(e => e.JsonPercentageSought).HasColumnType("varchar");

                entity.Property(e => e.JsonPremiumFraction).HasColumnType("varchar");

                entity.Property(e => e.JsonRefundOfNra)
                    .HasColumnType("varchar")
                    .HasColumnName("JsonRefundOfNRA");

                entity.Property(e => e.JsonResultPublicationDateTime).HasColumnType("varchar");

                entity.Property(e => e.JsonTaxCreditRate).HasColumnType("varchar");

                entity.Property(e => e.JsonTaxOnIncome).HasColumnType("varchar");

                entity.Property(e => e.JsonTaxOnProfits).HasColumnType("varchar");

                entity.Property(e => e.JsonTaxRate).HasColumnType("varchar");

                entity.Property(e => e.JsonTaxRelatedRate).HasColumnType("varchar");

                entity.Property(e => e.JsonTidch)
                    .HasColumnType("varchar")
                    .HasColumnName("JsonTIDCH");

                entity.Property(e => e.JsonTideu)
                    .HasColumnType("varchar")
                    .HasColumnName("JsonTIDEU");

                entity.Property(e => e.JsonWithholdingTaxRate).HasColumnType("varchar");

                entity.Property(e => e.LastChangeDate).HasColumnType("datetime");

                entity.Property(e => e.LastDistributionDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("LastDistributionDate_IsSet");

                entity.Property(e => e.LastDistributionDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("LastDistributionDate_Type");

                entity.Property(e => e.LastDistributionDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("LastDistributionDate_UtcOffset");

                entity.Property(e => e.LastDistributionDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("LastDistributionDate_Value");

                entity.Property(e => e.LastIgnoredRelevantHashcode).HasColumnType("int");

                entity.Property(e => e.LinkedCustomProperties).HasColumnType("varchar");

                entity.Property(e => e.LinkedOptions).HasColumnType("varchar");

                entity.Property(e => e.LinkedSilverCopies).HasColumnType("varchar");

                entity.Property(e => e.LotteryDateTimeIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("LotteryDateTime_IsSet");

                entity.Property(e => e.LotteryDateTimeType)
                    .HasColumnType("varchar")
                    .HasColumnName("LotteryDateTime_Type");

                entity.Property(e => e.LotteryDateTimeUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("LotteryDateTime_UtcOffset");

                entity.Property(e => e.LotteryDateTimeValue)
                    .HasColumnType("datetime")
                    .HasColumnName("LotteryDateTime_Value");

                entity.Property(e => e.MandatoryVoluntaryIndicatorCode).HasColumnType("varchar");

                entity.Property(e => e.MarketclaimtrackingenddateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("Marketclaimtrackingenddate_IsSet");

                entity.Property(e => e.MarketclaimtrackingenddateType)
                    .HasColumnType("varchar")
                    .HasColumnName("Marketclaimtrackingenddate_Type");

                entity.Property(e => e.MarketclaimtrackingenddateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("Marketclaimtrackingenddate_UtcOffset");

                entity.Property(e => e.MarketclaimtrackingenddateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("Marketclaimtrackingenddate_Value");

                entity.Property(e => e.MaximumPriceCode)
                    .HasColumnType("varchar")
                    .HasColumnName("MaximumPrice_Code");

                entity.Property(e => e.MaximumPriceCurrency2Code)
                    .HasColumnType("varchar")
                    .HasColumnName("MaximumPrice_Currency2Code");

                entity.Property(e => e.MaximumPriceCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("MaximumPrice_CurrencyCode");

                entity.Property(e => e.MaximumPriceIsCalculated)
                    .HasColumnType("bool")
                    .HasColumnName("MaximumPrice_IsCalculated");

                entity.Property(e => e.MaximumPriceIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("MaximumPrice_IsSet");

                entity.Property(e => e.MaximumPriceQuantity)
                    .HasColumnType("decimal")
                    .HasColumnName("MaximumPrice_Quantity");

                entity.Property(e => e.MaximumPriceQuantityTypeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("MaximumPrice_QuantityTypeCode");

                entity.Property(e => e.MaximumPriceType)
                    .HasColumnType("varchar")
                    .HasColumnName("MaximumPrice_Type");

                entity.Property(e => e.MaximumPriceValue)
                    .HasColumnType("decimal")
                    .HasColumnName("MaximumPrice_Value");

                entity.Property(e => e.MaximumPriceValue2)
                    .HasColumnType("decimal")
                    .HasColumnName("MaximumPrice_Value2");

                entity.Property(e => e.MaximumquantityofsecuritiesIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("Maximumquantityofsecurities_IsSet");

                entity.Property(e => e.MaximumquantityofsecuritiesType)
                    .HasColumnType("varchar")
                    .HasColumnName("Maximumquantityofsecurities_Type");

                entity.Property(e => e.MaximumquantityofsecuritiesValue)
                    .HasColumnType("decimal")
                    .HasColumnName("Maximumquantityofsecurities_Value");

                entity.Property(e => e.MeetingDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("MeetingDate_IsSet");

                entity.Property(e => e.MeetingDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("MeetingDate_Type");

                entity.Property(e => e.MeetingDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("MeetingDate_UtcOffset");

                entity.Property(e => e.MeetingDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("MeetingDate_Value");

                entity.Property(e => e.MinimumPriceCode)
                    .HasColumnType("varchar")
                    .HasColumnName("MinimumPrice_Code");

                entity.Property(e => e.MinimumPriceCurrency2Code)
                    .HasColumnType("varchar")
                    .HasColumnName("MinimumPrice_Currency2Code");

                entity.Property(e => e.MinimumPriceCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("MinimumPrice_CurrencyCode");

                entity.Property(e => e.MinimumPriceIsCalculated)
                    .HasColumnType("bool")
                    .HasColumnName("MinimumPrice_IsCalculated");

                entity.Property(e => e.MinimumPriceIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("MinimumPrice_IsSet");

                entity.Property(e => e.MinimumPriceQuantity)
                    .HasColumnType("decimal")
                    .HasColumnName("MinimumPrice_Quantity");

                entity.Property(e => e.MinimumPriceQuantityTypeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("MinimumPrice_QuantityTypeCode");

                entity.Property(e => e.MinimumPriceType)
                    .HasColumnType("varchar")
                    .HasColumnName("MinimumPrice_Type");

                entity.Property(e => e.MinimumPriceValue)
                    .HasColumnType("decimal")
                    .HasColumnName("MinimumPrice_Value");

                entity.Property(e => e.MinimumPriceValue2)
                    .HasColumnType("decimal")
                    .HasColumnName("MinimumPrice_Value2");

                entity.Property(e => e.MinimumProcessingLevel).HasColumnType("varchar");

                entity.Property(e => e.MinimumQuantitysoughtIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("MinimumQuantitysought_IsSet");

                entity.Property(e => e.MinimumQuantitysoughtType)
                    .HasColumnType("varchar")
                    .HasColumnName("MinimumQuantitysought_Type");

                entity.Property(e => e.MinimumQuantitysoughtValue)
                    .HasColumnType("decimal")
                    .HasColumnName("MinimumQuantitysought_Value");

                entity.Property(e => e.NarrativeSerialized).HasColumnType("varchar");

                entity.Property(e => e.NewName).HasColumnType("varchar");

                entity.Property(e => e.NewPoolFactorIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("NewPoolFactor_IsSet");

                entity.Property(e => e.NewPoolFactorPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NewPoolFactor_PrimaryCurrencyCode");

                entity.Property(e => e.NewPoolFactorPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("NewPoolFactor_PrimaryValue");

                entity.Property(e => e.NewPoolFactorSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NewPoolFactor_SecondaryCurrencyCode");

                entity.Property(e => e.NewPoolFactorSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("NewPoolFactor_SecondaryValue");

                entity.Property(e => e.NewPoolFactorType)
                    .HasColumnType("varchar")
                    .HasColumnName("NewPoolFactor_Type");

                entity.Property(e => e.NraamountCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NRAAmount_Code");

                entity.Property(e => e.NraamountCurrency2Code)
                    .HasColumnType("varchar")
                    .HasColumnName("NRAAmount_Currency2Code");

                entity.Property(e => e.NraamountCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NRAAmount_CurrencyCode");

                entity.Property(e => e.NraamountIsCalculated)
                    .HasColumnType("bool")
                    .HasColumnName("NRAAmount_IsCalculated");

                entity.Property(e => e.NraamountIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("NRAAmount_IsSet");

                entity.Property(e => e.NraamountQuantity)
                    .HasColumnType("decimal")
                    .HasColumnName("NRAAmount_Quantity");

                entity.Property(e => e.NraamountQuantityTypeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NRAAmount_QuantityTypeCode");

                entity.Property(e => e.NraamountType)
                    .HasColumnType("varchar")
                    .HasColumnName("NRAAmount_Type");

                entity.Property(e => e.NraamountValue)
                    .HasColumnType("decimal")
                    .HasColumnName("NRAAmount_Value");

                entity.Property(e => e.NraamountValue2)
                    .HasColumnType("decimal")
                    .HasColumnName("NRAAmount_Value2");

                entity.Property(e => e.NrarateCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NRARate_Code");

                entity.Property(e => e.NrarateCurrency2Code)
                    .HasColumnType("varchar")
                    .HasColumnName("NRARate_Currency2Code");

                entity.Property(e => e.NrarateCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NRARate_CurrencyCode");

                entity.Property(e => e.NrarateIsCalculated)
                    .HasColumnType("bool")
                    .HasColumnName("NRARate_IsCalculated");

                entity.Property(e => e.NrarateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("NRARate_IsSet");

                entity.Property(e => e.NrarateQuantity)
                    .HasColumnType("decimal")
                    .HasColumnName("NRARate_Quantity");

                entity.Property(e => e.NrarateQuantityTypeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NRARate_QuantityTypeCode");

                entity.Property(e => e.NrarateType)
                    .HasColumnType("varchar")
                    .HasColumnName("NRARate_Type");

                entity.Property(e => e.NrarateValue)
                    .HasColumnType("decimal")
                    .HasColumnName("NRARate_Value");

                entity.Property(e => e.NrarateValue2)
                    .HasColumnType("decimal")
                    .HasColumnName("NRARate_Value2");

                entity.Property(e => e.OfferTypeCode).HasColumnType("varchar");

                entity.Property(e => e.Offeror).HasColumnType("varchar");

                entity.Property(e => e.OfficialAnnouncementPublicationDateTimeIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("OfficialAnnouncementPublicationDateTime_IsSet");

                entity.Property(e => e.OfficialAnnouncementPublicationDateTimeType)
                    .HasColumnType("varchar")
                    .HasColumnName("OfficialAnnouncementPublicationDateTime_Type");

                entity.Property(e => e.OfficialAnnouncementPublicationDateTimeUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("OfficialAnnouncementPublicationDateTime_UtcOffset");

                entity.Property(e => e.OfficialAnnouncementPublicationDateTimeValue)
                    .HasColumnType("datetime")
                    .HasColumnName("OfficialAnnouncementPublicationDateTime_Value");

                entity.Property(e => e.OfficialEventReference).HasColumnType("varchar");

                entity.Property(e => e.OldPoolFactorIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("OldPoolFactor_IsSet");

                entity.Property(e => e.OldPoolFactorPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("OldPoolFactor_PrimaryCurrencyCode");

                entity.Property(e => e.OldPoolFactorPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("OldPoolFactor_PrimaryValue");

                entity.Property(e => e.OldPoolFactorSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("OldPoolFactor_SecondaryCurrencyCode");

                entity.Property(e => e.OldPoolFactorSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("OldPoolFactor_SecondaryValue");

                entity.Property(e => e.OldPoolFactorType)
                    .HasColumnType("varchar")
                    .HasColumnName("OldPoolFactor_Type");

                entity.Property(e => e.OptionCount).HasColumnType("int");

                entity.Property(e => e.OrderTypeCode).HasColumnType("varchar");

                entity.Property(e => e.OwnerCode).HasColumnType("varchar");

                entity.Property(e => e.ParentEvent).HasColumnType("varchar");

                entity.Property(e => e.ParentIncomeCode).HasColumnType("int");

                entity.Property(e => e.PartialTypeOfDividendCode).HasColumnType("varchar");

                entity.Property(e => e.PaymentDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("PaymentDate_IsSet");

                entity.Property(e => e.PaymentDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("PaymentDate_Type");

                entity.Property(e => e.PaymentDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("PaymentDate_UtcOffset");

                entity.Property(e => e.PaymentDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("PaymentDate_Value");

                entity.Property(e => e.PaymentFunctionCode).HasColumnType("varchar");

                entity.Property(e => e.PercentageSoughtIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("PercentageSought_IsSet");

                entity.Property(e => e.PercentageSoughtPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("PercentageSought_PrimaryCurrencyCode");

                entity.Property(e => e.PercentageSoughtPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("PercentageSought_PrimaryValue");

                entity.Property(e => e.PercentageSoughtSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("PercentageSought_SecondaryCurrencyCode");

                entity.Property(e => e.PercentageSoughtSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("PercentageSought_SecondaryValue");

                entity.Property(e => e.PercentageSoughtType)
                    .HasColumnType("varchar")
                    .HasColumnName("PercentageSought_Type");

                entity.Property(e => e.PlaceOfListing).HasColumnType("varchar");

                entity.Property(e => e.PostingDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("PostingDate_IsSet");

                entity.Property(e => e.PostingDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("PostingDate_Type");

                entity.Property(e => e.PostingDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("PostingDate_UtcOffset");

                entity.Property(e => e.PostingDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("PostingDate_Value");

                entity.Property(e => e.PremiumFractionIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("PremiumFraction_IsSet");

                entity.Property(e => e.PremiumFractionPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("PremiumFraction_PrimaryCurrencyCode");

                entity.Property(e => e.PremiumFractionPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("PremiumFraction_PrimaryValue");

                entity.Property(e => e.PremiumFractionSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("PremiumFraction_SecondaryCurrencyCode");

                entity.Property(e => e.PremiumFractionSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("PremiumFraction_SecondaryValue");

                entity.Property(e => e.PremiumFractionType)
                    .HasColumnType("varchar")
                    .HasColumnName("PremiumFraction_Type");

                entity.Property(e => e.ProcessingStateCode).HasColumnType("varchar");

                entity.Property(e => e.PublicationWindowEndDate).HasColumnType("datetime");

                entity.Property(e => e.QuotationTypeCode).HasColumnType("varchar");

                entity.Property(e => e.RatingCode).HasColumnType("varchar");

                entity.Property(e => e.RecordDateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("RecordDate_IsSet");

                entity.Property(e => e.RecordDateType)
                    .HasColumnType("varchar")
                    .HasColumnName("RecordDate_Type");

                entity.Property(e => e.RecordDateUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("RecordDate_UtcOffset");

                entity.Property(e => e.RecordDateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("RecordDate_Value");

                entity.Property(e => e.ReferenceDate).HasColumnType("datetime");

                entity.Property(e => e.RefundOfNraCode)
                    .HasColumnType("varchar")
                    .HasColumnName("RefundOfNRA_Code");

                entity.Property(e => e.RefundOfNraCurrency2Code)
                    .HasColumnType("varchar")
                    .HasColumnName("RefundOfNRA_Currency2Code");

                entity.Property(e => e.RefundOfNraCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("RefundOfNRA_CurrencyCode");

                entity.Property(e => e.RefundOfNraIsCalculated)
                    .HasColumnType("bool")
                    .HasColumnName("RefundOfNRA_IsCalculated");

                entity.Property(e => e.RefundOfNraIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("RefundOfNRA_IsSet");

                entity.Property(e => e.RefundOfNraQuantity)
                    .HasColumnType("decimal")
                    .HasColumnName("RefundOfNRA_Quantity");

                entity.Property(e => e.RefundOfNraQuantityTypeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("RefundOfNRA_QuantityTypeCode");

                entity.Property(e => e.RefundOfNraType)
                    .HasColumnType("varchar")
                    .HasColumnName("RefundOfNRA_Type");

                entity.Property(e => e.RefundOfNraValue)
                    .HasColumnType("decimal")
                    .HasColumnName("RefundOfNRA_Value");

                entity.Property(e => e.RefundOfNraValue2)
                    .HasColumnType("decimal")
                    .HasColumnName("RefundOfNRA_Value2");

                entity.Property(e => e.RelevantPropertiesHashcode).HasColumnType("int");

                entity.Property(e => e.RenounceableIndicatorCode).HasColumnType("varchar");

                entity.Property(e => e.ResultPublicationDateTimeIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("ResultPublicationDateTime_IsSet");

                entity.Property(e => e.ResultPublicationDateTimeType)
                    .HasColumnType("varchar")
                    .HasColumnName("ResultPublicationDateTime_Type");

                entity.Property(e => e.ResultPublicationDateTimeUtcOffset)
                    .HasColumnType("varchar")
                    .HasColumnName("ResultPublicationDateTime_UtcOffset");

                entity.Property(e => e.ResultPublicationDateTimeValue)
                    .HasColumnType("datetime")
                    .HasColumnName("ResultPublicationDateTime_Value");

                entity.Property(e => e.SecurityPosition).HasColumnType("decimal");

                entity.Property(e => e.SilverCopyCount).HasColumnType("int");

                entity.Property(e => e.State).HasColumnType("varchar");

                entity.Property(e => e.SwiftMessageFunctionCode).HasColumnType("varchar");

                entity.Property(e => e.TargetSystemId).HasColumnType("varchar");

                entity.Property(e => e.TargetSystemStateCode).HasColumnType("varchar");

                entity.Property(e => e.TaxAmountTypeCode).HasColumnType("varchar");

                entity.Property(e => e.TaxCreditRateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("TaxCreditRate_IsSet");

                entity.Property(e => e.TaxCreditRatePrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxCreditRate_PrimaryCurrencyCode");

                entity.Property(e => e.TaxCreditRatePrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TaxCreditRate_PrimaryValue");

                entity.Property(e => e.TaxCreditRateSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxCreditRate_SecondaryCurrencyCode");

                entity.Property(e => e.TaxCreditRateSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TaxCreditRate_SecondaryValue");

                entity.Property(e => e.TaxCreditRateType)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxCreditRate_Type");

                entity.Property(e => e.TaxOnIncomeIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("TaxOnIncome_IsSet");

                entity.Property(e => e.TaxOnIncomePrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxOnIncome_PrimaryCurrencyCode");

                entity.Property(e => e.TaxOnIncomePrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TaxOnIncome_PrimaryValue");

                entity.Property(e => e.TaxOnIncomeSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxOnIncome_SecondaryCurrencyCode");

                entity.Property(e => e.TaxOnIncomeSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TaxOnIncome_SecondaryValue");

                entity.Property(e => e.TaxOnIncomeType)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxOnIncome_Type");

                entity.Property(e => e.TaxOnProfitsIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("TaxOnProfits_IsSet");

                entity.Property(e => e.TaxOnProfitsPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxOnProfits_PrimaryCurrencyCode");

                entity.Property(e => e.TaxOnProfitsPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TaxOnProfits_PrimaryValue");

                entity.Property(e => e.TaxOnProfitsSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxOnProfits_SecondaryCurrencyCode");

                entity.Property(e => e.TaxOnProfitsSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TaxOnProfits_SecondaryValue");

                entity.Property(e => e.TaxOnProfitsType)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxOnProfits_Type");

                entity.Property(e => e.TaxRateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("TaxRate_IsSet");

                entity.Property(e => e.TaxRatePrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxRate_PrimaryCurrencyCode");

                entity.Property(e => e.TaxRatePrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TaxRate_PrimaryValue");

                entity.Property(e => e.TaxRateSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxRate_SecondaryCurrencyCode");

                entity.Property(e => e.TaxRateSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TaxRate_SecondaryValue");

                entity.Property(e => e.TaxRateType)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxRate_Type");

                entity.Property(e => e.TaxRelatedRateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("TaxRelatedRate_IsSet");

                entity.Property(e => e.TaxRelatedRatePrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxRelatedRate_PrimaryCurrencyCode");

                entity.Property(e => e.TaxRelatedRatePrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TaxRelatedRate_PrimaryValue");

                entity.Property(e => e.TaxRelatedRateSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxRelatedRate_SecondaryCurrencyCode");

                entity.Property(e => e.TaxRelatedRateSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TaxRelatedRate_SecondaryValue");

                entity.Property(e => e.TaxRelatedRateType)
                    .HasColumnType("varchar")
                    .HasColumnName("TaxRelatedRate_Type");

                entity.Property(e => e.TidchIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("TIDCH_IsSet");

                entity.Property(e => e.TidchPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TIDCH_PrimaryCurrencyCode");

                entity.Property(e => e.TidchPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TIDCH_PrimaryValue");

                entity.Property(e => e.TidchSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TIDCH_SecondaryCurrencyCode");

                entity.Property(e => e.TidchSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TIDCH_SecondaryValue");

                entity.Property(e => e.TidchType)
                    .HasColumnType("varchar")
                    .HasColumnName("TIDCH_Type");

                entity.Property(e => e.TideuIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("TIDEU_IsSet");

                entity.Property(e => e.TideuPrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TIDEU_PrimaryCurrencyCode");

                entity.Property(e => e.TideuPrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TIDEU_PrimaryValue");

                entity.Property(e => e.TideuSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TIDEU_SecondaryCurrencyCode");

                entity.Property(e => e.TideuSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("TIDEU_SecondaryValue");

                entity.Property(e => e.TideuType)
                    .HasColumnType("varchar")
                    .HasColumnName("TIDEU_Type");

                entity.Property(e => e.TransactionTypeCode).HasColumnType("varchar");

                entity.Property(e => e.TypeOfDividendCode).HasColumnType("varchar");

                entity.Property(e => e.TypeOfListingCode).HasColumnType("varchar");

                entity.Property(e => e.TypeOfPaymentAmountCode).HasColumnType("varchar");

                entity.Property(e => e.TypeOfPaymentAmountList).HasColumnType("varchar");

                entity.Property(e => e.ValidationTypeCode).HasColumnType("varchar");

                entity.Property(e => e.VdfAmortizationType).HasColumnType("varchar");

                entity.Property(e => e.VdfCashFlowId)
                    .HasColumnType("varchar")
                    .HasColumnName("VdfCashFlowID");

                entity.Property(e => e.VdfCashflowType).HasColumnType("varchar");

                entity.Property(e => e.VdfChId).HasColumnType("varchar");

                entity.Property(e => e.VdfDividendSupplInfoCode).HasColumnType("varchar");

                entity.Property(e => e.VdfDividendTypeCode).HasColumnType("varchar");

                entity.Property(e => e.VdfMessageItemCode).HasColumnType("varchar");

                entity.Property(e => e.VdfPaymentAmountType).HasColumnType("varchar");

                entity.Property(e => e.WithholdingOfForeignTax).HasColumnType("varchar");

                entity.Property(e => e.WithholdingOfLocalTax).HasColumnType("varchar");

                entity.Property(e => e.WithholdingTaxRateIsSet)
                    .HasColumnType("bool")
                    .HasColumnName("WithholdingTaxRate_IsSet");

                entity.Property(e => e.WithholdingTaxRatePrimaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("WithholdingTaxRate_PrimaryCurrencyCode");

                entity.Property(e => e.WithholdingTaxRatePrimaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("WithholdingTaxRate_PrimaryValue");

                entity.Property(e => e.WithholdingTaxRateSecondaryCurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("WithholdingTaxRate_SecondaryCurrencyCode");

                entity.Property(e => e.WithholdingTaxRateSecondaryValue)
                    .HasColumnType("decimal")
                    .HasColumnName("WithholdingTaxRate_SecondaryValue");

                entity.Property(e => e.WithholdingTaxRateType)
                    .HasColumnType("varchar")
                    .HasColumnName("WithholdingTaxRate_Type");
            });

            modelBuilder.Entity<Exchange>(entity =>
            {
                entity.ToTable("Exchange", "OData");

                entity.HasIndex(e => e.Id, "CDATA_ODATA_EXCHANGE_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint");

                entity.Property(e => e.BbgpricingSource)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGPricingSource");

                entity.Property(e => e.CountryCode).HasColumnType("varchar");

                entity.Property(e => e.Description).HasColumnType("varchar");

                entity.Property(e => e.Etag)
                    .HasColumnType("varchar")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeTypeCode).HasColumnType("varchar");

                entity.Property(e => e.HolidayCalendarId)
                    .HasColumnType("bigint")
                    .HasColumnName("HolidayCalendar_Id");

                entity.Property(e => e.IGainExchangeId)
                    .HasColumnType("varchar")
                    .HasColumnName("I_GainExchangeId");

                entity.Property(e => e.IId)
                    .HasColumnType("bigint")
                    .HasColumnName("I_Id");

                entity.Property(e => e.IdcexchangeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("IDCExchangeCode");

                entity.Property(e => e.LinkedCustomProperties).HasColumnType("varchar");

                entity.Property(e => e.LinkedSilverCopies).HasColumnType("varchar");

                entity.Property(e => e.Mic)
                    .HasColumnType("varchar")
                    .HasColumnName("MIC");

                entity.Property(e => e.Name).HasColumnType("varchar");

                entity.Property(e => e.ParentExchangeId)
                    .HasColumnType("bigint")
                    .HasColumnName("ParentExchange_Id");

                entity.Property(e => e.SixBcncode)
                    .HasColumnType("varchar")
                    .HasColumnName("SixBCNCode");

                entity.Property(e => e.StatusCode).HasColumnType("varchar");

                entity.Property(e => e.TrexchangeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("TRExchangeCode");

                entity.Property(e => e.Url)
                    .HasColumnType("varchar")
                    .HasColumnName("URL");

                entity.Property(e => e.WeekendCode).HasColumnType("varchar");

                entity.Property(e => e.WmExchangeCode).HasColumnType("varchar");
            });

            modelBuilder.Entity<Holding>(entity =>
            {
                entity.ToTable("Holding", "OData");

                entity.HasIndex(e => e.Id, "CDATA_ODATA_HOLDING_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint");

                entity.Property(e => e.AssimilatedAsset).HasColumnType("bool");

                entity.Property(e => e.CollateralAsset).HasColumnType("bool");

                entity.Property(e => e.Etag)
                    .HasColumnType("varchar")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.GplineStatus)
                    .HasColumnType("int")
                    .HasColumnName("GPLineStatus");

                entity.Property(e => e.GpvalueStatus)
                    .HasColumnType("varchar")
                    .HasColumnName("GPValueStatus");

                entity.Property(e => e.HoldingStatus).HasColumnType("varchar");

                entity.Property(e => e.ICurrency)
                    .HasColumnType("varchar")
                    .HasColumnName("I_Currency");

                entity.Property(e => e.IId)
                    .HasColumnType("bigint")
                    .HasColumnName("I_Id");

                entity.Property(e => e.IInstrumentIdentityId)
                    .HasColumnType("bigint")
                    .HasColumnName("I_InstrumentIdentityId");

                entity.Property(e => e.InstrumentIdentityId).HasColumnType("bigint");

                entity.Property(e => e.LinkedCustomProperties).HasColumnType("varchar");

                entity.Property(e => e.LinkedPortfolio).HasColumnType("varchar");

                entity.Property(e => e.LinkedSilverCopies).HasColumnType("varchar");

                entity.Property(e => e.PortfolioCode).HasColumnType("varchar");

                entity.Property(e => e.PortfolioId)
                    .HasColumnType("bigint")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("Portfolio_Id");

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal");

                entity.Property(e => e.ShortLong).HasColumnType("varchar");

                entity.Property(e => e.Weight).HasColumnType("float");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.ToTable("Institution", "OData");

                entity.HasIndex(e => e.Id, "CDATA_ODATA_INSTITUTION_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint");

                entity.Property(e => e.ActiveFlag).HasColumnType("bool");

                entity.Property(e => e.Address).HasColumnType("varchar");

                entity.Property(e => e.AmficodeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("AMFICodeCode");

                entity.Property(e => e.Attention).HasColumnType("varchar");

                entity.Property(e => e.BbgcompanyParentRelationshipCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGCompanyParentRelationshipCode");

                entity.Property(e => e.BbgglobalCompanyId)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGGlobalCompanyID");

                entity.Property(e => e.BbgglobalUltimateParentCompanyId)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGGlobalUltimateParentCompanyID");

                entity.Property(e => e.BbgidglobalParentCompany)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGIDGlobalParentCompany");

                entity.Property(e => e.BbgissuerNameType)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGIssuerNameType");

                entity.Property(e => e.BbglegalFormCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGLegalFormCode");

                entity.Property(e => e.BbgparentId)
                    .HasColumnType("bigint")
                    .HasColumnName("BBGParent_Id");

                entity.Property(e => e.BbgultimateParentId)
                    .HasColumnType("bigint")
                    .HasColumnName("BBGUltimateParent_Id");

                entity.Property(e => e.BicindustryGroupCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BICIndustryGroupCode");

                entity.Property(e => e.BicindustrySectorCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BICIndustrySectorCode");

                entity.Property(e => e.BicindustrySubgroupCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BICIndustrySubgroupCode");

                entity.Property(e => e.City).HasColumnType("varchar");

                entity.Property(e => e.CompanyDescription).HasColumnType("varchar");

                entity.Property(e => e.CompanyUrl)
                    .HasColumnType("varchar")
                    .HasColumnName("CompanyURL");

                entity.Property(e => e.CountryAddressCode).HasColumnType("varchar");

                entity.Property(e => e.CountryOfDomicileCode).HasColumnType("varchar");

                entity.Property(e => e.CountryOfIncorporationCode).HasColumnType("varchar");

                entity.Property(e => e.CountryOfRiskCode).HasColumnType("varchar");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerActiveIssues).HasColumnType("bool");

                entity.Property(e => e.CustomerInstitutionNotes).HasColumnType("varchar");

                entity.Property(e => e.CustomerIssuerTypeCode).HasColumnType("varchar");

                entity.Property(e => e.CustomerRecordTypeCode).HasColumnType("varchar");

                entity.Property(e => e.Ekn)
                    .HasColumnType("varchar")
                    .HasColumnName("EKN");

                entity.Property(e => e.Etag)
                    .HasColumnType("varchar")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeSymbol).HasColumnType("varchar");

                entity.Property(e => e.FactsetIndustryCodeCode).HasColumnType("varchar");

                entity.Property(e => e.Fax).HasColumnType("varchar");

                entity.Property(e => e.FiscalYearEnd).HasColumnType("varchar");

                entity.Property(e => e.FitchIssuerLongTermRatingCode).HasColumnType("varchar");

                entity.Property(e => e.FitchIssuerLongTermRatingDate).HasColumnType("datetime");

                entity.Property(e => e.GainId)
                    .HasColumnType("varchar")
                    .HasColumnName("GainID");

                entity.Property(e => e.GicsGroupCode).HasColumnType("varchar");

                entity.Property(e => e.GicsIndustryCode).HasColumnType("varchar");

                entity.Property(e => e.GicsSectorCode).HasColumnType("varchar");

                entity.Property(e => e.GicsSubIndustryCode).HasColumnType("varchar");

                entity.Property(e => e.GkNumber).HasColumnType("varchar");

                entity.Property(e => e.IGainInstitutionId)
                    .HasColumnType("varchar")
                    .HasColumnName("I_GainInstitutionId");

                entity.Property(e => e.IId)
                    .HasColumnType("bigint")
                    .HasColumnName("I_Id");

                entity.Property(e => e.IdBbcompany)
                    .HasColumnType("varchar")
                    .HasColumnName("IdBBCompany");

                entity.Property(e => e.IdcorgId)
                    .HasColumnType("varchar")
                    .HasColumnName("IDCOrgId");

                entity.Property(e => e.ImmediateParentId)
                    .HasColumnType("bigint")
                    .HasColumnName("ImmediateParent_Id");

                entity.Property(e => e.IndustryGroupCode).HasColumnType("varchar");

                entity.Property(e => e.IndustrySectorCode).HasColumnType("varchar");

                entity.Property(e => e.IndustrySubgroupCode).HasColumnType("varchar");

                entity.Property(e => e.InstitutionRoleCode).HasColumnType("varchar");

                entity.Property(e => e.InstitutionUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.InternalInstitutionId)
                    .HasColumnType("varchar")
                    .HasColumnName("InternalInstitutionID");

                entity.Property(e => e.IsLinkedtoInstrument).HasColumnType("bool");

                entity.Property(e => e.IsUltimateParent).HasColumnType("bool");

                entity.Property(e => e.IsUpdated).HasColumnType("bool");

                entity.Property(e => e.JcrforeignCcyLongTermIssuerRatingCode)
                    .HasColumnType("varchar")
                    .HasColumnName("JCRForeignCcyLongTermIssuerRatingCode");

                entity.Property(e => e.JcrforeignCcyLongTermIssuerRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JCRForeignCcyLongTermIssuerRatingDate");

                entity.Property(e => e.JcrissuerLongTermRatingCode)
                    .HasColumnType("varchar")
                    .HasColumnName("JCRIssuerLongTermRatingCode");

                entity.Property(e => e.JcrissuerLongTermRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JCRIssuerLongTermRatingDate");

                entity.Property(e => e.JcrlocalCcyLongTermIssuerRatingCode)
                    .HasColumnType("varchar")
                    .HasColumnName("JCRLocalCcyLongTermIssuerRatingCode");

                entity.Property(e => e.JcrlocalCcyLongTermIssuerRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JCRLocalCcyLongTermIssuerRatingDate");

                entity.Property(e => e.LegalEntityCode).HasColumnType("varchar");

                entity.Property(e => e.LegalEntityTypeCode).HasColumnType("varchar");

                entity.Property(e => e.LegalFormCode).HasColumnType("varchar");

                entity.Property(e => e.LeiassignedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LEIAssignedDate");

                entity.Property(e => e.LeidisabledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LEIDisabledDate");

                entity.Property(e => e.LeientityStatusCode)
                    .HasColumnType("varchar")
                    .HasColumnName("LEIEntityStatusCode");

                entity.Property(e => e.Leiid)
                    .HasColumnType("varchar")
                    .HasColumnName("LEIID");

                entity.Property(e => e.LeilastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LEILastUpdate");

                entity.Property(e => e.LeilegalForm)
                    .HasColumnType("varchar")
                    .HasColumnName("LEILegalForm");

                entity.Property(e => e.LeiregistrationAddress)
                    .HasColumnType("varchar")
                    .HasColumnName("LEIRegistrationAddress");

                entity.Property(e => e.LinkedBusinessClassifications).HasColumnType("varchar");

                entity.Property(e => e.LinkedCustomProperties).HasColumnType("varchar");

                entity.Property(e => e.LinkedNames).HasColumnType("varchar");

                entity.Property(e => e.LinkedRatings).HasColumnType("varchar");

                entity.Property(e => e.LinkedRelatedInstitutions).HasColumnType("varchar");

                entity.Property(e => e.LinkedSilverCopies).HasColumnType("varchar");

                entity.Property(e => e.LinkedSwifts).HasColumnType("varchar");

                entity.Property(e => e.LinkedTargetSystems).HasColumnType("varchar");

                entity.Property(e => e.LocalIssuerId).HasColumnType("varchar");

                entity.Property(e => e.LongName).HasColumnType("varchar");

                entity.Property(e => e.MarcissuerLongTermRatingCode)
                    .HasColumnType("varchar")
                    .HasColumnName("MARCIssuerLongTermRatingCode");

                entity.Property(e => e.MarcissuerLongTermRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MARCIssuerLongTermRatingDate");

                entity.Property(e => e.MoodyIssuerLongTermRatingCode).HasColumnType("varchar");

                entity.Property(e => e.MoodyIssuerLongTermRatingDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("varchar");

                entity.Property(e => e.OldUltimateParentId).HasColumnType("bigint");

                entity.Property(e => e.Phone).HasColumnType("varchar");

                entity.Property(e => e.PrevTwelveDthreeFlag)
                    .HasColumnType("bool")
                    .HasColumnName("Prev_TwelveDThreeFlag");

                entity.Property(e => e.PrevTwelveDthreeLockedFlag)
                    .HasColumnType("bool")
                    .HasColumnName("Prev_TwelveDThreeLockedFlag");

                entity.Property(e => e.RambissuerLongTermRatingCode)
                    .HasColumnType("varchar")
                    .HasColumnName("RAMBIssuerLongTermRatingCode");

                entity.Property(e => e.RambissuerLongTermRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RAMBIssuerLongTermRatingDate");

                entity.Property(e => e.RedCode).HasColumnType("varchar");

                entity.Property(e => e.ReutersOrgId)
                    .HasColumnType("varchar")
                    .HasColumnName("ReutersOrgID");

                entity.Property(e => e.RidomesticCcyIssuerRatingCode)
                    .HasColumnType("varchar")
                    .HasColumnName("RIDomesticCcyIssuerRatingCode");

                entity.Property(e => e.RidomesticCcyIssuerRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RIDomesticCcyIssuerRatingDate");

                entity.Property(e => e.RifcissuerRatingCode)
                    .HasColumnType("varchar")
                    .HasColumnName("RIFCIssuerRatingCode");

                entity.Property(e => e.RifcissuerRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RIFCIssuerRatingDate");

                entity.Property(e => e.RiissuerRatingCode)
                    .HasColumnType("varchar")
                    .HasColumnName("RIIssuerRatingCode");

                entity.Property(e => e.RiissuerRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RIIssuerRatingDate");

                entity.Property(e => e.ShortName).HasColumnType("varchar");

                entity.Property(e => e.SpissuerLongTermRatingCode)
                    .HasColumnType("varchar")
                    .HasColumnName("SPIssuerLongTermRatingCode");

                entity.Property(e => e.SpissuerLongTermRatingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SPIssuerLongTermRatingDate");

                entity.Property(e => e.StateOfDomicileCode).HasColumnType("varchar");

                entity.Property(e => e.StateOfIncorporationCode).HasColumnType("varchar");

                entity.Property(e => e.StateProvinceAddress).HasColumnType("varchar");

                entity.Property(e => e.TotalSharesOutChangedate).HasColumnType("datetime");

                entity.Property(e => e.TotalSharesOutValue).HasColumnType("decimal");

                entity.Property(e => e.TotalSharesOutstanding).HasColumnType("decimal");

                entity.Property(e => e.TotalSharesOutstandingDate).HasColumnType("datetime");

                entity.Property(e => e.TwelveDthreeChangedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TwelveDThreeChangedDate");

                entity.Property(e => e.TwelveDthreeFlag)
                    .HasColumnType("bool")
                    .HasColumnName("TwelveDThreeFlag");

                entity.Property(e => e.TwelveDthreeFlagChangedBy)
                    .HasColumnType("varchar")
                    .HasColumnName("TwelveDThreeFlagChangedBy");

                entity.Property(e => e.TwelveDthreeLockedFlag)
                    .HasColumnType("bool")
                    .HasColumnName("TwelveDThreeLockedFlag");

                entity.Property(e => e.TwelveDthreeReviewedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TwelveDThreeReviewedDate");

                entity.Property(e => e.UltimateParentChangeDate).HasColumnType("datetime");

                entity.Property(e => e.UltimateParentId)
                    .HasColumnType("bigint")
                    .HasColumnName("UltimateParent_Id");

                entity.Property(e => e.UltimateParentLock).HasColumnType("bool");
            });

            modelBuilder.Entity<Instrument>(entity =>
            {
                entity.ToTable("Instrument", "OData");

                entity.HasIndex(e => e.Id, "CDATA_ODATA_INSTRUMENT_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint");

                entity.Property(e => e.AbsMbsassetTypeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("ABS_MBSAssetTypeCode");

                entity.Property(e => e.AccruedDaysBetweenCpndates)
                    .HasColumnType("int")
                    .HasColumnName("AccruedDaysBetweenCPNDates");

                entity.Property(e => e.AccruedInterest).HasColumnType("int");

                entity.Property(e => e.Active).HasColumnType("bool");

                entity.Property(e => e.AgeCalculated).HasColumnType("int");

                entity.Property(e => e.AlternativeBbticker)
                    .HasColumnType("varchar")
                    .HasColumnName("AlternativeBBTicker");

                entity.Property(e => e.AlternativeCommonCode).HasColumnType("varchar");

                entity.Property(e => e.AlternativeCusip)
                    .HasColumnType("varchar")
                    .HasColumnName("AlternativeCUSIP");

                entity.Property(e => e.AlternativeId1)
                    .HasColumnType("varchar")
                    .HasColumnName("AlternativeID1");

                entity.Property(e => e.AlternativeIsin)
                    .HasColumnType("varchar")
                    .HasColumnName("AlternativeISIN");

                entity.Property(e => e.AlternativeSedol)
                    .HasColumnType("varchar")
                    .HasColumnName("AlternativeSEDOL");

                entity.Property(e => e.AmficodeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("AMFICodeCode");

                entity.Property(e => e.AmountIssuedAccumulating).HasColumnType("decimal");

                entity.Property(e => e.AmountIssuedOriginal).HasColumnType("decimal");

                entity.Property(e => e.AmountOutstanding).HasColumnType("decimal");

                entity.Property(e => e.AmountOutstandingDate).HasColumnType("datetime");

                entity.Property(e => e.AsOfCoupon).HasColumnType("decimal");

                entity.Property(e => e.AssetClass).HasColumnType("varchar");

                entity.Property(e => e.AssetTypeNew).HasColumnType("varchar");

                entity.Property(e => e.AssimilatedAssetId)
                    .HasColumnType("bigint")
                    .HasColumnName("AssimilatedAsset_Id");

                entity.Property(e => e.AttachmentPoint).HasColumnType("decimal");

                entity.Property(e => e.BankruptPercentage).HasColumnType("decimal");

                entity.Property(e => e.BaseCpidate)
                    .HasColumnType("datetime")
                    .HasColumnName("BaseCPIDate");

                entity.Property(e => e.BaseCpivalue)
                    .HasColumnType("decimal")
                    .HasColumnName("BaseCPIValue");

                entity.Property(e => e.BaseCurrencyCode).HasColumnType("varchar");

                entity.Property(e => e.BasicSpread).HasColumnType("decimal");

                entity.Property(e => e.BbgCompositeGlobalId).HasColumnType("varchar");

                entity.Property(e => e.BbgDayCountCode).HasColumnType("varchar");

                entity.Property(e => e.BbgGlobalId).HasColumnType("varchar");

                entity.Property(e => e.BbgSecurityTypeCode).HasColumnType("varchar");

                entity.Property(e => e.BbgTicker).HasColumnType("varchar");

                entity.Property(e => e.BbgUniqueId).HasColumnType("varchar");

                entity.Property(e => e.BbgaccruedBasis)
                    .HasColumnType("int")
                    .HasColumnName("BBGAccruedBasis");

                entity.Property(e => e.BbgdataLicenseAssetClassCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGDataLicenseAssetClassCode");

                entity.Property(e => e.BbgglobalCompanyId)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGGlobalCompanyID");

                entity.Property(e => e.BbglongTermFundObjectiveCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGLongTermFundObjectiveCode");

                entity.Property(e => e.BbgpricingMethodCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGPricingMethodCode");

                entity.Property(e => e.BbgprimarySecurityYellowKeyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGPrimarySecurityYellowKeyCode");

                entity.Property(e => e.BbgsecurityDescription)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGSecurityDescription");

                entity.Property(e => e.BbgspecificCouponTypeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("BBGSpecificCouponTypeCode");

                entity.Property(e => e.BemaustraliaId)
                    .HasColumnType("varchar")
                    .HasColumnName("BEMAustraliaID");

                entity.Property(e => e.BenchmarkReferenceId)
                    .HasColumnType("bigint")
                    .HasColumnName("BenchmarkReference_Id");

                entity.Property(e => e.BissettId)
                    .HasColumnType("varchar")
                    .HasColumnName("BissettID");

                entity.Property(e => e.BlackListed).HasColumnType("bool");

                entity.Property(e => e.BloombergCode).HasColumnType("varchar");

                entity.Property(e => e.BloombergCodeInfo).HasColumnType("varchar");

                entity.Property(e => e.BloombergData).HasColumnType("bool");

                entity.Property(e => e.BloombergFactor).HasColumnType("decimal");

                entity.Property(e => e.BloombergGlobalId).HasColumnType("varchar");

                entity.Property(e => e.BloombergYellowKeyOverride).HasColumnType("varchar");

                entity.Property(e => e.BnyMellonId).HasColumnType("varchar");

                entity.Property(e => e.BondSeries).HasColumnType("varchar");

                entity.Property(e => e.BovespaTicker).HasColumnType("varchar");

                entity.Property(e => e.CalendarDayOfCouponPaymentCode).HasColumnType("varchar");

                entity.Property(e => e.CallDate).HasColumnType("datetime");

                entity.Property(e => e.CallFeatureCode).HasColumnType("varchar");

                entity.Property(e => e.CallFrequencyCode).HasColumnType("varchar");

                entity.Property(e => e.CallPrice).HasColumnType("decimal");

                entity.Property(e => e.CallablePutableCode).HasColumnType("varchar");

                entity.Property(e => e.CapitalProtectionCode).HasColumnType("varchar");

                entity.Property(e => e.CapitalTriggerTypeCode).HasColumnType("varchar");

                entity.Property(e => e.CashDividendConfirmationDate).HasColumnType("datetime");

                entity.Property(e => e.Catastrophe).HasColumnType("bool");

                entity.Property(e => e.CategoryCode).HasColumnType("varchar");

                entity.Property(e => e.CertificateUnderlyingTypeCode).HasColumnType("varchar");

                entity.Property(e => e.CertificationType).HasColumnType("varchar");

                entity.Property(e => e.Cficode)
                    .HasColumnType("varchar")
                    .HasColumnName("CFICode");

                entity.Property(e => e.CharlesRiverId).HasColumnType("varchar");

                entity.Property(e => e.CiccategoryCode)
                    .HasColumnType("varchar")
                    .HasColumnName("CICCategoryCode");

                entity.Property(e => e.Ciccode)
                    .HasColumnType("varchar")
                    .HasColumnName("CICCode");

                entity.Property(e => e.Cinsid)
                    .HasColumnType("varchar")
                    .HasColumnName("CINSID");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.Cmbstype)
                    .HasColumnType("varchar")
                    .HasColumnName("CMBSType");

                entity.Property(e => e.Cmoclass)
                    .HasColumnType("varchar")
                    .HasColumnName("CMOClass");

                entity.Property(e => e.Cmoseries)
                    .HasColumnType("varchar")
                    .HasColumnName("CMOSeries");

                entity.Property(e => e.CollateralCountryCode).HasColumnType("varchar");

                entity.Property(e => e.CollateralDescriptionCode).HasColumnType("varchar");

                entity.Property(e => e.CollateralPortfolioCode).HasColumnType("varchar");

                entity.Property(e => e.CollateralTypeCode).HasColumnType("varchar");

                entity.Property(e => e.CollateralValue).HasColumnType("decimal");

                entity.Property(e => e.CommonCode).HasColumnType("varchar");

                entity.Property(e => e.CompletenessLevelCode).HasColumnType("varchar");

                entity.Property(e => e.ContractSize).HasColumnType("decimal");

                entity.Property(e => e.ConversionFixedExchangeRate).HasColumnType("decimal");

                entity.Property(e => e.ConversionPrice).HasColumnType("decimal");

                entity.Property(e => e.ConversionRatio).HasColumnType("decimal");

                entity.Property(e => e.ConversionStartDate).HasColumnType("datetime");

                entity.Property(e => e.ConversionTypeCode).HasColumnType("varchar");

                entity.Property(e => e.ConversionUntilDate).HasColumnType("datetime");

                entity.Property(e => e.ConvertibleExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.CountryOfDomicileCode).HasColumnType("varchar");

                entity.Property(e => e.CountryOfGuarantorCode).HasColumnType("varchar");

                entity.Property(e => e.CountryOfIssueCode).HasColumnType("varchar");

                entity.Property(e => e.CountryOfListingCode).HasColumnType("varchar");

                entity.Property(e => e.CountryOfRiskCode).HasColumnType("varchar");

                entity.Property(e => e.CouponAsOfDate).HasColumnType("datetime");

                entity.Property(e => e.CouponCurrencyCode).HasColumnType("varchar");

                entity.Property(e => e.CouponFrequencyCode).HasColumnType("varchar");

                entity.Property(e => e.CouponRate).HasColumnType("decimal");

                entity.Property(e => e.CouponTypeCode).HasColumnType("varchar");

                entity.Property(e => e.CouponTypeResetDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreditEnhancementTypeCode).HasColumnType("varchar");

                entity.Property(e => e.CurrentCouponPaymentExDividendDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentNet)
                    .HasColumnType("decimal")
                    .HasColumnName("CurrentNET");

                entity.Property(e => e.CurrentWac)
                    .HasColumnType("decimal")
                    .HasColumnName("CurrentWAC");

                entity.Property(e => e.CurrentWam)
                    .HasColumnType("decimal")
                    .HasColumnName("CurrentWAM");

                entity.Property(e => e.Cusip)
                    .HasColumnType("varchar")
                    .HasColumnName("CUSIP");

                entity.Property(e => e.DayCountCode).HasColumnType("varchar");

                entity.Property(e => e.DefaultCurrency).HasColumnType("varchar");

                entity.Property(e => e.DefaultDate).HasColumnType("datetime");

                entity.Property(e => e.Delta).HasColumnType("decimal");

                entity.Property(e => e.DetachmentPoint).HasColumnType("decimal");

                entity.Property(e => e.DividendFrequencyCode).HasColumnType("varchar");

                entity.Property(e => e.DividendIndicated1YearGross).HasColumnType("decimal");

                entity.Property(e => e.DvdshareTemp)
                    .HasColumnType("varchar")
                    .HasColumnName("DVDShareTemp");

                entity.Property(e => e.EarlyRedemptionInfo).HasColumnType("varchar");

                entity.Property(e => e.EquityFundamentalCurrencyCode).HasColumnType("varchar");

                entity.Property(e => e.Eqydvdtemp)
                    .HasColumnType("varchar")
                    .HasColumnName("EQYDVDTemp");

                entity.Property(e => e.Etag)
                    .HasColumnType("varchar")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExDividendDays).HasColumnType("int");

                entity.Property(e => e.ExchangeCode).HasColumnType("varchar");

                entity.Property(e => e.ExerciseEndDate).HasColumnType("datetime");

                entity.Property(e => e.ExerciseTypeCode).HasColumnType("varchar");

                entity.Property(e => e.ExpectedMaturityDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate144A).HasColumnType("datetime");

                entity.Property(e => e.Factor).HasColumnType("decimal");

                entity.Property(e => e.FactorEffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FactsetIndustryCode).HasColumnType("varchar");

                entity.Property(e => e.FederallyTaxable).HasColumnType("bool");

                entity.Property(e => e.FeedLastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.FeedStartRestrictedStatus).HasColumnType("datetime");

                entity.Property(e => e.FirstCouponPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.FirstExDividendDate).HasColumnType("datetime");

                entity.Property(e => e.FirstInterestAccrualDate).HasColumnType("datetime");

                entity.Property(e => e.FirstPrincipalPayDate).HasColumnType("datetime");

                entity.Property(e => e.FirstSettleDate).HasColumnType("datetime");

                entity.Property(e => e.FirstTradeDate).HasColumnType("datetime");

                entity.Property(e => e.Fisn)
                    .HasColumnType("varchar")
                    .HasColumnName("FISN");

                entity.Property(e => e.FixedCpnvalue)
                    .HasColumnType("decimal")
                    .HasColumnName("FixedCPNValue");

                entity.Property(e => e.FixedToFloatCouponFrequencyCode).HasColumnType("varchar");

                entity.Property(e => e.FixedToFloatDayCountCode).HasColumnType("varchar");

                entity.Property(e => e.FloaterBenchmarkMultiplier).HasColumnType("decimal");

                entity.Property(e => e.FloaterFormula).HasColumnType("varchar");

                entity.Property(e => e.FloaterIndex).HasColumnType("varchar");

                entity.Property(e => e.FloaterSpread).HasColumnType("decimal");

                entity.Property(e => e.FundAssetClassFocusCode).HasColumnType("varchar");

                entity.Property(e => e.FundCompanyName).HasColumnType("varchar");

                entity.Property(e => e.FundGeographicalFocusCode).HasColumnType("varchar");

                entity.Property(e => e.FundIndustryFocusCode).HasColumnType("varchar");

                entity.Property(e => e.FundInitialCurrencyCode).HasColumnType("varchar");

                entity.Property(e => e.FundInvestedInCashAndOthers).HasColumnType("decimal");

                entity.Property(e => e.FundInvestedInCorpSecurities).HasColumnType("decimal");

                entity.Property(e => e.FundInvestedInEquitySecurities).HasColumnType("decimal");

                entity.Property(e => e.FundInvestedInMtgeSecurities).HasColumnType("decimal");

                entity.Property(e => e.FundInvestedInMuniSecurities).HasColumnType("decimal");

                entity.Property(e => e.FundManagementCompany).HasColumnType("varchar");

                entity.Property(e => e.FundManagementStyleCode).HasColumnType("varchar");

                entity.Property(e => e.FundMarketCapFocusCode).HasColumnType("varchar");

                entity.Property(e => e.FundMaturityFocusCode).HasColumnType("varchar");

                entity.Property(e => e.FundNavcurrencyCode)
                    .HasColumnType("varchar")
                    .HasColumnName("FundNAVCurrencyCode");

                entity.Property(e => e.FundNavvalue)
                    .HasColumnType("decimal")
                    .HasColumnName("FundNAVValue");

                entity.Property(e => e.FundPricingFrequencyCode).HasColumnType("varchar");

                entity.Property(e => e.FundPricingSource).HasColumnType("varchar");

                entity.Property(e => e.FundRatingClassFocusCode).HasColumnType("varchar");

                entity.Property(e => e.FundRedepmtionDate).HasColumnType("datetime");

                entity.Property(e => e.FundStrategyCode).HasColumnType("varchar");

                entity.Property(e => e.FundTaxStatus).HasColumnType("varchar");

                entity.Property(e => e.FundTotalAssets).HasColumnType("decimal");

                entity.Property(e => e.FundTotalAssetsCurrencyCode).HasColumnType("varchar");

                entity.Property(e => e.FundTypeCode).HasColumnType("varchar");

                entity.Property(e => e.FundinvestedinGovernmentSecurities).HasColumnType("decimal");

                entity.Property(e => e.FundinvestedinPrefSecurities).HasColumnType("decimal");

                entity.Property(e => e.FuturesAndOptionsCategoryCode).HasColumnType("varchar");

                entity.Property(e => e.FuturesFirstDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.FuturesFirstNoticeDate).HasColumnType("datetime");

                entity.Property(e => e.FuturesInitialMarginSpeculator).HasColumnType("decimal");

                entity.Property(e => e.FuturesLastDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.FuturesRollDate).HasColumnType("datetime");

                entity.Property(e => e.GainId)
                    .HasColumnType("varchar")
                    .HasColumnName("GainID");

                entity.Property(e => e.GainIssuerId).HasColumnType("int");

                entity.Property(e => e.GeographicalZoneCode).HasColumnType("varchar");

                entity.Property(e => e.GicssubIndustryCode)
                    .HasColumnType("varchar")
                    .HasColumnName("GICSSubIndustryCode");

                entity.Property(e => e.GlobalAssetClassCode).HasColumnType("varchar");

                entity.Property(e => e.GlobalAssetTypeCode).HasColumnType("varchar");

                entity.Property(e => e.Gplusflag)
                    .HasColumnType("bool")
                    .HasColumnName("GPLUSFlag");

                entity.Property(e => e.Gplusid)
                    .HasColumnType("varchar")
                    .HasColumnName("GPLUSID");

                entity.Property(e => e.GrossDividend1YearGrowthRate).HasColumnType("decimal");

                entity.Property(e => e.GrossDividend3YearGrowthRate).HasColumnType("decimal");

                entity.Property(e => e.Guarantor).HasColumnType("varchar");

                entity.Property(e => e.Has144AregSrights)
                    .HasColumnType("bool")
                    .HasColumnName("Has144ARegSRights");

                entity.Property(e => e.HasAlternativeMinimumTax).HasColumnType("bool");

                entity.Property(e => e.HasContingentDebt).HasColumnType("bool");

                entity.Property(e => e.HasEndAccDateAtMonthEnd).HasColumnType("bool");

                entity.Property(e => e.HasInterestCapitalization).HasColumnType("bool");

                entity.Property(e => e.HasInterestPayDateAtMonthEnd).HasColumnType("bool");

                entity.Property(e => e.HasLocspacode)
                    .HasColumnType("varchar")
                    .HasColumnName("HasLOCSPACode");

                entity.Property(e => e.HasLong1stCoupon).HasColumnType("bool");

                entity.Property(e => e.HasMakeWholeCallPossible).HasColumnType("bool");

                entity.Property(e => e.HasMortgageIsPaidOff).HasColumnType("bool");

                entity.Property(e => e.HasProspective).HasColumnType("bool");

                entity.Property(e => e.HasSharesIncluded).HasColumnType("bool");

                entity.Property(e => e.HasShort1stCoupon).HasColumnType("bool");

                entity.Property(e => e.HasSolvencyIi)
                    .HasColumnType("bool")
                    .HasColumnName("HasSolvencyII");

                entity.Property(e => e.IGainInstrumentId)
                    .HasColumnType("varchar")
                    .HasColumnName("I_GainInstrumentId");

                entity.Property(e => e.IId)
                    .HasColumnType("bigint")
                    .HasColumnName("I_Id");

                entity.Property(e => e.IndexId)
                    .HasColumnType("bigint")
                    .HasColumnName("Index_Id");

                entity.Property(e => e.IndexLag).HasColumnType("int");

                entity.Property(e => e.IndexLagUnitCode).HasColumnType("varchar");

                entity.Property(e => e.IndexName).HasColumnType("varchar");

                entity.Property(e => e.IndexTypeCode).HasColumnType("varchar");

                entity.Property(e => e.InflationIndexPriceFreq).HasColumnType("varchar");

                entity.Property(e => e.InitialPubOfferSharePrice).HasColumnType("decimal");

                entity.Property(e => e.InitialPublicOfferDate).HasColumnType("datetime");

                entity.Property(e => e.InstrumentGroupCode).HasColumnType("varchar");

                entity.Property(e => e.InstrumentTypeCode).HasColumnType("varchar");

                entity.Property(e => e.InsurerPercentage).HasColumnType("decimal");

                entity.Property(e => e.InterestBusinessDayConventionCode).HasColumnType("varchar");

                entity.Property(e => e.InterestCalculationTypeCode).HasColumnType("varchar");

                entity.Property(e => e.InterestPaymentMethodCode).HasColumnType("varchar");

                entity.Property(e => e.InterestShortFall).HasColumnType("decimal");

                entity.Property(e => e.Ipoprice)
                    .HasColumnType("decimal")
                    .HasColumnName("IPOPrice");

                entity.Property(e => e.Is144A).HasColumnType("bool");

                entity.Property(e => e.IsAccumulatingFund).HasColumnType("bool");

                entity.Property(e => e.IsAgencyBacked).HasColumnType("bool");

                entity.Property(e => e.IsAuctionRate).HasColumnType("bool");

                entity.Property(e => e.IsBearerSecurity).HasColumnType("bool");

                entity.Property(e => e.IsCallable).HasColumnType("bool");

                entity.Property(e => e.IsCalled).HasColumnType("bool");

                entity.Property(e => e.IsClosedEndFund).HasColumnType("bool");

                entity.Property(e => e.IsContingentConvertible).HasColumnType("bool");

                entity.Property(e => e.IsConvertible).HasColumnType("bool");

                entity.Property(e => e.IsCouponInDefault).HasColumnType("bool");

                entity.Property(e => e.IsCovered).HasColumnType("bool");

                entity.Property(e => e.IsCreditLinked).HasColumnType("bool");

                entity.Property(e => e.IsDefaulted).HasColumnType("bool");

                entity.Property(e => e.IsDeflationProtected).HasColumnType("bool");

                entity.Property(e => e.IsDualCurrency).HasColumnType("bool");

                entity.Property(e => e.IsErisa)
                    .HasColumnType("bool")
                    .HasColumnName("IsERISA");

                entity.Property(e => e.IsExchangeable).HasColumnType("bool");

                entity.Property(e => e.IsFixtoFloat).HasColumnType("bool");

                entity.Property(e => e.IsFloater).HasColumnType("bool");

                entity.Property(e => e.IsFloattoFix).HasColumnType("bool");

                entity.Property(e => e.IsFundOfFunds).HasColumnType("bool");

                entity.Property(e => e.IsHybridBond).HasColumnType("bool");

                entity.Property(e => e.IsHybridCumulative).HasColumnType("bool");

                entity.Property(e => e.IsHybridDeferredPaymentAllowed).HasColumnType("bool");

                entity.Property(e => e.IsIndexInterpolated).HasColumnType("bool");

                entity.Property(e => e.IsInflationLinked).HasColumnType("bool");

                entity.Property(e => e.IsIrregularCashFlow).HasColumnType("bool");

                entity.Property(e => e.IsIslamic).HasColumnType("bool");

                entity.Property(e => e.IsMandatoryConversion).HasColumnType("varchar");

                entity.Property(e => e.IsPartiallyCalled).HasColumnType("bool");

                entity.Property(e => e.IsPerpetual).HasColumnType("bool");

                entity.Property(e => e.IsPrepaymentStructuredProduct).HasColumnType("bool");

                entity.Property(e => e.IsPrivatePlacement).HasColumnType("bool");

                entity.Property(e => e.IsPutable).HasColumnType("bool");

                entity.Property(e => e.IsRedeeming).HasColumnType("bool");

                entity.Property(e => e.IsRegS).HasColumnType("bool");

                entity.Property(e => e.IsRegisteredSecurity).HasColumnType("bool");

                entity.Property(e => e.IsRemarketed).HasColumnType("bool");

                entity.Property(e => e.IsReverseConvertible).HasColumnType("bool");

                entity.Property(e => e.IsSecured).HasColumnType("bool");

                entity.Property(e => e.IsSenior).HasColumnType("bool");

                entity.Property(e => e.IsSinkable).HasColumnType("bool");

                entity.Property(e => e.IsStandard).HasColumnType("bool");

                entity.Property(e => e.IsStructuredNote).HasColumnType("bool");

                entity.Property(e => e.IsSubordinated).HasColumnType("bool");

                entity.Property(e => e.IsSyntheticConvertible).HasColumnType("bool");

                entity.Property(e => e.IsSyntheticLoan).HasColumnType("bool");

                entity.Property(e => e.IsTaxableBond).HasColumnType("bool");

                entity.Property(e => e.IsUnitTraded).HasColumnType("bool");

                entity.Property(e => e.IsUnsecured).HasColumnType("bool");

                entity.Property(e => e.IsUpdated).HasColumnType("bool");

                entity.Property(e => e.IsUssection13F)
                    .HasColumnType("bool")
                    .HasColumnName("IsUSSection13F");

                entity.Property(e => e.IsVariable).HasColumnType("bool");

                entity.Property(e => e.IscurrentGovernmentBond).HasColumnType("bool");

                entity.Property(e => e.Isin)
                    .HasColumnType("varchar")
                    .HasColumnName("ISIN");

                entity.Property(e => e.IslamicBondTypeCode).HasColumnType("varchar");

                entity.Property(e => e.IssueCurrencyCode).HasColumnType("varchar");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDescription13F).HasColumnType("varchar");

                entity.Property(e => e.IssuePrice).HasColumnType("decimal");

                entity.Property(e => e.IssuerDescription13F).HasColumnType("varchar");

                entity.Property(e => e.IssuerId)
                    .HasColumnType("bigint")
                    .HasColumnName("Issuer_Id");

                entity.Property(e => e.LastCallableDate).HasColumnType("datetime");

                entity.Property(e => e.LastClosePriceDate).HasColumnType("datetime");

                entity.Property(e => e.LastCouponDate).HasColumnType("datetime");

                entity.Property(e => e.LastPrice).HasColumnType("decimal");

                entity.Property(e => e.LastRefixDate).HasColumnType("datetime");

                entity.Property(e => e.LastTradeDate).HasColumnType("datetime");

                entity.Property(e => e.LatestSinkingFundFactor).HasColumnType("decimal");

                entity.Property(e => e.LegalFinalMaturity).HasColumnType("datetime");

                entity.Property(e => e.LinkedBondOptionalities).HasColumnType("varchar");

                entity.Property(e => e.LinkedBusinessClassifications).HasColumnType("varchar");

                entity.Property(e => e.LinkedCouponSchedules).HasColumnType("varchar");

                entity.Property(e => e.LinkedCustomComponents1).HasColumnType("varchar");

                entity.Property(e => e.LinkedCustomComponents2).HasColumnType("varchar");

                entity.Property(e => e.LinkedCustomComponents3).HasColumnType("varchar");

                entity.Property(e => e.LinkedCustomComponents4).HasColumnType("varchar");

                entity.Property(e => e.LinkedCustomComponents5).HasColumnType("varchar");

                entity.Property(e => e.LinkedCustomProperties).HasColumnType("varchar");

                entity.Property(e => e.LinkedDividendProjectionSchedules).HasColumnType("varchar");

                entity.Property(e => e.LinkedDividendSchedules).HasColumnType("varchar");

                entity.Property(e => e.LinkedFactorProjectionsSchedule).HasColumnType("varchar");

                entity.Property(e => e.LinkedFactorSchedules).HasColumnType("varchar");

                entity.Property(e => e.LinkedFeesCharges).HasColumnType("varchar");

                entity.Property(e => e.LinkedInflationsLinked).HasColumnType("varchar");

                entity.Property(e => e.LinkedLegs).HasColumnType("varchar");

                entity.Property(e => e.LinkedListings).HasColumnType("varchar");

                entity.Property(e => e.LinkedMifid)
                    .HasColumnType("varchar")
                    .HasColumnName("LinkedMIFID");

                entity.Property(e => e.LinkedNames).HasColumnType("varchar");

                entity.Property(e => e.LinkedPrepaymentSpeeds).HasColumnType("varchar");

                entity.Property(e => e.LinkedRatings).HasColumnType("varchar");

                entity.Property(e => e.LinkedRelatedInstitutions).HasColumnType("varchar");

                entity.Property(e => e.LinkedRelatedInstruments).HasColumnType("varchar");

                entity.Property(e => e.LinkedSilverCopies).HasColumnType("varchar");

                entity.Property(e => e.LinkedSinkingSchedules).HasColumnType("varchar");

                entity.Property(e => e.LoanFacilityName).HasColumnType("varchar");

                entity.Property(e => e.LocalExchangeSymbol).HasColumnType("varchar");

                entity.Property(e => e.LocexpirationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LOCExpirationDate");

                entity.Property(e => e.Locspapercentage)
                    .HasColumnType("decimal")
                    .HasColumnName("LOCSPAPercentage");

                entity.Property(e => e.LongName).HasColumnType("varchar");

                entity.Property(e => e.MarketCapitalization).HasColumnType("decimal");

                entity.Property(e => e.MarketStatusCode).HasColumnType("varchar");

                entity.Property(e => e.MarketTicker).HasColumnType("varchar");

                entity.Property(e => e.MarkitLxid)
                    .HasColumnType("varchar")
                    .HasColumnName("MarkitLXID");

                entity.Property(e => e.MaturityDate).HasColumnType("datetime");

                entity.Property(e => e.MaturityTypeCode).HasColumnType("varchar");

                entity.Property(e => e.MbsprodCodeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("MBSProdCodeCode");

                entity.Property(e => e.MifidId)
                    .HasColumnType("bigint")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("MIFID_Id");

                entity.Property(e => e.MinimumIncrement).HasColumnType("decimal");

                entity.Property(e => e.MinimumPurchaseAmount).HasColumnType("decimal");

                entity.Property(e => e.MinumumTradableAmount).HasColumnType("decimal");

                entity.Property(e => e.ModifiedDurationInternal).HasColumnType("datetime");

                entity.Property(e => e.MortgageCollateralTypeCode).HasColumnType("varchar");

                entity.Property(e => e.MortgageDealTypeCode).HasColumnType("varchar");

                entity.Property(e => e.MortgageLoanAge).HasColumnType("decimal");

                entity.Property(e => e.MortgageTrancheTypeCode).HasColumnType("varchar");

                entity.Property(e => e.MostRecentAccrRtStartDate).HasColumnType("datetime");

                entity.Property(e => e.MostRecentDefaultDate).HasColumnType("datetime");

                entity.Property(e => e.MtgeFirstProjectedCashflowDate).HasColumnType("datetime");

                entity.Property(e => e.MtgeNextPayDatePerSettle).HasColumnType("datetime");

                entity.Property(e => e.MultipleShares).HasColumnType("bool");

                entity.Property(e => e.MuniSscClassCodeCode).HasColumnType("varchar");

                entity.Property(e => e.MunicipalIndustryTypeCode).HasColumnType("varchar");

                entity.Property(e => e.MunicipalIssueName).HasColumnType("varchar");

                entity.Property(e => e.MunicipalIssueTypeCode).HasColumnType("varchar");

                entity.Property(e => e.MunicipalScccode)
                    .HasColumnType("varchar")
                    .HasColumnName("MunicipalSCCCode");

                entity.Property(e => e.MunicipalTaxStatusCode).HasColumnType("varchar");

                entity.Property(e => e.NaceclassCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NACEClassCode");

                entity.Property(e => e.Nacecode)
                    .HasColumnType("varchar")
                    .HasColumnName("NACECode");

                entity.Property(e => e.NacedivisionCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NACEDivisionCode");

                entity.Property(e => e.NacegroupCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NACEGroupCode");

                entity.Property(e => e.NacesectorCode)
                    .HasColumnType("varchar")
                    .HasColumnName("NACESectorCode");

                entity.Property(e => e.NameOfProject).HasColumnType("varchar");

                entity.Property(e => e.NegativeInterest).HasColumnType("bool");

                entity.Property(e => e.NetDividend1YearGrowthRate).HasColumnType("decimal");

                entity.Property(e => e.NetDividend3YearGrowthRate).HasColumnType("decimal");

                entity.Property(e => e.NextCouponPayDate).HasColumnType("datetime");

                entity.Property(e => e.NextFactorDate).HasColumnType("datetime");

                entity.Property(e => e.NextRefixDate).HasColumnType("datetime");

                entity.Property(e => e.NextSinkAmount).HasColumnType("decimal");

                entity.Property(e => e.NextSinkingDate).HasColumnType("datetime");

                entity.Property(e => e.NextSinkingPrice).HasColumnType("decimal");

                entity.Property(e => e.NominalPaymentDay).HasColumnType("int");

                entity.Property(e => e.NumOfDeferredPaymentsAllowed).HasColumnType("int");

                entity.Property(e => e.NumberOfPositions).HasColumnType("int");

                entity.Property(e => e.Occ21symbol)
                    .HasColumnType("varchar")
                    .HasColumnName("OCC21Symbol");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.OptionExoticTypeCode).HasColumnType("varchar");

                entity.Property(e => e.OptionTypeCode).HasColumnType("varchar");

                entity.Property(e => e.OriginalNet)
                    .HasColumnType("decimal")
                    .HasColumnName("OriginalNET");

                entity.Property(e => e.OriginalWac)
                    .HasColumnType("decimal")
                    .HasColumnName("OriginalWAC");

                entity.Property(e => e.OriginalWam)
                    .HasColumnType("decimal")
                    .HasColumnName("OriginalWAM");

                entity.Property(e => e.ParValue).HasColumnType("decimal");

                entity.Property(e => e.ParValueCurrencyCode).HasColumnType("varchar");

                entity.Property(e => e.PayDelay).HasColumnType("int");

                entity.Property(e => e.PaymentRankCode).HasColumnType("varchar");

                entity.Property(e => e.PenultimateCpndate)
                    .HasColumnType("datetime")
                    .HasColumnName("PenultimateCPNDate");

                entity.Property(e => e.PercentOfIssue).HasColumnType("decimal");

                entity.Property(e => e.PerformanceSectorCode).HasColumnType("varchar");

                entity.Property(e => e.PoolNumber).HasColumnType("varchar");

                entity.Property(e => e.PoolTypeCode).HasColumnType("varchar");

                entity.Property(e => e.PositionsAmount).HasColumnType("decimal");

                entity.Property(e => e.PreRefundedEtmcallStatusCode)
                    .HasColumnType("varchar")
                    .HasColumnName("PreRefundedETMCallStatusCode");

                entity.Property(e => e.PreRefundedEtmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PreRefundedETMDate");

                entity.Property(e => e.PreRefundedEtmprice)
                    .HasColumnType("decimal")
                    .HasColumnName("PreRefundedETMPrice");

                entity.Property(e => e.PrepaymentSpeed).HasColumnType("decimal");

                entity.Property(e => e.PrepaymentSpeedSource).HasColumnType("varchar");

                entity.Property(e => e.PreviousCouponDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousPrincipalPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PriceProviderCode).HasColumnType("varchar");

                entity.Property(e => e.PriceUnitCode).HasColumnType("varchar");

                entity.Property(e => e.PricingFrequencyCode).HasColumnType("varchar");

                entity.Property(e => e.PricingInstrumentCode).HasColumnType("varchar");

                entity.Property(e => e.PrimarySecurityCurrencyCode).HasColumnType("varchar");

                entity.Property(e => e.PrincipalLosses).HasColumnType("decimal");

                entity.Property(e => e.PrincipalPayDelay).HasColumnType("int");

                entity.Property(e => e.ProductTypeCode).HasColumnType("varchar");

                entity.Property(e => e.ProjectId).HasColumnType("varchar");

                entity.Property(e => e.ProjectNameCode).HasColumnType("varchar");

                entity.Property(e => e.PutFeatureCode).HasColumnType("varchar");

                entity.Property(e => e.PutFrequencyCode).HasColumnType("varchar");

                entity.Property(e => e.QuotationMode).HasColumnType("varchar");

                entity.Property(e => e.QuotationTypeCode).HasColumnType("varchar");

                entity.Property(e => e.RedCode).HasColumnType("varchar");

                entity.Property(e => e.RedemptionCurrencyCode).HasColumnType("varchar");

                entity.Property(e => e.RedemptionFrequency).HasColumnType("int");

                entity.Property(e => e.RedemptionValue).HasColumnType("decimal");

                entity.Property(e => e.ReferenceCpiindex)
                    .HasColumnType("varchar")
                    .HasColumnName("ReferenceCPIIndex");

                entity.Property(e => e.ReferenceIndexId)
                    .HasColumnType("bigint")
                    .HasColumnName("ReferenceIndex_Id");

                entity.Property(e => e.ReferencePeriodCode).HasColumnType("varchar");

                entity.Property(e => e.RegionCode).HasColumnType("varchar");

                entity.Property(e => e.RelativeIndex).HasColumnType("varchar");

                entity.Property(e => e.RemarketDate).HasColumnType("datetime");

                entity.Property(e => e.ResetFrequencyCode).HasColumnType("varchar");

                entity.Property(e => e.ReutersAssetId).HasColumnType("varchar");

                entity.Property(e => e.ReutersFactor).HasColumnType("decimal");

                entity.Property(e => e.ReutersLinnumber)
                    .HasColumnType("varchar")
                    .HasColumnName("ReutersLINNumber");

                entity.Property(e => e.ReutersQuoteId).HasColumnType("varchar");

                entity.Property(e => e.ReutersRic)
                    .HasColumnType("varchar")
                    .HasColumnName("ReutersRIC");

                entity.Property(e => e.RoundLot).HasColumnType("decimal");

                entity.Property(e => e.SecrestrictionsCode)
                    .HasColumnType("varchar")
                    .HasColumnName("SECRestrictionsCode");

                entity.Property(e => e.Security12D3flag)
                    .HasColumnType("bool")
                    .HasColumnName("Security12D3Flag");

                entity.Property(e => e.SecurityActivationPrice).HasColumnType("decimal");

                entity.Property(e => e.SecurityActivationPriceDate).HasColumnType("datetime");

                entity.Property(e => e.SecurityCountryOfIncorporationCode).HasColumnType("varchar");

                entity.Property(e => e.SecurityDescription).HasColumnType("varchar");

                entity.Property(e => e.SecurityLegalName1).HasColumnType("varchar");

                entity.Property(e => e.SecurityLegalName2).HasColumnType("varchar");

                entity.Property(e => e.SecurityLegalName3).HasColumnType("varchar");

                entity.Property(e => e.SecurityLegalName4).HasColumnType("varchar");

                entity.Property(e => e.SecurityLegalName5).HasColumnType("varchar");

                entity.Property(e => e.SecurityLegalName6).HasColumnType("varchar");

                entity.Property(e => e.Sedol)
                    .HasColumnType("varchar")
                    .HasColumnName("SEDOL");

                entity.Property(e => e.Sedol2)
                    .HasColumnType("varchar")
                    .HasColumnName("SEDOL2");

                entity.Property(e => e.Series).HasColumnType("varchar");

                entity.Property(e => e.SettlementCalendarCode).HasColumnType("varchar");

                entity.Property(e => e.SettlementCurrencyCode).HasColumnType("varchar");

                entity.Property(e => e.SettlementTypeCode).HasColumnType("varchar");

                entity.Property(e => e.SharesOutstanding).HasColumnType("decimal");

                entity.Property(e => e.SharesOutstandingDate).HasColumnType("datetime");

                entity.Property(e => e.ShortName).HasColumnType("varchar");

                entity.Property(e => e.ShortTermMuniType).HasColumnType("varchar");

                entity.Property(e => e.SinkScheduleAmountType).HasColumnType("varchar");

                entity.Property(e => e.SinkTypeCode).HasColumnType("varchar");

                entity.Property(e => e.SinkingFrequencyCode).HasColumnType("varchar");

                entity.Property(e => e.SixCode).HasColumnType("varchar");

                entity.Property(e => e.SolvencyIicollateralTypeCode)
                    .HasColumnType("varchar")
                    .HasColumnName("SolvencyIICollateralTypeCode");

                entity.Property(e => e.SourceId).HasColumnType("varchar");

                entity.Property(e => e.SponsorId)
                    .HasColumnType("varchar")
                    .HasColumnName("SponsorID");

                entity.Property(e => e.SponsorshipTypeCode).HasColumnType("varchar");

                entity.Property(e => e.Status).HasColumnType("varchar");

                entity.Property(e => e.StockExchangeNumber).HasColumnType("varchar");

                entity.Property(e => e.StockExchangeSecurityCode).HasColumnType("varchar");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal");

                entity.Property(e => e.StrikeRate).HasColumnType("decimal");

                entity.Property(e => e.StripTypeCode).HasColumnType("varchar");

                entity.Property(e => e.SubAssetGroupCode).HasColumnType("varchar");

                entity.Property(e => e.SuspectHandlingField1).HasColumnType("varchar");

                entity.Property(e => e.SuspectHandlingField2).HasColumnType("varchar");

                entity.Property(e => e.SuspectHandlingField3).HasColumnType("varchar");

                entity.Property(e => e.SuspectHandlingField4).HasColumnType("varchar");

                entity.Property(e => e.SuspectHandlingField5).HasColumnType("varchar");

                entity.Property(e => e.SwapDescription).HasColumnType("varchar");

                entity.Property(e => e.SwapVersion).HasColumnType("int");

                entity.Property(e => e.SyntheticStructuredProductCode).HasColumnType("varchar");

                entity.Property(e => e.TaxCountryCode).HasColumnType("varchar");

                entity.Property(e => e.TelekursFactor).HasColumnType("decimal");

                entity.Property(e => e.TickSize).HasColumnType("decimal");

                entity.Property(e => e.TickValue).HasColumnType("decimal");

                entity.Property(e => e.Ticker).HasColumnType("varchar");

                entity.Property(e => e.TotalSharesOutstandingAllClasses).HasColumnType("decimal");

                entity.Property(e => e.TradeCurrencyCode).HasColumnType("varchar");

                entity.Property(e => e.TradeLotSize).HasColumnType("int");

                entity.Property(e => e.TradePlaceCode).HasColumnType("varchar");

                entity.Property(e => e.TradingStatus).HasColumnType("bool");

                entity.Property(e => e.TrancheClassificationIdcode)
                    .HasColumnType("varchar")
                    .HasColumnName("TrancheClassificationIDCode");

                entity.Property(e => e.TranchePoolTypeCode).HasColumnType("varchar");

                entity.Property(e => e.TypeOfBondCode).HasColumnType("varchar");

                entity.Property(e => e.TypeofDebtSecurityCode).HasColumnType("varchar");

                entity.Property(e => e.UltimateBorrower).HasColumnType("varchar");

                entity.Property(e => e.UnadjustedFirstCoupon).HasColumnType("datetime");

                entity.Property(e => e.UnderlyingDescription).HasColumnType("varchar");

                entity.Property(e => e.UnderlyingGaininstrumentId)
                    .HasColumnType("varchar")
                    .HasColumnName("UnderlyingGAINInstrumentID");

                entity.Property(e => e.UnderlyingId)
                    .HasColumnType("bigint")
                    .HasColumnName("Underlying_Id");

                entity.Property(e => e.UnderlyingUnitsForInterestPayment).HasColumnType("decimal");

                entity.Property(e => e.UnderwriterId)
                    .HasColumnType("bigint")
                    .HasColumnName("Underwriter_Id");

                entity.Property(e => e.UnitPriceFlag).HasColumnType("bool");

                entity.Property(e => e.UsStateCode).HasColumnType("varchar");

                entity.Property(e => e.ValorNumber).HasColumnType("varchar");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.Valueof1Pt).HasColumnType("varchar");

                entity.Property(e => e.VariableAnnualReturn).HasColumnType("decimal");

                entity.Property(e => e.VendorInstrumentName).HasColumnType("varchar");

                entity.Property(e => e.VendorIssuerName).HasColumnType("varchar");

                entity.Property(e => e.VotingRights).HasColumnType("decimal");

                entity.Property(e => e.VotingRightsStatusCode).HasColumnType("varchar");

                entity.Property(e => e.WallStreetOfficeId)
                    .HasColumnType("varchar")
                    .HasColumnName("WallStreetOfficeID");

                entity.Property(e => e.Wkn)
                    .HasColumnType("varchar")
                    .HasColumnName("WKN");

                entity.Property(e => e.Wrtcovered)
                    .HasColumnType("varchar")
                    .HasColumnName("WRTCovered");

                entity.Property(e => e.YellowKeyCode).HasColumnType("varchar");

                entity.Property(e => e.YieldToMaturity).HasColumnType("decimal");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.ToTable("Price", "OData");

                entity.HasIndex(e => e.Id, "CDATA_ODATA_PRICE_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint");

                entity.Property(e => e.Comment).HasColumnType("varchar");

                entity.Property(e => e.Etag)
                    .HasColumnType("varchar")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ICurrency)
                    .HasColumnType("varchar")
                    .HasColumnName("I_Currency");

                entity.Property(e => e.IId)
                    .HasColumnType("bigint")
                    .HasColumnName("I_Id");

                entity.Property(e => e.IInstrumentIdentityId)
                    .HasColumnType("bigint")
                    .HasColumnName("I_InstrumentIdentityId");

                entity.Property(e => e.IPricingMethod)
                    .HasColumnType("varchar")
                    .HasColumnName("I_PricingMethod");

                entity.Property(e => e.IReferencePriceDate)
                    .HasColumnType("varchar")
                    .HasColumnName("I_ReferencePriceDate");

                entity.Property(e => e.InvestigationChecksApplied).HasColumnType("varchar");

                entity.Property(e => e.InvestigationCreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTimestamp).HasColumnType("datetime");

                entity.Property(e => e.LinkedCustomProperties).HasColumnType("varchar");

                entity.Property(e => e.LinkedSilverCopies).HasColumnType("varchar");

                entity.Property(e => e.MarketId)
                    .HasColumnType("bigint")
                    .HasColumnName("Market_Id");

                entity.Property(e => e.ModificationReasonCode).HasColumnType("varchar");

                entity.Property(e => e.PriceSourceInformationFallback).HasColumnType("varchar");

                entity.Property(e => e.PriceSourceInformationPart1).HasColumnType("varchar");

                entity.Property(e => e.PriceUnitCode).HasColumnType("varchar");

                entity.Property(e => e.ProviderCode).HasColumnType("varchar");

                entity.Property(e => e.ProviderPriceDate).HasColumnType("datetime");

                entity.Property(e => e.ProviderPriceTime).HasColumnType("datetime");

                entity.Property(e => e.QuotationMode).HasColumnType("varchar");

                entity.Property(e => e.QuotationTypeCode).HasColumnType("varchar");

                entity.Property(e => e.RequestCode).HasColumnType("varchar");

                entity.Property(e => e.SnapshotTime).HasColumnType("datetime");

                entity.Property(e => e.Spread).HasColumnType("decimal");

                entity.Property(e => e.Value).HasColumnType("decimal");

                entity.Property(e => e.Volume).HasColumnType("decimal");

                entity.Property(e => e.Yield).HasColumnType("decimal");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
