using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using faskion.Data;
using faskion.Models;

namespace faskion.Controllers
{
    public class CapsulesController : Controller
    {
        private faskionContext db = new faskionContext();

        // GET: Capsules
        public ActionResult Index()
        {
            return View(db.Capsules.ToList());
        }

        // GET: Capsules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Capsule capsule = db.Capsules.Find(id);
            if (capsule == null)
            {
                return HttpNotFound();
            }
            return View(capsule);
        }

        // GET: Capsules/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Capsules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CapsuleId,capsuleCategory,capsuleStill")] Capsule capsule)
        {
            if (ModelState.IsValid)
            {
                db.Capsules.Add(capsule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(capsule);
        }

        // GET: Capsules/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Capsule capsule = db.Capsules.Find(id);
            if (capsule == null)
            {
                return HttpNotFound();
            }
            return View(capsule);
        }

        // POST: Capsules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CapsuleId,capsuleCategory,capsuleStill")] Capsule capsule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(capsule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(capsule);
        }

        // GET: Capsules/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Capsule capsule = db.Capsules.Find(id);
            if (capsule == null)
            {
                return HttpNotFound();
            }
            return View(capsule);
        }

        // POST: Capsules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Capsule capsule = db.Capsules.Find(id);
            db.Capsules.Remove(capsule);
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
