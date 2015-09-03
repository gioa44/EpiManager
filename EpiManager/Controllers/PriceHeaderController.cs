using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EpiManager.DAL;
using EpiManager.Models;

namespace EpiManager.Controllers
{
    public class PriceHeaderController : Controller
    {
        private EpiContext db = new EpiContext();

        // GET: PriceHeader
        public ActionResult Index()
        {
            return View(db.PriceHeader.ToList());
        }

        // GET: PriceHeader/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceHeader priceHeader = db.PriceHeader.Find(id);
            if (priceHeader == null)
            {
                return HttpNotFound();
            }
            return View(priceHeader);
        }

        // GET: PriceHeader/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PriceHeader/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PriceHeaderId,PriceName")] PriceHeader priceHeader)
        {
            if (ModelState.IsValid)
            {
                db.PriceHeader.Add(priceHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(priceHeader);
        }

        // GET: PriceHeader/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceHeader priceHeader = db.PriceHeader.Find(id);
            if (priceHeader == null)
            {
                return HttpNotFound();
            }
            return View(priceHeader);
        }

        // POST: PriceHeader/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PriceHeaderId,PriceName")] PriceHeader priceHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(priceHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(priceHeader);
        }

        // GET: PriceHeader/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceHeader priceHeader = db.PriceHeader.Find(id);
            if (priceHeader == null)
            {
                return HttpNotFound();
            }
            return View(priceHeader);
        }

        // POST: PriceHeader/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PriceHeader priceHeader = db.PriceHeader.Find(id);
            db.PriceHeader.Remove(priceHeader);
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
