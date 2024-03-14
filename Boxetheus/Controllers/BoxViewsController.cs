﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Boxetheus.Data;
using Boxetheus.Models;

namespace Boxetheus.Controllers
{
    public class BoxViewsController : Controller
    {
        private readonly BoxetheusContext _context;

        public BoxViewsController(BoxetheusContext context)
        {
            _context = context;
        }

        // GET: BoxViews
        public async Task<IActionResult> Index()
        {
            return View(await _context.BoxView.ToListAsync());
        }

        // GET: BoxViews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boxView = await _context.BoxView
                .FirstOrDefaultAsync(m => m.Id == id);
            if (boxView == null)
            {
                return NotFound();
            }

            return View(boxView);
        }

        // GET: BoxViews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BoxViews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,OrderDate,Category,Design,Shape,Size,Quantity,Price")] BoxView boxView)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boxView);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boxView);
        }

        // GET: BoxViews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boxView = await _context.BoxView.FindAsync(id);
            if (boxView == null)
            {
                return NotFound();
            }
            return View(boxView);
        }

        // POST: BoxViews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,OrderDate,Category,Design,Shape,Size,Quantity,Price")] BoxView boxView)
        {
            if (id != boxView.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boxView);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoxViewExists(boxView.Id))
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
            return View(boxView);
        }

        // GET: BoxViews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boxView = await _context.BoxView
                .FirstOrDefaultAsync(m => m.Id == id);
            if (boxView == null)
            {
                return NotFound();
            }

            return View(boxView);
        }

        // POST: BoxViews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boxView = await _context.BoxView.FindAsync(id);
            if (boxView != null)
            {
                _context.BoxView.Remove(boxView);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoxViewExists(int id)
        {
            return _context.BoxView.Any(e => e.Id == id);
        }
    }
}
