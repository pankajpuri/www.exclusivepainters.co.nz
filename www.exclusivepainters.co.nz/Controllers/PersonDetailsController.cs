using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using www.exclusivepainters.co.nz.Models;

namespace www.exclusivepainters.co.nz.Controllers
{
    public class PersonDetailsController : Controller
    {
        private ExPaintersDbEntities3 db = new ExPaintersDbEntities3();

        // GET: PersonDetails
        public ActionResult Index()
        {
            var personDetails = db.PersonDetails.Include(p => p.Address).Include(p => p.Register);
            return View(personDetails.ToList());
        }

        // GET: PersonDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonDetail personDetail = db.PersonDetails.Find(id);
            if (personDetail == null)
            {
                return HttpNotFound();
            }
            return View(personDetail);
        }

        // GET: PersonDetails/Create
        public ActionResult Create()
        {
            ViewBag.AddressId = new SelectList(db.Addresses, "Id", "FlatUnit");
            ViewBag.RegisterId = new SelectList(db.Registers, "Id", "FirstName");
            return View();
        }

        // POST: PersonDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AddressId,RegisterId")] PersonDetail personDetail)
        {
            if (ModelState.IsValid)
            {
                db.PersonDetails.Add(personDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personDetail);
        }

        // GET: PersonDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonDetail personDetail = db.PersonDetails.Find(id);
            if (personDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.AddressId = new SelectList(db.Addresses, "Id", "FlatUnit", personDetail.AddressId);
            ViewBag.RegisterId = new SelectList(db.Registers, "Id", "FirstName", personDetail.RegisterId);
            return View(personDetail);
        }

        // POST: PersonDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AddressId,RegisterId")] PersonDetail personDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AddressId = new SelectList(db.Addresses, "Id", "FlatUnit", personDetail.AddressId);
            ViewBag.RegisterId = new SelectList(db.Registers, "Id", "FirstName", personDetail.RegisterId);
            return View(personDetail);
        }

        // GET: PersonDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonDetail personDetail = db.PersonDetails.Find(id);
            if (personDetail == null)
            {
                return HttpNotFound();
            }
            return View(personDetail);
        }

        // POST: PersonDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonDetail personDetail = db.PersonDetails.Find(id);
            db.PersonDetails.Remove(personDetail);
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
