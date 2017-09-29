using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
namespace Salecoop.Models
{
    public class salecoopsController : Controller
    {
        private SalecoopContext db = new SalecoopContext();

        // GET: salecoops
        public ActionResult Index(string movieGenre, string searchString)
        {
            var sale = from m in db.salecoops select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                if (movieGenre == "1")
                {

                    sale = sale.Where(s => s.quotationNo.Contains(searchString));
                }
                else if (movieGenre == "2")
                {
                    sale = sale.Where(s => s.coopName.Contains(searchString));
                }
                else if (movieGenre == "3")
                {
                    sale = sale.Where(s => s.status.Contains(searchString));
                }
                
            }

            return View(sale);
            //return View(db.salecoops.ToList());
        }

        // GET: salecoops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            salecoop salecoop = db.salecoops.Find(id);
            if (salecoop == null)
            {
                return HttpNotFound();
            }
            return View(salecoop);
        }

        // GET: salecoops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: salecoops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idsale,quotationNo,dayindate,useroffer,coopName,sequence,listorder,amount,salepricesumvat,costsumvat,profitaftersale,status")] salecoop salecoop)
        {
            if (ModelState.IsValid)
            {
                db.salecoops.Add(salecoop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salecoop);
        }

        // GET: salecoops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            salecoop salecoop = db.salecoops.Find(id);
            if (salecoop == null)
            {
                return HttpNotFound();
            }
            return View(salecoop);
        }

        // POST: salecoops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idsale,quotationNo,dayindate,useroffer,coopName,sequence,listorder,amount,salepricesumvat,costsumvat,profitaftersale,status")] salecoop salecoop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salecoop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salecoop);
        }

        // GET: salecoops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            salecoop salecoop = db.salecoops.Find(id);
            if (salecoop == null)
            {
                return HttpNotFound();
            }
            return View(salecoop);
        }

        // POST: salecoops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            salecoop salecoop = db.salecoops.Find(id);
            db.salecoops.Remove(salecoop);
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
        public ActionResult Saleprice()
        {

            return View(db.salecoops.ToList());
        }
        public ActionResult ViewSale(string movieGenre, string searchString)
        {
            var sale = from m in db.salecoops select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                if (movieGenre == "1")
                {

                    sale = sale.Where(s => s.dayindate.ToString().Contains(searchString));//แก้จาก datetime เป็น String
                }
                else if (movieGenre == "2")
                {
                    sale = sale.Where(s => s.coopName.Contains(searchString));
                }
                else if (movieGenre == "3")
                {
                    sale = sale.Where(s => s.status.Contains(searchString));
                }
                else if (movieGenre == "4")
                {
                    sale = sale.Where(s => s.listorder.Contains(searchString));
                }
            }

            return View(sale);
        }
    }
}
