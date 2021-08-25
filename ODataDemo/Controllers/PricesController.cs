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
    public class PricesController : Controller
    {
        private readonly ODataContext _context;

        public PricesController(ODataContext context)
        {
            _context = context;
        }

        // GET: Prices
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prices.ToListAsync());
        }

        // GET: Prices/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var price = await _context.Prices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (price == null)
            {
                return NotFound();
            }

            return View(price);
        }

        // GET: Prices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Etag,Id,Comment,InvestigationChecksApplied,InvestigationCreationDate,ICurrency,IId,IInstrumentIdentityId,IPricingMethod,IReferencePriceDate,LastModificationTimestamp,MarketId,ModificationReasonCode,PriceSourceInformationFallback,PriceSourceInformationPart1,PriceUnitCode,ProviderCode,ProviderPriceDate,ProviderPriceTime,QuotationMode,QuotationTypeCode,RequestCode,SnapshotTime,Spread,Value,Volume,Yield,LinkedCustomProperties,LinkedSilverCopies")] Price price)
        {
            if (ModelState.IsValid)
            {
                _context.Add(price);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(price);
        }

        // GET: Prices/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var price = await _context.Prices.FindAsync(id);
            if (price == null)
            {
                return NotFound();
            }
            return View(price);
        }

        // POST: Prices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Etag,Id,Comment,InvestigationChecksApplied,InvestigationCreationDate,ICurrency,IId,IInstrumentIdentityId,IPricingMethod,IReferencePriceDate,LastModificationTimestamp,MarketId,ModificationReasonCode,PriceSourceInformationFallback,PriceSourceInformationPart1,PriceUnitCode,ProviderCode,ProviderPriceDate,ProviderPriceTime,QuotationMode,QuotationTypeCode,RequestCode,SnapshotTime,Spread,Value,Volume,Yield,LinkedCustomProperties,LinkedSilverCopies")] Price price)
        {
            if (id != price.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(price);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PriceExists(price.Id))
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
            return View(price);
        }

        // GET: Prices/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var price = await _context.Prices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (price == null)
            {
                return NotFound();
            }

            return View(price);
        }

        // POST: Prices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var price = await _context.Prices.FindAsync(id);
            _context.Prices.Remove(price);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PriceExists(long id)
        {
            return _context.Prices.Any(e => e.Id == id);
        }
    }
}
