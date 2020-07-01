using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using If.Itc.Integrations.Web.Context;

namespace If.Itc.Integrations.Web.Controllers
{
    public class ProtocolsController : Controller
    {
        private readonly IntegrationsDbContext _context;

        public ProtocolsController(IntegrationsDbContext context)
        {
            _context = context;
        }

        // GET: Protocols
        public async Task<IActionResult> Index()
        {
            return View(await _context.Protocols.ToListAsync());
        }

        // GET: Protocols/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var protocol = await _context.Protocols
                .FirstOrDefaultAsync(m => m.ProtocolCode == id);
            if (protocol == null)
            {
                return NotFound();
            }

            return View(protocol);
        }

        // GET: Protocols/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Protocols/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProtocolCode,Description")] Protocol protocol)
        {
            if (ModelState.IsValid)
            {
                _context.Add(protocol);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(protocol);
        }

        // GET: Protocols/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var protocol = await _context.Protocols.FindAsync(id);
            if (protocol == null)
            {
                return NotFound();
            }
            return View(protocol);
        }

        // POST: Protocols/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ProtocolCode,Description")] Protocol protocol)
        {
            if (id != protocol.ProtocolCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(protocol);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProtocolExists(protocol.ProtocolCode))
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
            return View(protocol);
        }

        // GET: Protocols/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var protocol = await _context.Protocols
                .FirstOrDefaultAsync(m => m.ProtocolCode == id);
            if (protocol == null)
            {
                return NotFound();
            }

            return View(protocol);
        }

        // POST: Protocols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var protocol = await _context.Protocols.FindAsync(id);
            _context.Protocols.Remove(protocol);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProtocolExists(string id)
        {
            return _context.Protocols.Any(e => e.ProtocolCode == id);
        }
    }
}
