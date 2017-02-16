using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Administrate.Models
{
    public class BuildingModelsController : Controller
    {
      
        private ApplicationDbContext dbcont = new ApplicationDbContext();
        // GET: BuildingModels
        public ActionResult Index()
        {
            return View(dbcont.Buildings.ToList());
        }

        // GET: BuildingModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuildingModel buildingModel = dbcont.Buildings.Find(id);
            if (buildingModel == null)
            {
                return HttpNotFound();
            }
            return View(buildingModel);
        }

        // GET: BuildingModels/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // POST: BuildingModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
    
        public ActionResult Create([Bind(Include = "ID,Cuit,Telephone,Address,Category,Administrador")]BuildingModel buildingModel)
        {
            if (ModelState.IsValid)
            {
              dbcont.Buildings.Add(buildingModel);

                dbcont.SaveChanges();
                return View("~/Views/Manage/Index.cshtml");
            }

            return View(buildingModel);
        }

        // GET: BuildingModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BuildingModel buildingModel = dbcont.Buildings.Find(id);
     
          //  BuildingModel buildingModel = dbcont.Buildings.Find(id);
            if (buildingModel == null)
            {
                return HttpNotFound();
            }
            return View(buildingModel);
        }

        // POST: BuildingModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BuildingID,Cuit,Telephone,Address,Category,Identity_ID")] BuildingModel buildingModel)
        {
            if (ModelState.IsValid)
            {
                dbcont.Entry(buildingModel).State = EntityState.Modified;
                dbcont.SaveChanges();
                return RedirectToAction("Index","Manage");
            }
            return View(buildingModel);
        }

        // GET: BuildingModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuildingModel buildingModel = dbcont.Buildings.Find(id);
            if (buildingModel == null)
            {
                return HttpNotFound();
            }
            return View(buildingModel);
        }

        // POST: BuildingModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BuildingModel buildingModel = dbcont.Buildings.Find(id);
            
             dbcont.Buildings.Remove(buildingModel);
            dbcont.SaveChanges();
            return RedirectToAction("Index", "Manage");
        }

          //
        // GET: /Buildings/BuildingsByAdmin

        public ActionResult DepartmentByBuilding(int? Id)
        {

            BuildingModel buildin =  dbcont.Buildings.Find(Id);


            return PartialView("~/Views/Departament/Index.cshtml", buildin.Departments);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbcont.Dispose();
            }
            base.Dispose(disposing);
        }



    }
}
