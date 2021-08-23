using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ODataDemo.Models;

namespace ODataDemo.Controllers
{
    public class EventsController : Controller
    {
        private readonly ODataContext _context;

        public EventsController(ODataContext context)
        {
            _context = context;
        }

        // GET: Events
        public async Task<IActionResult> Index()
        {
            return View(await _context.Events.ToListAsync());
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Etag,Id,AccruedInterestDays,ActualContractualCode,AdditionalTaxIsSet,AdditionalTaxPrimaryCurrencyCode,AdditionalTaxPrimaryValue,AdditionalTaxSecondaryCurrencyCode,AdditionalTaxSecondaryValue,AdditionalTaxType,Affidavit,Aftcode,AftmanualSetCode,AnnouncementDateIsSet,AnnouncementDateValue,AnnouncementDateType,AnnouncementDateUtcOffset,BbgDividendTypeCode,BidIntervalRateIsSet,BidIntervalRatePrimaryCurrencyCode,BidIntervalRatePrimaryValue,BidIntervalRateSecondaryCurrencyCode,BidIntervalRateSecondaryValue,BidIntervalRateType,BlockingPeriodIsSet,BlockingPeriodStartDate,BlockingPeriodEndDate,BlockingPeriodType,BookClosureperiodIsSet,BookClosureperiodStartDate,BookClosureperiodEndDate,BookClosureperiodType,CashflowSetId,CashflowSetTypeCode,ChangeTypeCode,CodeEventisCode,CorporateActionEventStageCode,CouponNumber,DefaultTaxRate,DenominationCode,DepartmentCode,DepositorysuspensionperiodforwithdrawalatagentIsSet,DepositorysuspensionperiodforwithdrawalatagentStartDate,DepositorysuspensionperiodforwithdrawalatagentEndDate,DepositorysuspensionperiodforwithdrawalatagentType,DerivedEffectiveDateIsSet,DerivedEffectiveDateValue,DerivedEffectiveDateType,DerivedEffectiveDateUtcOffset,DerivedExDateIsSet,DerivedExDateValue,DerivedExDateType,DerivedExDateUtcOffset,DistributionTypeCode,DividendFrequencyCode,DueDateIsSet,DueDateValue,DueDateType,DueDateUtcOffset,EffectiveDateIsSet,EffectiveDateValue,EffectiveDateType,EffectiveDateUtcOffset,EntitlementPeriodIsSet,EntitlementPeriodStartDate,EntitlementPeriodEndDate,EntitlementPeriodType,EusdInterestProportionChIsSet,EusdInterestProportionChPrimaryCurrencyCode,EusdInterestProportionChPrimaryValue,EusdInterestProportionChSecondaryCurrencyCode,EusdInterestProportionChSecondaryValue,EusdInterestProportionChType,EusdInterestProportionEuIsSet,EusdInterestProportionEuPrimaryCurrencyCode,EusdInterestProportionEuPrimaryValue,EusdInterestProportionEuSecondaryCurrencyCode,EusdInterestProportionEuSecondaryValue,EusdInterestProportionEuType,EventDeadline,EventTypeCode,ExDateIsSet,ExDateValue,ExDateType,ExDateUtcOffset,ExemptionCode,ExpiryDateIsSet,ExpiryDateValue,ExpiryDateType,ExpiryDateUtcOffset,ExtendedNarrativeSerialized,FamilyCode,FeesIsSet,FeesPrimaryCurrencyCode,FeesPrimaryValue,FeesSecondaryCurrencyCode,FeesSecondaryValue,FeesType,FilingDateIsSet,FilingDateValue,FilingDateType,FilingDateUtcOffset,FiscalStampIsSet,FiscalStampPrimaryCurrencyCode,FiscalStampPrimaryValue,FiscalStampSecondaryCurrencyCode,FiscalStampSecondaryValue,FiscalStampType,FixingDateIsSet,FixingDateValue,FixingDateType,FixingDateUtcOffset,FloatingRateFixingDateIsSet,FloatingRateFixingDateValue,FloatingRateFixingDateType,FloatingRateFixingDateUtcOffset,Forexo,FrenchTaxRateIsSet,FrenchTaxRatePrimaryCurrencyCode,FrenchTaxRatePrimaryValue,FrenchTaxRateSecondaryCurrencyCode,FrenchTaxRateSecondaryValue,FrenchTaxRateType,Guid,HasNoConflicts,IncomeCode,IncomeTypeCode,InformationStatusCode,InformationStatusTypeCode,InstrumentIdentityId,InterestAmount,InterestCalculationMethodCode,InterestDaysPerAnnum,InterestFractionIsSet,InterestFractionPrimaryCurrencyCode,InterestFractionPrimaryValue,InterestFractionSecondaryCurrencyCode,InterestFractionSecondaryValue,InterestFractionType,InterestPeriodIsSet,InterestPeriodStartDate,InterestPeriodEndDate,InterestPeriodType,InterestRateIsSet,InterestRatePrimaryCurrencyCode,InterestRatePrimaryValue,InterestRateSecondaryCurrencyCode,InterestRateSecondaryValue,InterestRateType,IntermediateInstrumentIdentityId,IntermediateSecuritiesDispositionOfFractionCode,IntermediateSecuritiesDistributionTypeCode,IntermediateSecuritiesExpiryDateIsSet,IntermediateSecuritiesExpiryDateValue,IntermediateSecuritiesExpiryDateType,IntermediateSecuritiesExpiryDateUtcOffset,IntermediateSecuritiesRenounceableIndicatorCode,IntermediateSecuritiesToUnderlyingRatioIsSet,IntermediateSecuritiesToUnderlyingRatioPrimaryCurrencyCode,IntermediateSecuritiesToUnderlyingRatioPrimaryValue,IntermediateSecuritiesToUnderlyingRatioSecondaryCurrencyCode,IntermediateSecuritiesToUnderlyingRatioSecondaryValue,IntermediateSecuritiesToUnderlyingRatioType,IntermediateSecuritiesTradingPeriodIsSet,IntermediateSecuritiesTradingPeriodStartDate,IntermediateSecuritiesTradingPeriodEndDate,IntermediateSecuritiesTradingPeriodType,IsComplete,IsConfirmed,IsNarrativeChecked,IEventId,IId,JsonAdditionalTax,JsonBidIntervalRate,JsonBookClosureperiod,JsonDepositorysuspensionperiodforwithdrawalatagent,JsonEusdInterestProportionCh,JsonEusdInterestProportionEu,JsonFees,JsonFilingDate,JsonFiscalStamp,JsonFrenchTaxRate,JsonInterestFraction,JsonInterestRate,JsonIntermediateSecuritiesToUnderlyingRatio,JsonLotteryDateTime,JsonMarketclaimtrackingenddate,JsonMaximumPrice,JsonMaximumquantityofsecurities,JsonMinimumPrice,JsonMinimumQuantitysought,JsonNewPoolFactor,JsonNraamount,JsonNrarate,JsonOfficialAnnouncementPublicationDateTime,JsonOldPoolFactor,JsonPercentageSought,JsonPremiumFraction,JsonRefundOfNra,JsonResultPublicationDateTime,JsonTaxCreditRate,JsonTaxOnIncome,JsonTaxOnProfits,JsonTaxRate,JsonTaxRelatedRate,JsonTidch,JsonTideu,JsonWithholdingTaxRate,LastChangeDate,LastDistributionDateIsSet,LastDistributionDateValue,LastDistributionDateType,LastDistributionDateUtcOffset,LastIgnoredRelevantHashcode,LotteryDateTimeIsSet,LotteryDateTimeValue,LotteryDateTimeType,LotteryDateTimeUtcOffset,MandatoryVoluntaryIndicatorCode,MarketclaimtrackingenddateIsSet,MarketclaimtrackingenddateValue,MarketclaimtrackingenddateType,MarketclaimtrackingenddateUtcOffset,MaximumPriceIsSet,MaximumPriceCurrencyCode,MaximumPriceValue,MaximumPriceType,MaximumPriceCode,MaximumPriceQuantity,MaximumPriceQuantityTypeCode,MaximumPriceIsCalculated,MaximumPriceValue2,MaximumPriceCurrency2Code,MaximumquantityofsecuritiesIsSet,MaximumquantityofsecuritiesValue,MaximumquantityofsecuritiesType,MeetingDateIsSet,MeetingDateValue,MeetingDateType,MeetingDateUtcOffset,MinimumPriceIsSet,MinimumPriceCurrencyCode,MinimumPriceValue,MinimumPriceType,MinimumPriceCode,MinimumPriceQuantity,MinimumPriceQuantityTypeCode,MinimumPriceIsCalculated,MinimumPriceValue2,MinimumPriceCurrency2Code,MinimumProcessingLevel,MinimumQuantitysoughtIsSet,MinimumQuantitysoughtValue,MinimumQuantitysoughtType,NarrativeSerialized,NewName,NewPoolFactorIsSet,NewPoolFactorPrimaryCurrencyCode,NewPoolFactorPrimaryValue,NewPoolFactorSecondaryCurrencyCode,NewPoolFactorSecondaryValue,NewPoolFactorType,NraamountIsSet,NraamountCurrencyCode,NraamountValue,NraamountType,NraamountCode,NraamountQuantity,NraamountQuantityTypeCode,NraamountIsCalculated,NraamountValue2,NraamountCurrency2Code,NrarateIsSet,NrarateCurrencyCode,NrarateValue,NrarateType,NrarateCode,NrarateQuantity,NrarateQuantityTypeCode,NrarateIsCalculated,NrarateValue2,NrarateCurrency2Code,Offeror,OfferTypeCode,OfficialAnnouncementPublicationDateTimeIsSet,OfficialAnnouncementPublicationDateTimeValue,OfficialAnnouncementPublicationDateTimeType,OfficialAnnouncementPublicationDateTimeUtcOffset,OfficialEventReference,OldPoolFactorIsSet,OldPoolFactorPrimaryCurrencyCode,OldPoolFactorPrimaryValue,OldPoolFactorSecondaryCurrencyCode,OldPoolFactorSecondaryValue,OldPoolFactorType,OptionCount,OrderTypeCode,OwnerCode,ParentEvent,ParentIncomeCode,PartialTypeOfDividendCode,PaymentDateIsSet,PaymentDateValue,PaymentDateType,PaymentDateUtcOffset,PaymentFunctionCode,PercentageSoughtIsSet,PercentageSoughtPrimaryCurrencyCode,PercentageSoughtPrimaryValue,PercentageSoughtSecondaryCurrencyCode,PercentageSoughtSecondaryValue,PercentageSoughtType,PlaceOfListing,PostingDateIsSet,PostingDateValue,PostingDateType,PostingDateUtcOffset,PremiumFractionIsSet,PremiumFractionPrimaryCurrencyCode,PremiumFractionPrimaryValue,PremiumFractionSecondaryCurrencyCode,PremiumFractionSecondaryValue,PremiumFractionType,ProcessingStateCode,PublicationWindowEndDate,QuotationTypeCode,RatingCode,RecordDateIsSet,RecordDateValue,RecordDateType,RecordDateUtcOffset,ReferenceDate,RefundOfNraIsSet,RefundOfNraCurrencyCode,RefundOfNraValue,RefundOfNraType,RefundOfNraCode,RefundOfNraQuantity,RefundOfNraQuantityTypeCode,RefundOfNraIsCalculated,RefundOfNraValue2,RefundOfNraCurrency2Code,RelevantPropertiesHashcode,RenounceableIndicatorCode,ResultPublicationDateTimeIsSet,ResultPublicationDateTimeValue,ResultPublicationDateTimeType,ResultPublicationDateTimeUtcOffset,SecurityPosition,SilverCopyCount,State,SwiftMessageFunctionCode,TargetSystemId,TargetSystemStateCode,TaxAmountTypeCode,TaxCreditRateIsSet,TaxCreditRatePrimaryCurrencyCode,TaxCreditRatePrimaryValue,TaxCreditRateSecondaryCurrencyCode,TaxCreditRateSecondaryValue,TaxCreditRateType,TaxOnIncomeIsSet,TaxOnIncomePrimaryCurrencyCode,TaxOnIncomePrimaryValue,TaxOnIncomeSecondaryCurrencyCode,TaxOnIncomeSecondaryValue,TaxOnIncomeType,TaxOnProfitsIsSet,TaxOnProfitsPrimaryCurrencyCode,TaxOnProfitsPrimaryValue,TaxOnProfitsSecondaryCurrencyCode,TaxOnProfitsSecondaryValue,TaxOnProfitsType,TaxRateIsSet,TaxRatePrimaryCurrencyCode,TaxRatePrimaryValue,TaxRateSecondaryCurrencyCode,TaxRateSecondaryValue,TaxRateType,TaxRelatedRateIsSet,TaxRelatedRatePrimaryCurrencyCode,TaxRelatedRatePrimaryValue,TaxRelatedRateSecondaryCurrencyCode,TaxRelatedRateSecondaryValue,TaxRelatedRateType,TidchIsSet,TidchPrimaryCurrencyCode,TidchPrimaryValue,TidchSecondaryCurrencyCode,TidchSecondaryValue,TidchType,TideuIsSet,TideuPrimaryCurrencyCode,TideuPrimaryValue,TideuSecondaryCurrencyCode,TideuSecondaryValue,TideuType,TransactionTypeCode,TypeOfDividendCode,TypeOfListingCode,TypeOfPaymentAmountCode,TypeOfPaymentAmountList,ValidationTypeCode,VdfAmortizationType,VdfCashFlowId,VdfCashflowType,VdfChId,VdfDividendSupplInfoCode,VdfDividendTypeCode,VdfMessageItemCode,VdfPaymentAmountType,WithholdingOfForeignTax,WithholdingOfLocalTax,WithholdingTaxRateIsSet,WithholdingTaxRatePrimaryCurrencyCode,WithholdingTaxRatePrimaryValue,WithholdingTaxRateSecondaryCurrencyCode,WithholdingTaxRateSecondaryValue,WithholdingTaxRateType,LinkedCustomProperties,LinkedOptions,LinkedSilverCopies")] Event @event)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Etag,Id,AccruedInterestDays,ActualContractualCode,AdditionalTaxIsSet,AdditionalTaxPrimaryCurrencyCode,AdditionalTaxPrimaryValue,AdditionalTaxSecondaryCurrencyCode,AdditionalTaxSecondaryValue,AdditionalTaxType,Affidavit,Aftcode,AftmanualSetCode,AnnouncementDateIsSet,AnnouncementDateValue,AnnouncementDateType,AnnouncementDateUtcOffset,BbgDividendTypeCode,BidIntervalRateIsSet,BidIntervalRatePrimaryCurrencyCode,BidIntervalRatePrimaryValue,BidIntervalRateSecondaryCurrencyCode,BidIntervalRateSecondaryValue,BidIntervalRateType,BlockingPeriodIsSet,BlockingPeriodStartDate,BlockingPeriodEndDate,BlockingPeriodType,BookClosureperiodIsSet,BookClosureperiodStartDate,BookClosureperiodEndDate,BookClosureperiodType,CashflowSetId,CashflowSetTypeCode,ChangeTypeCode,CodeEventisCode,CorporateActionEventStageCode,CouponNumber,DefaultTaxRate,DenominationCode,DepartmentCode,DepositorysuspensionperiodforwithdrawalatagentIsSet,DepositorysuspensionperiodforwithdrawalatagentStartDate,DepositorysuspensionperiodforwithdrawalatagentEndDate,DepositorysuspensionperiodforwithdrawalatagentType,DerivedEffectiveDateIsSet,DerivedEffectiveDateValue,DerivedEffectiveDateType,DerivedEffectiveDateUtcOffset,DerivedExDateIsSet,DerivedExDateValue,DerivedExDateType,DerivedExDateUtcOffset,DistributionTypeCode,DividendFrequencyCode,DueDateIsSet,DueDateValue,DueDateType,DueDateUtcOffset,EffectiveDateIsSet,EffectiveDateValue,EffectiveDateType,EffectiveDateUtcOffset,EntitlementPeriodIsSet,EntitlementPeriodStartDate,EntitlementPeriodEndDate,EntitlementPeriodType,EusdInterestProportionChIsSet,EusdInterestProportionChPrimaryCurrencyCode,EusdInterestProportionChPrimaryValue,EusdInterestProportionChSecondaryCurrencyCode,EusdInterestProportionChSecondaryValue,EusdInterestProportionChType,EusdInterestProportionEuIsSet,EusdInterestProportionEuPrimaryCurrencyCode,EusdInterestProportionEuPrimaryValue,EusdInterestProportionEuSecondaryCurrencyCode,EusdInterestProportionEuSecondaryValue,EusdInterestProportionEuType,EventDeadline,EventTypeCode,ExDateIsSet,ExDateValue,ExDateType,ExDateUtcOffset,ExemptionCode,ExpiryDateIsSet,ExpiryDateValue,ExpiryDateType,ExpiryDateUtcOffset,ExtendedNarrativeSerialized,FamilyCode,FeesIsSet,FeesPrimaryCurrencyCode,FeesPrimaryValue,FeesSecondaryCurrencyCode,FeesSecondaryValue,FeesType,FilingDateIsSet,FilingDateValue,FilingDateType,FilingDateUtcOffset,FiscalStampIsSet,FiscalStampPrimaryCurrencyCode,FiscalStampPrimaryValue,FiscalStampSecondaryCurrencyCode,FiscalStampSecondaryValue,FiscalStampType,FixingDateIsSet,FixingDateValue,FixingDateType,FixingDateUtcOffset,FloatingRateFixingDateIsSet,FloatingRateFixingDateValue,FloatingRateFixingDateType,FloatingRateFixingDateUtcOffset,Forexo,FrenchTaxRateIsSet,FrenchTaxRatePrimaryCurrencyCode,FrenchTaxRatePrimaryValue,FrenchTaxRateSecondaryCurrencyCode,FrenchTaxRateSecondaryValue,FrenchTaxRateType,Guid,HasNoConflicts,IncomeCode,IncomeTypeCode,InformationStatusCode,InformationStatusTypeCode,InstrumentIdentityId,InterestAmount,InterestCalculationMethodCode,InterestDaysPerAnnum,InterestFractionIsSet,InterestFractionPrimaryCurrencyCode,InterestFractionPrimaryValue,InterestFractionSecondaryCurrencyCode,InterestFractionSecondaryValue,InterestFractionType,InterestPeriodIsSet,InterestPeriodStartDate,InterestPeriodEndDate,InterestPeriodType,InterestRateIsSet,InterestRatePrimaryCurrencyCode,InterestRatePrimaryValue,InterestRateSecondaryCurrencyCode,InterestRateSecondaryValue,InterestRateType,IntermediateInstrumentIdentityId,IntermediateSecuritiesDispositionOfFractionCode,IntermediateSecuritiesDistributionTypeCode,IntermediateSecuritiesExpiryDateIsSet,IntermediateSecuritiesExpiryDateValue,IntermediateSecuritiesExpiryDateType,IntermediateSecuritiesExpiryDateUtcOffset,IntermediateSecuritiesRenounceableIndicatorCode,IntermediateSecuritiesToUnderlyingRatioIsSet,IntermediateSecuritiesToUnderlyingRatioPrimaryCurrencyCode,IntermediateSecuritiesToUnderlyingRatioPrimaryValue,IntermediateSecuritiesToUnderlyingRatioSecondaryCurrencyCode,IntermediateSecuritiesToUnderlyingRatioSecondaryValue,IntermediateSecuritiesToUnderlyingRatioType,IntermediateSecuritiesTradingPeriodIsSet,IntermediateSecuritiesTradingPeriodStartDate,IntermediateSecuritiesTradingPeriodEndDate,IntermediateSecuritiesTradingPeriodType,IsComplete,IsConfirmed,IsNarrativeChecked,IEventId,IId,JsonAdditionalTax,JsonBidIntervalRate,JsonBookClosureperiod,JsonDepositorysuspensionperiodforwithdrawalatagent,JsonEusdInterestProportionCh,JsonEusdInterestProportionEu,JsonFees,JsonFilingDate,JsonFiscalStamp,JsonFrenchTaxRate,JsonInterestFraction,JsonInterestRate,JsonIntermediateSecuritiesToUnderlyingRatio,JsonLotteryDateTime,JsonMarketclaimtrackingenddate,JsonMaximumPrice,JsonMaximumquantityofsecurities,JsonMinimumPrice,JsonMinimumQuantitysought,JsonNewPoolFactor,JsonNraamount,JsonNrarate,JsonOfficialAnnouncementPublicationDateTime,JsonOldPoolFactor,JsonPercentageSought,JsonPremiumFraction,JsonRefundOfNra,JsonResultPublicationDateTime,JsonTaxCreditRate,JsonTaxOnIncome,JsonTaxOnProfits,JsonTaxRate,JsonTaxRelatedRate,JsonTidch,JsonTideu,JsonWithholdingTaxRate,LastChangeDate,LastDistributionDateIsSet,LastDistributionDateValue,LastDistributionDateType,LastDistributionDateUtcOffset,LastIgnoredRelevantHashcode,LotteryDateTimeIsSet,LotteryDateTimeValue,LotteryDateTimeType,LotteryDateTimeUtcOffset,MandatoryVoluntaryIndicatorCode,MarketclaimtrackingenddateIsSet,MarketclaimtrackingenddateValue,MarketclaimtrackingenddateType,MarketclaimtrackingenddateUtcOffset,MaximumPriceIsSet,MaximumPriceCurrencyCode,MaximumPriceValue,MaximumPriceType,MaximumPriceCode,MaximumPriceQuantity,MaximumPriceQuantityTypeCode,MaximumPriceIsCalculated,MaximumPriceValue2,MaximumPriceCurrency2Code,MaximumquantityofsecuritiesIsSet,MaximumquantityofsecuritiesValue,MaximumquantityofsecuritiesType,MeetingDateIsSet,MeetingDateValue,MeetingDateType,MeetingDateUtcOffset,MinimumPriceIsSet,MinimumPriceCurrencyCode,MinimumPriceValue,MinimumPriceType,MinimumPriceCode,MinimumPriceQuantity,MinimumPriceQuantityTypeCode,MinimumPriceIsCalculated,MinimumPriceValue2,MinimumPriceCurrency2Code,MinimumProcessingLevel,MinimumQuantitysoughtIsSet,MinimumQuantitysoughtValue,MinimumQuantitysoughtType,NarrativeSerialized,NewName,NewPoolFactorIsSet,NewPoolFactorPrimaryCurrencyCode,NewPoolFactorPrimaryValue,NewPoolFactorSecondaryCurrencyCode,NewPoolFactorSecondaryValue,NewPoolFactorType,NraamountIsSet,NraamountCurrencyCode,NraamountValue,NraamountType,NraamountCode,NraamountQuantity,NraamountQuantityTypeCode,NraamountIsCalculated,NraamountValue2,NraamountCurrency2Code,NrarateIsSet,NrarateCurrencyCode,NrarateValue,NrarateType,NrarateCode,NrarateQuantity,NrarateQuantityTypeCode,NrarateIsCalculated,NrarateValue2,NrarateCurrency2Code,Offeror,OfferTypeCode,OfficialAnnouncementPublicationDateTimeIsSet,OfficialAnnouncementPublicationDateTimeValue,OfficialAnnouncementPublicationDateTimeType,OfficialAnnouncementPublicationDateTimeUtcOffset,OfficialEventReference,OldPoolFactorIsSet,OldPoolFactorPrimaryCurrencyCode,OldPoolFactorPrimaryValue,OldPoolFactorSecondaryCurrencyCode,OldPoolFactorSecondaryValue,OldPoolFactorType,OptionCount,OrderTypeCode,OwnerCode,ParentEvent,ParentIncomeCode,PartialTypeOfDividendCode,PaymentDateIsSet,PaymentDateValue,PaymentDateType,PaymentDateUtcOffset,PaymentFunctionCode,PercentageSoughtIsSet,PercentageSoughtPrimaryCurrencyCode,PercentageSoughtPrimaryValue,PercentageSoughtSecondaryCurrencyCode,PercentageSoughtSecondaryValue,PercentageSoughtType,PlaceOfListing,PostingDateIsSet,PostingDateValue,PostingDateType,PostingDateUtcOffset,PremiumFractionIsSet,PremiumFractionPrimaryCurrencyCode,PremiumFractionPrimaryValue,PremiumFractionSecondaryCurrencyCode,PremiumFractionSecondaryValue,PremiumFractionType,ProcessingStateCode,PublicationWindowEndDate,QuotationTypeCode,RatingCode,RecordDateIsSet,RecordDateValue,RecordDateType,RecordDateUtcOffset,ReferenceDate,RefundOfNraIsSet,RefundOfNraCurrencyCode,RefundOfNraValue,RefundOfNraType,RefundOfNraCode,RefundOfNraQuantity,RefundOfNraQuantityTypeCode,RefundOfNraIsCalculated,RefundOfNraValue2,RefundOfNraCurrency2Code,RelevantPropertiesHashcode,RenounceableIndicatorCode,ResultPublicationDateTimeIsSet,ResultPublicationDateTimeValue,ResultPublicationDateTimeType,ResultPublicationDateTimeUtcOffset,SecurityPosition,SilverCopyCount,State,SwiftMessageFunctionCode,TargetSystemId,TargetSystemStateCode,TaxAmountTypeCode,TaxCreditRateIsSet,TaxCreditRatePrimaryCurrencyCode,TaxCreditRatePrimaryValue,TaxCreditRateSecondaryCurrencyCode,TaxCreditRateSecondaryValue,TaxCreditRateType,TaxOnIncomeIsSet,TaxOnIncomePrimaryCurrencyCode,TaxOnIncomePrimaryValue,TaxOnIncomeSecondaryCurrencyCode,TaxOnIncomeSecondaryValue,TaxOnIncomeType,TaxOnProfitsIsSet,TaxOnProfitsPrimaryCurrencyCode,TaxOnProfitsPrimaryValue,TaxOnProfitsSecondaryCurrencyCode,TaxOnProfitsSecondaryValue,TaxOnProfitsType,TaxRateIsSet,TaxRatePrimaryCurrencyCode,TaxRatePrimaryValue,TaxRateSecondaryCurrencyCode,TaxRateSecondaryValue,TaxRateType,TaxRelatedRateIsSet,TaxRelatedRatePrimaryCurrencyCode,TaxRelatedRatePrimaryValue,TaxRelatedRateSecondaryCurrencyCode,TaxRelatedRateSecondaryValue,TaxRelatedRateType,TidchIsSet,TidchPrimaryCurrencyCode,TidchPrimaryValue,TidchSecondaryCurrencyCode,TidchSecondaryValue,TidchType,TideuIsSet,TideuPrimaryCurrencyCode,TideuPrimaryValue,TideuSecondaryCurrencyCode,TideuSecondaryValue,TideuType,TransactionTypeCode,TypeOfDividendCode,TypeOfListingCode,TypeOfPaymentAmountCode,TypeOfPaymentAmountList,ValidationTypeCode,VdfAmortizationType,VdfCashFlowId,VdfCashflowType,VdfChId,VdfDividendSupplInfoCode,VdfDividendTypeCode,VdfMessageItemCode,VdfPaymentAmountType,WithholdingOfForeignTax,WithholdingOfLocalTax,WithholdingTaxRateIsSet,WithholdingTaxRatePrimaryCurrencyCode,WithholdingTaxRatePrimaryValue,WithholdingTaxRateSecondaryCurrencyCode,WithholdingTaxRateSecondaryValue,WithholdingTaxRateType,LinkedCustomProperties,LinkedOptions,LinkedSilverCopies")] Event @event)
        {
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var @event = await _context.Events.FindAsync(id);
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(long id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
