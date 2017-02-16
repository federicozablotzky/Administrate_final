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
    public class DepartamentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Departament
        public async Task<ActionResult> Index()
        {
            return View(await db.Departament.ToListAsync());
        }

        // GET: Departament/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DepartamentoModel departamentoModel = await db.Departament.FindAsync(id);
            if (departamentoModel == null)
            {
                return HttpNotFound();
            }
            return View(departamentoModel);
        }

        // GET: Departament/Create
        public ActionResult Create(int? id)
        {
            BuildingModel Building = new BuildingModel();

            Building = db.Buildings.Find(id);

            DepartamentoModel deparment = new DepartamentoModel();
            deparment.Building_ID = Building.BuildingID;

            return View(deparment);
        }

        // POST: Departament/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Floor,DepartmentNumberLetter,Telephone,AreaOfThePropertyCover,HasGarage,Building_ID")] DepartamentoModel departamentoModel)
        {
            if (ModelState.IsValid)
            {
                BuildingModel Building = new BuildingModel();
                Building = db.Buildings.Find(departamentoModel.Building_ID);
                Building.Departments.Add(departamentoModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index", "Manage");
            }

            return View(departamentoModel);
        }

        // GET: Departament/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DepartamentoModel departamentoModel = await db.Departament.FindAsync(id);
            if (departamentoModel == null)
            {
                return HttpNotFound();
            }
            return View(departamentoModel);
        }

        // POST: Departament/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Floor,DepartmentNumberLetter,Telephone,AreaOfThePropertyCover,HasGarage")] DepartamentoModel departamentoModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(departamentoModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index", "Manage");
            }
            return View(departamentoModel);
        }

        // GET: Departament/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DepartamentoModel departamentoModel = await db.Departament.FindAsync(id);
            if (departamentoModel == null)
            {
                return HttpNotFound();
            }
            return View(departamentoModel);
        }

        // POST: Departament/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DepartamentoModel departamentoModel = await db.Departament.FindAsync(id);
            db.Departament.Remove(departamentoModel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Manage");
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
