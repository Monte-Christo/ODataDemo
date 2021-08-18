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
    public class InstitutionsController : Controller
    {
        private readonly ODataContext _context;

        public InstitutionsController(ODataContext context)
        {
            _context = context;
        }

        // GET: Institutions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Institutions.ToListAsync());
        }

        // GET: Institutions/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institution = await _context.Institutions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (institution == null)
            {
                return NotFound();
            }

            return View(institution);
        }

        // GET: Institutions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Institutions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Etag,Id,ActiveFlag,Address,AmficodeCode,Attention,BbgcompanyParentRelationshipCode,BbgglobalCompanyId,BbgglobalUltimateParentCompanyId,BbgidglobalParentCompany,BbgissuerNameType,BbglegalFormCode,BbgparentId,BbgultimateParentId,BicindustryGroupCode,BicindustrySectorCode,BicindustrySubgroupCode,City,CompanyDescription,CompanyUrl,CountryAddressCode,CountryOfDomicileCode,CountryOfIncorporationCode,CountryOfRiskCode,CreatedBy,CreationDate,CustomerActiveIssues,CustomerInstitutionNotes,CustomerIssuerTypeCode,CustomerRecordTypeCode,Ekn,ExchangeSymbol,FactsetIndustryCodeCode,Fax,FiscalYearEnd,FitchIssuerLongTermRatingCode,FitchIssuerLongTermRatingDate,GainId,GicsGroupCode,GicsIndustryCode,GicsSectorCode,GicsSubIndustryCode,GkNumber,IdBbcompany,IdcorgId,ImmediateParentId,IndustryGroupCode,IndustrySectorCode,IndustrySubgroupCode,InstitutionRoleCode,InstitutionUpdatedDate,InternalInstitutionId,IsLinkedtoInstrument,IsUltimateParent,IsUpdated,IGainInstitutionId,IId,JcrforeignCcyLongTermIssuerRatingCode,JcrforeignCcyLongTermIssuerRatingDate,JcrissuerLongTermRatingCode,JcrissuerLongTermRatingDate,JcrlocalCcyLongTermIssuerRatingCode,JcrlocalCcyLongTermIssuerRatingDate,LegalEntityCode,LegalEntityTypeCode,LegalFormCode,LeiassignedDate,LeidisabledDate,LeientityStatusCode,Leiid,LeilastUpdate,LeilegalForm,LeiregistrationAddress,LocalIssuerId,LongName,MarcissuerLongTermRatingCode,MarcissuerLongTermRatingDate,MoodyIssuerLongTermRatingCode,MoodyIssuerLongTermRatingDate,Name,OldUltimateParentId,Phone,PrevTwelveDthreeFlag,PrevTwelveDthreeLockedFlag,RambissuerLongTermRatingCode,RambissuerLongTermRatingDate,RedCode,ReutersOrgId,RidomesticCcyIssuerRatingCode,RidomesticCcyIssuerRatingDate,RifcissuerRatingCode,RifcissuerRatingDate,RiissuerRatingCode,RiissuerRatingDate,ShortName,SpissuerLongTermRatingCode,SpissuerLongTermRatingDate,StateOfDomicileCode,StateOfIncorporationCode,StateProvinceAddress,TotalSharesOutChangedate,TotalSharesOutstanding,TotalSharesOutstandingDate,TotalSharesOutValue,TwelveDthreeChangedDate,TwelveDthreeFlag,TwelveDthreeFlagChangedBy,TwelveDthreeLockedFlag,TwelveDthreeReviewedDate,UltimateParentChangeDate,UltimateParentLock,UltimateParentId,LinkedBusinessClassifications,LinkedCustomProperties,LinkedNames,LinkedRatings,LinkedRelatedInstitutions,LinkedSilverCopies,LinkedSwifts,LinkedTargetSystems")] Institution institution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(institution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(institution);
        }

        // GET: Institutions/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institution = await _context.Institutions.FindAsync(id);
            if (institution == null)
            {
                return NotFound();
            }
            return View(institution);
        }

        // POST: Institutions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Etag,Id,ActiveFlag,Address,AmficodeCode,Attention,BbgcompanyParentRelationshipCode,BbgglobalCompanyId,BbgglobalUltimateParentCompanyId,BbgidglobalParentCompany,BbgissuerNameType,BbglegalFormCode,BbgparentId,BbgultimateParentId,BicindustryGroupCode,BicindustrySectorCode,BicindustrySubgroupCode,City,CompanyDescription,CompanyUrl,CountryAddressCode,CountryOfDomicileCode,CountryOfIncorporationCode,CountryOfRiskCode,CreatedBy,CreationDate,CustomerActiveIssues,CustomerInstitutionNotes,CustomerIssuerTypeCode,CustomerRecordTypeCode,Ekn,ExchangeSymbol,FactsetIndustryCodeCode,Fax,FiscalYearEnd,FitchIssuerLongTermRatingCode,FitchIssuerLongTermRatingDate,GainId,GicsGroupCode,GicsIndustryCode,GicsSectorCode,GicsSubIndustryCode,GkNumber,IdBbcompany,IdcorgId,ImmediateParentId,IndustryGroupCode,IndustrySectorCode,IndustrySubgroupCode,InstitutionRoleCode,InstitutionUpdatedDate,InternalInstitutionId,IsLinkedtoInstrument,IsUltimateParent,IsUpdated,IGainInstitutionId,IId,JcrforeignCcyLongTermIssuerRatingCode,JcrforeignCcyLongTermIssuerRatingDate,JcrissuerLongTermRatingCode,JcrissuerLongTermRatingDate,JcrlocalCcyLongTermIssuerRatingCode,JcrlocalCcyLongTermIssuerRatingDate,LegalEntityCode,LegalEntityTypeCode,LegalFormCode,LeiassignedDate,LeidisabledDate,LeientityStatusCode,Leiid,LeilastUpdate,LeilegalForm,LeiregistrationAddress,LocalIssuerId,LongName,MarcissuerLongTermRatingCode,MarcissuerLongTermRatingDate,MoodyIssuerLongTermRatingCode,MoodyIssuerLongTermRatingDate,Name,OldUltimateParentId,Phone,PrevTwelveDthreeFlag,PrevTwelveDthreeLockedFlag,RambissuerLongTermRatingCode,RambissuerLongTermRatingDate,RedCode,ReutersOrgId,RidomesticCcyIssuerRatingCode,RidomesticCcyIssuerRatingDate,RifcissuerRatingCode,RifcissuerRatingDate,RiissuerRatingCode,RiissuerRatingDate,ShortName,SpissuerLongTermRatingCode,SpissuerLongTermRatingDate,StateOfDomicileCode,StateOfIncorporationCode,StateProvinceAddress,TotalSharesOutChangedate,TotalSharesOutstanding,TotalSharesOutstandingDate,TotalSharesOutValue,TwelveDthreeChangedDate,TwelveDthreeFlag,TwelveDthreeFlagChangedBy,TwelveDthreeLockedFlag,TwelveDthreeReviewedDate,UltimateParentChangeDate,UltimateParentLock,UltimateParentId,LinkedBusinessClassifications,LinkedCustomProperties,LinkedNames,LinkedRatings,LinkedRelatedInstitutions,LinkedSilverCopies,LinkedSwifts,LinkedTargetSystems")] Institution institution)
        {
            if (id != institution.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(institution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstitutionExists(institution.Id))
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
            return View(institution);
        }

        // GET: Institutions/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institution = await _context.Institutions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (institution == null)
            {
                return NotFound();
            }

            return View(institution);
        }

        // POST: Institutions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var institution = await _context.Institutions.FindAsync(id);
            _context.Institutions.Remove(institution);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstitutionExists(long id)
        {
            return _context.Institutions.Any(e => e.Id == id);
        }
    }
}
