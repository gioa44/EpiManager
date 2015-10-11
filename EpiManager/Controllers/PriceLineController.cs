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
    public class PriceLineController : Controller
    {
        private EpiContext db = new EpiContext();

        // GET: PriceLine
        public ActionResult Index()
        {
            var priceLines = db.PriceLines.Include(p => p.PriceHeader);
            return View(priceLines.ToList());
        }

        // GET: PriceLine/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceLine priceLine = db.PriceLines.Find(id);
            if (priceLine == null)
            {
                return HttpNotFound();
            }
            return View(priceLine);
        }

        // GET: PriceLine/Create
        public ActionResult Create()
        {
            ViewBag.PriceHeaderId = new SelectList(db.PriceHeaders, "PriceHeaderId", "PriceName");
            return View();
        }

        // POST: PriceLine/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PriceHeaderId,BodyPartId,Price")] PriceLine priceLine)
        {
            if (ModelState.IsValid)
            {
                db.PriceLines.Add(priceLine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PriceHeaderId = new SelectList(db.PriceHeaders, "PriceHeaderId", "PriceName", priceLine.PriceHeaderId);
            return View(priceLine);
        }

        // GET: PriceLine/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceLine priceLine = db.PriceLines.Find(id);
            if (priceLine == null)
            {
                return HttpNotFound();
            }
            ViewBag.PriceHeaderId = new SelectList(db.PriceHeaders, "PriceHeaderId", "PriceName", priceLine.PriceHeaderId);
            return View(priceLine);
        }

        // POST: PriceLine/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PriceHeaderId,BodyPartId,Price")] PriceLine priceLine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(priceLine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PriceHeaderId = new SelectList(db.PriceHeaders, "PriceHeaderId", "PriceName", priceLine.PriceHeaderId);
            return View(priceLine);
        }

        // GET: PriceLine/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceLine priceLine = db.PriceLines.Find(id);
            if (priceLine == null)
            {
                return HttpNotFound();
            }
            return View(priceLine);
        }

        // POST: PriceLine/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PriceLine priceLine = db.PriceLines.Find(id);
            db.PriceLines.Remove(priceLine);
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
