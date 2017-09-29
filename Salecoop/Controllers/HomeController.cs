using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using Salecoop.Models;
using System.Web.UI;

namespace Salecoop.Controllers
{

    public class HomeController : Controller
    {
        private SalecoopContext db = new SalecoopContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login(string username, string password)
        {
            var Employeesdb = db.Employees.Where(e => e.Username.Equals(username) && e.Password.Equals(password)).FirstOrDefault();
         
                  if (Employeesdb != null)
            {
                Session["UserName"] = Employeesdb.Username.ToString();
                Session["Firstname"] = Employeesdb.Firstname.ToString();
                Session["Lastname"] = Employeesdb.Lastname.ToString();
                if (Session["UserName"].ToString() != null && Session["Firstname"].ToString() != null)
                {

                    return RedirectToAction("Index");
                }
                else if (Session["UserName"].ToString() == null)
                {
                    Session["error"] = "Error";
                    ViewBag.Javascript = "<script language='javascript' type='text/javascript'>alert('เกิดข้อผิดพลาด รหัสผ่านไม่ถูกต้อง!');</script>";
                    return View("Home", "Login");
                }
                
            }
            
           

            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon(); // it will clear the session at the end of request
            Session.Clear();
            return RedirectToAction("index");
        }



    }
   
}