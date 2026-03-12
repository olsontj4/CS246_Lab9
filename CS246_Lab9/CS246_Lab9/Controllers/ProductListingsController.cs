using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CS246_Lab9.Data;
using CS246_Lab9.Models;

namespace CS246_Lab9.Controllers
{
    public class ProductListingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductListingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductListings
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductListings.ToListAsync());
        }

        // GET: ProductListings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productListing = await _context.ProductListings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productListing == null)
            {
                return NotFound();
            }

            return View(productListing);
        }

        // GET: ProductListings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductListings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,Details,Category,IsVisible")] ProductListing productListing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productListing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productListing);
        }

        // GET: ProductListings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productListing = await _context.ProductListings.FindAsync(id);
            if (productListing == null)
            {
                return NotFound();
            }
            return View(productListing);
        }

        // POST: ProductListings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductId,Details,Category,IsVisible")] ProductListing productListing)
        {
            if (id != productListing.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productListing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductListingExists(productListing.Id))
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
            return View(productListing);
        }

        // GET: ProductListings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productListing = await _context.ProductListings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productListing == null)
            {
                return NotFound();
            }

            return View(productListing);
        }

        // POST: ProductListings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productListing = await _context.ProductListings.FindAsync(id);
            if (productListing != null)
            {
                _context.ProductListings.Remove(productListing);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductListingExists(int id)
        {
            return _context.ProductListings.Any(e => e.Id == id);
        }
    }
}
