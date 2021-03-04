using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShawarmaX.Models;

namespace ShawarmaX.Controllers
{
    [Authorize]
    public class AddShawarmaController : Controller
    {
        private readonly AppDbContext _context;

        public AddShawarmaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AddShawarma
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Shawarmas.Include(s => s.Category);
            return View(await appDbContext.ToListAsync());
        }

        // GET: AddShawarma/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shawarma = await _context.Shawarmas
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shawarma == null)
            {
                return NotFound();
            }

            return View(shawarma);
        }

        // GET: AddShawarma/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId");
            return View();
        }

        // POST: AddShawarma/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ShortDescription,LongDescription,Price,ImageUrl,IsOffer,InStock,CategoryId")] Shawarma shawarma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shawarma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", shawarma.CategoryId);
            return View(shawarma);
        }

        // GET: AddShawarma/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shawarma = await _context.Shawarmas.FindAsync(id);
            if (shawarma == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", shawarma.CategoryId);
            return View(shawarma);
        }

        // POST: AddShawarma/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ShortDescription,LongDescription,Price,ImageUrl,IsOffer,InStock,CategoryId")] Shawarma shawarma)
        {
            if (id != shawarma.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shawarma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShawarmaExists(shawarma.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", shawarma.CategoryId);
            return View(shawarma);
        }

        // GET: AddShawarma/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shawarma = await _context.Shawarmas
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shawarma == null)
            {
                return NotFound();
            }

            return View(shawarma);
        }

        // POST: AddShawarma/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shawarma = await _context.Shawarmas.FindAsync(id);
            _context.Shawarmas.Remove(shawarma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShawarmaExists(int id)
        {
            return _context.Shawarmas.Any(e => e.Id == id);
        }
    }
}
