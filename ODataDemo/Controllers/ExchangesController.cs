﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ODataDemo.Models;

namespace ODataDemo.Controllers
{
    public class ExchangesController : Controller
    {
        private readonly ODataContext _context;

        public ExchangesController(ODataContext context)
        {
            _context = context;
        }

        // GET: Exchanges
        public async Task<IActionResult> Index()
        {
            return View(await _context.Exchanges.ToListAsync());
        }

        // GET: Exchanges/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exchange = await _context.Exchanges
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exchange == null)
            {
                return NotFound();
            }

            return View(exchange);
        }

        // GET: Exchanges/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Exchanges/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Etag,Id,BbgpricingSource,CountryCode,Description,ExchangeTypeCode,HolidayCalendarId,IdcexchangeCode,IGainExchangeId,IId,Mic,Name,ParentExchangeId,SixBcncode,StatusCode,TrexchangeCode,Url,WeekendCode,WmExchangeCode,LinkedCustomProperties,LinkedSilverCopies")] Exchange exchange)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exchange);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exchange);
        }

        // GET: Exchanges/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exchange = await _context.Exchanges.FindAsync(id);
            if (exchange == null)
            {
                return NotFound();
            }
            return View(exchange);
        }

        // POST: Exchanges/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Etag,Id,BbgpricingSource,CountryCode,Description,ExchangeTypeCode,HolidayCalendarId,IdcexchangeCode,IGainExchangeId,IId,Mic,Name,ParentExchangeId,SixBcncode,StatusCode,TrexchangeCode,Url,WeekendCode,WmExchangeCode,LinkedCustomProperties,LinkedSilverCopies")] Exchange exchange)
        {
            if (id != exchange.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exchange);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExchangeExists(exchange.Id))
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
            return View(exchange);
        }

        // GET: Exchanges/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exchange = await _context.Exchanges
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exchange == null)
            {
                return NotFound();
            }

            return View(exchange);
        }

        // POST: Exchanges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var exchange = await _context.Exchanges.FindAsync(id);
            _context.Exchanges.Remove(exchange);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExchangeExists(long id)
        {
            return _context.Exchanges.Any(e => e.Id == id);
        }
    }
}
