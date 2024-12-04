using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebSQLiteSample.Data;
using WebSQLiteSample.Models;

namespace WebSQLiteSample.Controllers
{
    public class JobDatasController : Controller
    {
        private readonly WebSQLiteSampleContext _context;

        public JobDatasController(WebSQLiteSampleContext context)
        {
            _context = context;
        }

        // GET: JobDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobData.ToListAsync());
        }

        // GET: JobDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobData = await _context.JobData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobData == null)
            {
                return NotFound();
            }

            return View(jobData);
        }

        // GET: JobDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Prefecture,Occupation")] JobData jobData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobData);
        }

        // GET: JobDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobData = await _context.JobData.FindAsync(id);
            if (jobData == null)
            {
                return NotFound();
            }
            return View(jobData);
        }

        // POST: JobDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Prefecture,Occupation")] JobData jobData)
        {
            if (id != jobData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobDataExists(jobData.Id))
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
            return View(jobData);
        }

        // GET: JobDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobData = await _context.JobData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobData == null)
            {
                return NotFound();
            }

            return View(jobData);
        }

        // POST: JobDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobData = await _context.JobData.FindAsync(id);
            if (jobData != null)
            {
                _context.JobData.Remove(jobData);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobDataExists(int id)
        {
            return _context.JobData.Any(e => e.Id == id);
        }
    }
}
