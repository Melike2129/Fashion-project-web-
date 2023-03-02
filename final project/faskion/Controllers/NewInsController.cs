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
    public class NewInsController : Controller
    {
        private faskionContext db = new faskionContext();

        // GET: NewIns
        public ActionResult Index()
        {
            return View(db.NewIns.ToList());
        }

        // GET: NewIns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewIn newIn = db.NewIns.Find(id);
            if (newIn == null)
            {
                return HttpNotFound();
            }
            return View(newIn);
        }

        // GET: NewIns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewIns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NewInId,fabric_type,color,newIn_title")] NewIn newIn)
        {
            if (ModelState.IsValid)
            {
                db.NewIns.Add(newIn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newIn);
        }

        // GET: NewIns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewIn newIn = db.NewIns.Find(id);
            if (newIn == null)
            {
                return HttpNotFound();
            }
            return View(newIn);
        }

        // POST: NewIns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NewInId,fabric_type,color,newIn_title")] NewIn newIn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newIn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newIn);
        }

        // GET: NewIns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewIn newIn = db.NewIns.Find(id);
            if (newIn == null)
            {
                return HttpNotFound();
            }
            return View(newIn);
        }

        // POST: NewIns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewIn newIn = db.NewIns.Find(id);
            db.NewIns.Remove(newIn);
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
