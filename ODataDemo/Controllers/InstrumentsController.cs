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
  public class InstrumentsController : Controller
  {
    private readonly ODataContext _context;

    public InstrumentsController(ODataContext context)
    {
      _context = context;
    }

    // GET: Instruments
    public async Task<IActionResult> Index()
    {
      return View(await _context.Instruments.ToListAsync());
    }

    // GET: Instruments/Details/5
    public async Task<IActionResult> Details(long? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var instrument = await _context.Instruments
          .FirstOrDefaultAsync(m => m.Id == id);
      if (instrument == null)
      {
        return NotFound();
      }

      return View(instrument);
    }

    // GET: Instruments/Create
    public IActionResult Create()
    {
      return View();
    }

    // POST: Instruments/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Etag,Id,AbsMbsassetTypeCode,AccruedDaysBetweenCpndates,AccruedInterest,Active,AgeCalculated,AlternativeBbticker,AlternativeCommonCode,AlternativeCusip,AlternativeId1,AlternativeIsin,AlternativeSedol,AmficodeCode,AmountIssuedAccumulating,AmountIssuedOriginal,AmountOutstanding,AmountOutstandingDate,AsOfCoupon,AssetClass,AssetTypeNew,AssimilatedAssetId,AttachmentPoint,BankruptPercentage,BaseCpidate,BaseCpivalue,BaseCurrencyCode,BasicSpread,BbgaccruedBasis,BbgCompositeGlobalId,BbgdataLicenseAssetClassCode,BbgDayCountCode,BbgglobalCompanyId,BbgGlobalId,BbglongTermFundObjectiveCode,BbgpricingMethodCode,BbgprimarySecurityYellowKeyCode,BbgsecurityDescription,BbgSecurityTypeCode,BbgspecificCouponTypeCode,BbgTicker,BbgUniqueId,BemaustraliaId,BenchmarkReferenceId,BissettId,BlackListed,BloombergCode,BloombergCodeInfo,BloombergData,BloombergFactor,BloombergGlobalId,BloombergYellowKeyOverride,BnyMellonId,BondSeries,BovespaTicker,CalendarDayOfCouponPaymentCode,CallablePutableCode,CallDate,CallFeatureCode,CallFrequencyCode,CallPrice,CapitalProtectionCode,CapitalTriggerTypeCode,CashDividendConfirmationDate,Catastrophe,CategoryCode,CertificateUnderlyingTypeCode,CertificationType,Cficode,CharlesRiverId,CiccategoryCode,Ciccode,Cinsid,CloseDate,Cmbstype,Cmoclass,Cmoseries,CollateralCountryCode,CollateralDescriptionCode,CollateralPortfolioCode,CollateralTypeCode,CollateralValue,CommonCode,CompletenessLevelCode,ContractSize,ConversionFixedExchangeRate,ConversionPrice,ConversionRatio,ConversionStartDate,ConversionTypeCode,ConversionUntilDate,ConvertibleExpirationDate,CountryOfDomicileCode,CountryOfGuarantorCode,CountryOfIssueCode,CountryOfListingCode,CountryOfRiskCode,CouponAsOfDate,CouponCurrencyCode,CouponFrequencyCode,CouponRate,CouponTypeCode,CouponTypeResetDate,CreatedBy,CreationDate,CreditEnhancementTypeCode,CurrentCouponPaymentExDividendDate,CurrentNet,CurrentWac,CurrentWam,Cusip,DayCountCode,DefaultCurrency,DefaultDate,Delta,DetachmentPoint,DividendFrequencyCode,DividendIndicated1YearGross,DvdshareTemp,EarlyRedemptionInfo,EquityFundamentalCurrencyCode,Eqydvdtemp,ExchangeCode,ExDividendDays,ExerciseEndDate,ExerciseTypeCode,ExpectedMaturityDate,ExpirationDate,ExpiryDate144A,Factor,FactorEffectiveDate,FactsetIndustryCode,FederallyTaxable,FeedLastUpdateDate,FeedStartRestrictedStatus,FirstCouponPaymentDate,FirstExDividendDate,FirstInterestAccrualDate,FirstPrincipalPayDate,FirstSettleDate,FirstTradeDate,Fisn,FixedCpnvalue,FixedToFloatCouponFrequencyCode,FixedToFloatDayCountCode,FloaterBenchmarkMultiplier,FloaterFormula,FloaterIndex,FloaterSpread,FundAssetClassFocusCode,FundCompanyName,FundGeographicalFocusCode,FundIndustryFocusCode,FundInitialCurrencyCode,FundInvestedInCashAndOthers,FundInvestedInCorpSecurities,FundInvestedInEquitySecurities,FundinvestedinGovernmentSecurities,FundInvestedInMtgeSecurities,FundInvestedInMuniSecurities,FundinvestedinPrefSecurities,FundManagementCompany,FundManagementStyleCode,FundMarketCapFocusCode,FundMaturityFocusCode,FundNavcurrencyCode,FundNavvalue,FundPricingFrequencyCode,FundPricingSource,FundRatingClassFocusCode,FundRedepmtionDate,FundStrategyCode,FundTaxStatus,FundTotalAssets,FundTotalAssetsCurrencyCode,FundTypeCode,FuturesAndOptionsCategoryCode,FuturesFirstDeliveryDate,FuturesFirstNoticeDate,FuturesInitialMarginSpeculator,FuturesLastDeliveryDate,FuturesRollDate,GainId,GainIssuerId,GeographicalZoneCode,GicssubIndustryCode,GlobalAssetClassCode,GlobalAssetTypeCode,Gplusflag,Gplusid,GrossDividend1YearGrowthRate,GrossDividend3YearGrowthRate,Guarantor,Has144AregSrights,HasAlternativeMinimumTax,HasContingentDebt,HasEndAccDateAtMonthEnd,HasInterestCapitalization,HasInterestPayDateAtMonthEnd,HasLocspacode,HasLong1stCoupon,HasMakeWholeCallPossible,HasMortgageIsPaidOff,HasProspective,HasSharesIncluded,HasShort1stCoupon,HasSolvencyIi,IndexLag,IndexLagUnitCode,IndexName,IndexTypeCode,IndexId,InflationIndexPriceFreq,InitialPublicOfferDate,InitialPubOfferSharePrice,InstrumentGroupCode,InstrumentTypeCode,InsurerPercentage,InterestBusinessDayConventionCode,InterestCalculationTypeCode,InterestPaymentMethodCode,InterestShortFall,Ipoprice,Is144A,IsAccumulatingFund,IsAgencyBacked,IsAuctionRate,IsBearerSecurity,IsCallable,IsCalled,IsClosedEndFund,IsContingentConvertible,IsConvertible,IsCouponInDefault,IsCovered,IsCreditLinked,IscurrentGovernmentBond,IsDefaulted,IsDeflationProtected,IsDualCurrency,IsErisa,IsExchangeable,IsFixtoFloat,IsFloater,IsFloattoFix,IsFundOfFunds,IsHybridBond,IsHybridCumulative,IsHybridDeferredPaymentAllowed,Isin,IsIndexInterpolated,IsInflationLinked,IsIrregularCashFlow,IsIslamic,IslamicBondTypeCode,IsMandatoryConversion,IsPartiallyCalled,IsPerpetual,IsPrepaymentStructuredProduct,IsPrivatePlacement,IsPutable,IsRedeeming,IsRegisteredSecurity,IsRegS,IsRemarketed,IsReverseConvertible,IsSecured,IsSenior,IsSinkable,IsStandard,IsStructuredNote,IsSubordinated,IssueCurrencyCode,IssueDate,IssueDescription13F,IssuePrice,IssuerDescription13F,IssuerId,IsSyntheticConvertible,IsSyntheticLoan,IsTaxableBond,IsUnitTraded,IsUnsecured,IsUpdated,IsUssection13F,IsVariable,IGainInstrumentId,IId,LastCallableDate,LastClosePriceDate,LastCouponDate,LastPrice,LastRefixDate,LastTradeDate,LatestSinkingFundFactor,LegalFinalMaturity,LoanFacilityName,LocalExchangeSymbol,LocexpirationDate,Locspapercentage,LongName,MarketCapitalization,MarketStatusCode,MarketTicker,MarkitLxid,MaturityDate,MaturityTypeCode,MbsprodCodeCode,MinimumIncrement,MinimumPurchaseAmount,MinumumTradableAmount,ModifiedDurationInternal,MortgageCollateralTypeCode,MortgageDealTypeCode,MortgageLoanAge,MortgageTrancheTypeCode,MostRecentAccrRtStartDate,MostRecentDefaultDate,MtgeFirstProjectedCashflowDate,MtgeNextPayDatePerSettle,MultipleShares,MunicipalIndustryTypeCode,MunicipalIssueName,MunicipalIssueTypeCode,MunicipalScccode,MunicipalTaxStatusCode,MuniSscClassCodeCode,NaceclassCode,Nacecode,NacedivisionCode,NacegroupCode,NacesectorCode,NameOfProject,NegativeInterest,NetDividend1YearGrowthRate,NetDividend3YearGrowthRate,NextCouponPayDate,NextFactorDate,NextRefixDate,NextSinkAmount,NextSinkingDate,NextSinkingPrice,NominalPaymentDay,NumberOfPositions,NumOfDeferredPaymentsAllowed,Occ21symbol,OpenDate,OptionExoticTypeCode,OptionTypeCode,OriginalNet,OriginalWac,OriginalWam,ParValue,ParValueCurrencyCode,PayDelay,PaymentRankCode,PenultimateCpndate,PercentOfIssue,PerformanceSectorCode,PoolNumber,PoolTypeCode,PositionsAmount,PrepaymentSpeed,PrepaymentSpeedSource,PreRefundedEtmcallStatusCode,PreRefundedEtmdate,PreRefundedEtmprice,PreviousCouponDate,PreviousPrincipalPaymentDate,PriceProviderCode,PriceUnitCode,PricingFrequencyCode,PricingInstrumentCode,PrimarySecurityCurrencyCode,PrincipalLosses,PrincipalPayDelay,ProductTypeCode,ProjectId,ProjectNameCode,PutFeatureCode,PutFrequencyCode,QuotationMode,QuotationTypeCode,RedCode,RedemptionCurrencyCode,RedemptionFrequency,RedemptionValue,ReferenceCpiindex,ReferenceIndexId,ReferencePeriodCode,RegionCode,RelativeIndex,RemarketDate,ResetFrequencyCode,ReutersAssetId,ReutersFactor,ReutersLinnumber,ReutersQuoteId,ReutersRic,RoundLot,SecrestrictionsCode,Security12D3flag,SecurityActivationPrice,SecurityActivationPriceDate,SecurityCountryOfIncorporationCode,SecurityDescription,SecurityLegalName1,SecurityLegalName2,SecurityLegalName3,SecurityLegalName4,SecurityLegalName5,SecurityLegalName6,Sedol,Sedol2,Series,SettlementCalendarCode,SettlementCurrencyCode,SettlementTypeCode,SharesOutstanding,SharesOutstandingDate,ShortName,ShortTermMuniType,SinkingFrequencyCode,SinkScheduleAmountType,SinkTypeCode,SixCode,SolvencyIicollateralTypeCode,SourceId,SponsorId,SponsorshipTypeCode,Status,StockExchangeNumber,StockExchangeSecurityCode,StrikePrice,StrikeRate,StripTypeCode,SubAssetGroupCode,SuspectHandlingField1,SuspectHandlingField2,SuspectHandlingField3,SuspectHandlingField4,SuspectHandlingField5,SwapDescription,SwapVersion,SyntheticStructuredProductCode,TaxCountryCode,TelekursFactor,Ticker,TickSize,TickValue,TotalSharesOutstandingAllClasses,TradeCurrencyCode,TradeLotSize,TradePlaceCode,TradingStatus,TrancheClassificationIdcode,TranchePoolTypeCode,TypeOfBondCode,TypeofDebtSecurityCode,UltimateBorrower,UnadjustedFirstCoupon,UnderlyingDescription,UnderlyingGaininstrumentId,UnderlyingUnitsForInterestPayment,UnderlyingId,UnderwriterId,UnitPriceFlag,UsStateCode,ValorNumber,ValueDate,Valueof1Pt,VariableAnnualReturn,VendorInstrumentName,VendorIssuerName,VotingRights,VotingRightsStatusCode,WallStreetOfficeId,Wkn,Wrtcovered,YellowKeyCode,YieldToMaturity,MifidId,LinkedBondOptionalities,LinkedBusinessClassifications,LinkedCouponSchedules,LinkedCustomComponents1,LinkedCustomComponents2,LinkedCustomComponents3,LinkedCustomComponents4,LinkedCustomComponents5,LinkedCustomProperties,LinkedDividendProjectionSchedules,LinkedDividendSchedules,LinkedFactorProjectionsSchedule,LinkedFactorSchedules,LinkedFeesCharges,LinkedInflationsLinked,LinkedLegs,LinkedListings,LinkedMifid,LinkedNames,LinkedPrepaymentSpeeds,LinkedRatings,LinkedRelatedInstitutions,LinkedRelatedInstruments,LinkedSilverCopies,LinkedSinkingSchedules")] Instrument instrument)
    {
      if (ModelState.IsValid)
      {
        _context.Add(instrument);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      return View(instrument);
    }

    // GET: Instruments/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var instrument = await _context.Instruments.FindAsync(id);
      if (instrument == null)
      {
        return NotFound();
      }
      return View(instrument);
    }

    // POST: Instruments/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long id, [Bind("Etag,Id,AbsMbsassetTypeCode,AccruedDaysBetweenCpndates,AccruedInterest,Active,AgeCalculated,AlternativeBbticker,AlternativeCommonCode,AlternativeCusip,AlternativeId1,AlternativeIsin,AlternativeSedol,AmficodeCode,AmountIssuedAccumulating,AmountIssuedOriginal,AmountOutstanding,AmountOutstandingDate,AsOfCoupon,AssetClass,AssetTypeNew,AssimilatedAssetId,AttachmentPoint,BankruptPercentage,BaseCpidate,BaseCpivalue,BaseCurrencyCode,BasicSpread,BbgaccruedBasis,BbgCompositeGlobalId,BbgdataLicenseAssetClassCode,BbgDayCountCode,BbgglobalCompanyId,BbgGlobalId,BbglongTermFundObjectiveCode,BbgpricingMethodCode,BbgprimarySecurityYellowKeyCode,BbgsecurityDescription,BbgSecurityTypeCode,BbgspecificCouponTypeCode,BbgTicker,BbgUniqueId,BemaustraliaId,BenchmarkReferenceId,BissettId,BlackListed,BloombergCode,BloombergCodeInfo,BloombergData,BloombergFactor,BloombergGlobalId,BloombergYellowKeyOverride,BnyMellonId,BondSeries,BovespaTicker,CalendarDayOfCouponPaymentCode,CallablePutableCode,CallDate,CallFeatureCode,CallFrequencyCode,CallPrice,CapitalProtectionCode,CapitalTriggerTypeCode,CashDividendConfirmationDate,Catastrophe,CategoryCode,CertificateUnderlyingTypeCode,CertificationType,Cficode,CharlesRiverId,CiccategoryCode,Ciccode,Cinsid,CloseDate,Cmbstype,Cmoclass,Cmoseries,CollateralCountryCode,CollateralDescriptionCode,CollateralPortfolioCode,CollateralTypeCode,CollateralValue,CommonCode,CompletenessLevelCode,ContractSize,ConversionFixedExchangeRate,ConversionPrice,ConversionRatio,ConversionStartDate,ConversionTypeCode,ConversionUntilDate,ConvertibleExpirationDate,CountryOfDomicileCode,CountryOfGuarantorCode,CountryOfIssueCode,CountryOfListingCode,CountryOfRiskCode,CouponAsOfDate,CouponCurrencyCode,CouponFrequencyCode,CouponRate,CouponTypeCode,CouponTypeResetDate,CreatedBy,CreationDate,CreditEnhancementTypeCode,CurrentCouponPaymentExDividendDate,CurrentNet,CurrentWac,CurrentWam,Cusip,DayCountCode,DefaultCurrency,DefaultDate,Delta,DetachmentPoint,DividendFrequencyCode,DividendIndicated1YearGross,DvdshareTemp,EarlyRedemptionInfo,EquityFundamentalCurrencyCode,Eqydvdtemp,ExchangeCode,ExDividendDays,ExerciseEndDate,ExerciseTypeCode,ExpectedMaturityDate,ExpirationDate,ExpiryDate144A,Factor,FactorEffectiveDate,FactsetIndustryCode,FederallyTaxable,FeedLastUpdateDate,FeedStartRestrictedStatus,FirstCouponPaymentDate,FirstExDividendDate,FirstInterestAccrualDate,FirstPrincipalPayDate,FirstSettleDate,FirstTradeDate,Fisn,FixedCpnvalue,FixedToFloatCouponFrequencyCode,FixedToFloatDayCountCode,FloaterBenchmarkMultiplier,FloaterFormula,FloaterIndex,FloaterSpread,FundAssetClassFocusCode,FundCompanyName,FundGeographicalFocusCode,FundIndustryFocusCode,FundInitialCurrencyCode,FundInvestedInCashAndOthers,FundInvestedInCorpSecurities,FundInvestedInEquitySecurities,FundinvestedinGovernmentSecurities,FundInvestedInMtgeSecurities,FundInvestedInMuniSecurities,FundinvestedinPrefSecurities,FundManagementCompany,FundManagementStyleCode,FundMarketCapFocusCode,FundMaturityFocusCode,FundNavcurrencyCode,FundNavvalue,FundPricingFrequencyCode,FundPricingSource,FundRatingClassFocusCode,FundRedepmtionDate,FundStrategyCode,FundTaxStatus,FundTotalAssets,FundTotalAssetsCurrencyCode,FundTypeCode,FuturesAndOptionsCategoryCode,FuturesFirstDeliveryDate,FuturesFirstNoticeDate,FuturesInitialMarginSpeculator,FuturesLastDeliveryDate,FuturesRollDate,GainId,GainIssuerId,GeographicalZoneCode,GicssubIndustryCode,GlobalAssetClassCode,GlobalAssetTypeCode,Gplusflag,Gplusid,GrossDividend1YearGrowthRate,GrossDividend3YearGrowthRate,Guarantor,Has144AregSrights,HasAlternativeMinimumTax,HasContingentDebt,HasEndAccDateAtMonthEnd,HasInterestCapitalization,HasInterestPayDateAtMonthEnd,HasLocspacode,HasLong1stCoupon,HasMakeWholeCallPossible,HasMortgageIsPaidOff,HasProspective,HasSharesIncluded,HasShort1stCoupon,HasSolvencyIi,IndexLag,IndexLagUnitCode,IndexName,IndexTypeCode,IndexId,InflationIndexPriceFreq,InitialPublicOfferDate,InitialPubOfferSharePrice,InstrumentGroupCode,InstrumentTypeCode,InsurerPercentage,InterestBusinessDayConventionCode,InterestCalculationTypeCode,InterestPaymentMethodCode,InterestShortFall,Ipoprice,Is144A,IsAccumulatingFund,IsAgencyBacked,IsAuctionRate,IsBearerSecurity,IsCallable,IsCalled,IsClosedEndFund,IsContingentConvertible,IsConvertible,IsCouponInDefault,IsCovered,IsCreditLinked,IscurrentGovernmentBond,IsDefaulted,IsDeflationProtected,IsDualCurrency,IsErisa,IsExchangeable,IsFixtoFloat,IsFloater,IsFloattoFix,IsFundOfFunds,IsHybridBond,IsHybridCumulative,IsHybridDeferredPaymentAllowed,Isin,IsIndexInterpolated,IsInflationLinked,IsIrregularCashFlow,IsIslamic,IslamicBondTypeCode,IsMandatoryConversion,IsPartiallyCalled,IsPerpetual,IsPrepaymentStructuredProduct,IsPrivatePlacement,IsPutable,IsRedeeming,IsRegisteredSecurity,IsRegS,IsRemarketed,IsReverseConvertible,IsSecured,IsSenior,IsSinkable,IsStandard,IsStructuredNote,IsSubordinated,IssueCurrencyCode,IssueDate,IssueDescription13F,IssuePrice,IssuerDescription13F,IssuerId,IsSyntheticConvertible,IsSyntheticLoan,IsTaxableBond,IsUnitTraded,IsUnsecured,IsUpdated,IsUssection13F,IsVariable,IGainInstrumentId,IId,LastCallableDate,LastClosePriceDate,LastCouponDate,LastPrice,LastRefixDate,LastTradeDate,LatestSinkingFundFactor,LegalFinalMaturity,LoanFacilityName,LocalExchangeSymbol,LocexpirationDate,Locspapercentage,LongName,MarketCapitalization,MarketStatusCode,MarketTicker,MarkitLxid,MaturityDate,MaturityTypeCode,MbsprodCodeCode,MinimumIncrement,MinimumPurchaseAmount,MinumumTradableAmount,ModifiedDurationInternal,MortgageCollateralTypeCode,MortgageDealTypeCode,MortgageLoanAge,MortgageTrancheTypeCode,MostRecentAccrRtStartDate,MostRecentDefaultDate,MtgeFirstProjectedCashflowDate,MtgeNextPayDatePerSettle,MultipleShares,MunicipalIndustryTypeCode,MunicipalIssueName,MunicipalIssueTypeCode,MunicipalScccode,MunicipalTaxStatusCode,MuniSscClassCodeCode,NaceclassCode,Nacecode,NacedivisionCode,NacegroupCode,NacesectorCode,NameOfProject,NegativeInterest,NetDividend1YearGrowthRate,NetDividend3YearGrowthRate,NextCouponPayDate,NextFactorDate,NextRefixDate,NextSinkAmount,NextSinkingDate,NextSinkingPrice,NominalPaymentDay,NumberOfPositions,NumOfDeferredPaymentsAllowed,Occ21symbol,OpenDate,OptionExoticTypeCode,OptionTypeCode,OriginalNet,OriginalWac,OriginalWam,ParValue,ParValueCurrencyCode,PayDelay,PaymentRankCode,PenultimateCpndate,PercentOfIssue,PerformanceSectorCode,PoolNumber,PoolTypeCode,PositionsAmount,PrepaymentSpeed,PrepaymentSpeedSource,PreRefundedEtmcallStatusCode,PreRefundedEtmdate,PreRefundedEtmprice,PreviousCouponDate,PreviousPrincipalPaymentDate,PriceProviderCode,PriceUnitCode,PricingFrequencyCode,PricingInstrumentCode,PrimarySecurityCurrencyCode,PrincipalLosses,PrincipalPayDelay,ProductTypeCode,ProjectId,ProjectNameCode,PutFeatureCode,PutFrequencyCode,QuotationMode,QuotationTypeCode,RedCode,RedemptionCurrencyCode,RedemptionFrequency,RedemptionValue,ReferenceCpiindex,ReferenceIndexId,ReferencePeriodCode,RegionCode,RelativeIndex,RemarketDate,ResetFrequencyCode,ReutersAssetId,ReutersFactor,ReutersLinnumber,ReutersQuoteId,ReutersRic,RoundLot,SecrestrictionsCode,Security12D3flag,SecurityActivationPrice,SecurityActivationPriceDate,SecurityCountryOfIncorporationCode,SecurityDescription,SecurityLegalName1,SecurityLegalName2,SecurityLegalName3,SecurityLegalName4,SecurityLegalName5,SecurityLegalName6,Sedol,Sedol2,Series,SettlementCalendarCode,SettlementCurrencyCode,SettlementTypeCode,SharesOutstanding,SharesOutstandingDate,ShortName,ShortTermMuniType,SinkingFrequencyCode,SinkScheduleAmountType,SinkTypeCode,SixCode,SolvencyIicollateralTypeCode,SourceId,SponsorId,SponsorshipTypeCode,Status,StockExchangeNumber,StockExchangeSecurityCode,StrikePrice,StrikeRate,StripTypeCode,SubAssetGroupCode,SuspectHandlingField1,SuspectHandlingField2,SuspectHandlingField3,SuspectHandlingField4,SuspectHandlingField5,SwapDescription,SwapVersion,SyntheticStructuredProductCode,TaxCountryCode,TelekursFactor,Ticker,TickSize,TickValue,TotalSharesOutstandingAllClasses,TradeCurrencyCode,TradeLotSize,TradePlaceCode,TradingStatus,TrancheClassificationIdcode,TranchePoolTypeCode,TypeOfBondCode,TypeofDebtSecurityCode,UltimateBorrower,UnadjustedFirstCoupon,UnderlyingDescription,UnderlyingGaininstrumentId,UnderlyingUnitsForInterestPayment,UnderlyingId,UnderwriterId,UnitPriceFlag,UsStateCode,ValorNumber,ValueDate,Valueof1Pt,VariableAnnualReturn,VendorInstrumentName,VendorIssuerName,VotingRights,VotingRightsStatusCode,WallStreetOfficeId,Wkn,Wrtcovered,YellowKeyCode,YieldToMaturity,MifidId,LinkedBondOptionalities,LinkedBusinessClassifications,LinkedCouponSchedules,LinkedCustomComponents1,LinkedCustomComponents2,LinkedCustomComponents3,LinkedCustomComponents4,LinkedCustomComponents5,LinkedCustomProperties,LinkedDividendProjectionSchedules,LinkedDividendSchedules,LinkedFactorProjectionsSchedule,LinkedFactorSchedules,LinkedFeesCharges,LinkedInflationsLinked,LinkedLegs,LinkedListings,LinkedMifid,LinkedNames,LinkedPrepaymentSpeeds,LinkedRatings,LinkedRelatedInstitutions,LinkedRelatedInstruments,LinkedSilverCopies,LinkedSinkingSchedules")] Instrument instrument)
    {
      if (id != instrument.Id)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(instrument);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!InstrumentExists(instrument.Id))
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
      return View(instrument);
    }

    // GET: Instruments/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var instrument = await _context.Instruments
          .FirstOrDefaultAsync(m => m.Id == id);
      if (instrument == null)
      {
        return NotFound();
      }

      _context.Remove(instrument);
      await _context.SaveChangesAsync();

      return View(instrument);
    }

    // POST: Instruments/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
      var instrument = await _context.Instruments.FindAsync(id);
      _context.Instruments.Remove(instrument);
      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(Index));
    }

    private bool InstrumentExists(long id)
    {
      return _context.Instruments.Any(e => e.Id == id);
    }
  }
}
