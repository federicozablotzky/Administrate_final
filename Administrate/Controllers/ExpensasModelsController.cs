 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Administrate.Models;

namespace Administrate.Controllers
{
    public class ExpensasModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ExpensasModels
        public async Task<ActionResult> Index()
        {
            return View(await db.ExpensasModels.ToListAsync());
        }

        // GET: ExpensasModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpensasModel expensasModel = await db.ExpensasModels.FindAsync(id);
            if (expensasModel == null)
            {
                return HttpNotFound();
            }
            return View(expensasModel);
        }

        // GET: ExpensasModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExpensasModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID")] ExpensasModel expensasModel)
        {
            if (ModelState.IsValid)
            {
                db.ExpensasModels.Add(expensasModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(expensasModel);
        }

        // GET: ExpensasModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpensasModel expensasModel = await db.ExpensasModels.FindAsync(id);
            if (expensasModel == null)
            {
                return HttpNotFound();
            }
            return View(expensasModel);
        }

        // POST: ExpensasModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID")] ExpensasModel expensasModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expensasModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(expensasModel);
        }

        // GET: ExpensasModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpensasModel expensasModel = await db.ExpensasModels.FindAsync(id);
            if (expensasModel == null)
            {
                return HttpNotFound();
            }
            return View(expensasModel);
        }

        // POST: ExpensasModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ExpensasModel expensasModel = await db.ExpensasModels.FindAsync(id);
            db.ExpensasModels.Remove(expensasModel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
