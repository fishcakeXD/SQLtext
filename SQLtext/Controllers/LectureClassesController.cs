using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SQLtext.Models;

namespace SQLtext.Controllers
{
    public class LectureClassesController : Controller
    {
        private readonly longtermcareContext _context;

        public LectureClassesController(longtermcareContext context)
        {
            _context = context;
        }

        // GET: LectureClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.LectureClasses.ToListAsync());
        }

        // GET: LectureClasses/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lectureClass = await _context.LectureClasses
                .FirstOrDefaultAsync(m => m.SchWeek == id);
            if (lectureClass == null)
            {
                return NotFound();
            }

            return View(lectureClass);
        }

        // GET: LectureClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SchWeek,SchAm,SchPm")] LectureClass lectureClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lectureClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lectureClass);
        }

        // GET: LectureClasses/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lectureClass = await _context.LectureClasses.FindAsync(id);
            if (lectureClass == null)
            {
                return NotFound();
            }
            return View(lectureClass);
        }

        // POST: LectureClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("SchWeek,SchAm,SchPm")] LectureClass lectureClass)
        {
            if (id != lectureClass.SchWeek)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lectureClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LectureClassExists(lectureClass.SchWeek))
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
            return View(lectureClass);
        }

        // GET: LectureClasses/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lectureClass = await _context.LectureClasses
                .FirstOrDefaultAsync(m => m.SchWeek == id);
            if (lectureClass == null)
            {
                return NotFound();
            }

            return View(lectureClass);
        }

        // POST: LectureClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lectureClass = await _context.LectureClasses.FindAsync(id);
            _context.LectureClasses.Remove(lectureClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LectureClassExists(string id)
        {
            return _context.LectureClasses.Any(e => e.SchWeek == id);
        }
    }
}
