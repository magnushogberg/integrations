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
    public class EnvironmentsController : Controller
    {
        private readonly IntegrationsDbContext _context;

        public EnvironmentsController(IntegrationsDbContext context)
        {
            _context = context;
        }

        // GET: Environments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Environments.ToListAsync());
        }

        // GET: Environments/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var environment = await _context.Environments
                .FirstOrDefaultAsync(m => m.EnvironmentCode == id);
            if (environment == null)
            {
                return NotFound();
            }

            return View(environment);
        }

        // GET: Environments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Environments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnvironmentCode,Description")] Context.Environment environment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(environment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(environment);
        }

        // GET: Environments/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var environment = await _context.Environments.FindAsync(id);
            if (environment == null)
            {
                return NotFound();
            }
            return View(environment);
        }

        // POST: Environments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("EnvironmentCode,Description")] Context.Environment environment)
        {
            if (id != environment.EnvironmentCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(environment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnvironmentExists(environment.EnvironmentCode))
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
            return View(environment);
        }

        // GET: Environments/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var environment = await _context.Environments
                .FirstOrDefaultAsync(m => m.EnvironmentCode == id);
            if (environment == null)
            {
                return NotFound();
            }

            return View(environment);
        }

        // POST: Environments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var environment = await _context.Environments.FindAsync(id);
            _context.Environments.Remove(environment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnvironmentExists(string id)
        {
            return _context.Environments.Any(e => e.EnvironmentCode == id);
        }
    }
}
