using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NEWHIRES.DAL;

namespace NEWHIRES.Controllers
{
    public class ApplicationInfoController : Controller
    {
        private readonly NHDBContext _context;

        public ApplicationInfoController(NHDBContext context)
        {
            _context = context;
        }

        // GET: ApplicationInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.ApplicationInfo.ToListAsync());
        }

        // GET: ApplicationInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationInfo = await _context.ApplicationInfo
                .FirstOrDefaultAsync(m => m.AppID == id);
            if (applicationInfo == null)
            {
                return NotFound();
            }

            return View(applicationInfo);
        }

        // GET: ApplicationInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ApplicationInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppID,AppDate,AppType,LastName,FirstName,MiddleName,MaidenName,SSN,DateOfBirth,AppStatus")] ApplicationInfo applicationInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(applicationInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(applicationInfo);
        }

        // GET: ApplicationInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationInfo = await _context.ApplicationInfo.FindAsync(id);
            if (applicationInfo == null)
            {
                return NotFound();
            }
            return View(applicationInfo);
        }

        // POST: ApplicationInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppID,AppDate,AppType,LastName,FirstName,MiddleName,MaidenName,SSN,DateOfBirth,AppStatus")] ApplicationInfo applicationInfo)
        {
            if (id != applicationInfo.AppID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicationInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationInfoExists(applicationInfo.AppID))
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
            return View(applicationInfo);
        }

        // GET: ApplicationInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationInfo = await _context.ApplicationInfo
                .FirstOrDefaultAsync(m => m.AppID == id);
            if (applicationInfo == null)
            {
                return NotFound();
            }

            return View(applicationInfo);
        }

        // POST: ApplicationInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var applicationInfo = await _context.ApplicationInfo.FindAsync(id);
            _context.ApplicationInfo.Remove(applicationInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationInfoExists(int id)
        {
            return _context.ApplicationInfo.Any(e => e.AppID == id);
        }
    }
}
