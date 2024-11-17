using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.Message = "User profile details page.";
            return View();
        }


        public ActionResult LoginPage()
        {
            return View();
        }


        public ActionResult Dashboard()
        {
            return View();
        }

        // login
        [HttpPost]
        public ActionResult Login(string email, string password)
        {

            if (email != null && email == "nhmarket.com@gmail.com" && password == "1111")
            {

                //Session["email"] = email;
                //RedirectToAction("Index", "User");
                return Json(new { status = "success", email = email, password = password });
            }
            else
            {
                return Json(new {status = "failed" });
            }

            

        }



        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
