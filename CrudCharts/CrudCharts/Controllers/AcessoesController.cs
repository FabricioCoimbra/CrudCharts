using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudCharts.Models;

namespace CrudCharts.Controllers
{
    public class AcessoesController : Controller
    {
        private readonly TreinamentoContext _context;

        public AcessoesController(TreinamentoContext context)
        {
            _context = context;
        }

        // GET: Acessoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Acesso.ToListAsync());
        }

        // GET: Acessoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acesso = await _context.Acesso
                .FirstOrDefaultAsync(m => m.NmPrograma == id);
            if (acesso == null)
            {
                return NotFound();
            }

            return View(acesso);
        }

        // GET: Acessoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Acessoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CdFilial,NmLogin,NmPrograma,DtAtz")] Acesso acesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(acesso);
        }

        // GET: Acessoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acesso = await _context.Acesso.FindAsync(id);
            if (acesso == null)
            {
                return NotFound();
            }
            return View(acesso);
        }

        // POST: Acessoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CdFilial,NmLogin,NmPrograma,DtAtz")] Acesso acesso)
        {
            if (id != acesso.NmPrograma)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcessoExists(acesso.NmPrograma))
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
            return View(acesso);
        }

        // GET: Acessoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acesso = await _context.Acesso
                .FirstOrDefaultAsync(m => m.NmPrograma == id);
            if (acesso == null)
            {
                return NotFound();
            }

            return View(acesso);
        }

        // POST: Acessoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var acesso = await _context.Acesso.FindAsync(id);
            _context.Acesso.Remove(acesso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcessoExists(string id)
        {
            return _context.Acesso.Any(e => e.NmPrograma == id);
        }
    }
}
