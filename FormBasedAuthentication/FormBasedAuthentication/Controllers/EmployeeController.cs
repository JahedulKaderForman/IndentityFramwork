using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FormBasedAuthentication;

namespace FormBasedAuthentication.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private OfficeEntities db = new OfficeEntities();

        // GET: /Employee/
        public ActionResult Index()
        {
            return View(db.Empoyee.ToList());
        }

        // GET: /Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empoyee empoyee = db.Empoyee.Find(id);
            if (empoyee == null)
            {
                return HttpNotFound();
            }
            return View(empoyee);
        }

        // GET: /Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,degisnation,salary")] Empoyee empoyee)
        {
            if (ModelState.IsValid)
            {
                db.Empoyee.Add(empoyee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empoyee);
        }

        // GET: /Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empoyee empoyee = db.Empoyee.Find(id);
            if (empoyee == null)
            {
                return HttpNotFound();
            }
            return View(empoyee);
        }

        // POST: /Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,degisnation,salary")] Empoyee empoyee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empoyee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empoyee);
        }

        // GET: /Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empoyee empoyee = db.Empoyee.Find(id);
            if (empoyee == null)
            {
                return HttpNotFound();
            }
            return View(empoyee);
        }

        // POST: /Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empoyee empoyee = db.Empoyee.Find(id);
            db.Empoyee.Remove(empoyee);
            db.SaveChanges();
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
