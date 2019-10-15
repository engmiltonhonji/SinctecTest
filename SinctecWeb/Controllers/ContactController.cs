using SinctecWeb.Context;
using SinctecWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinctecWeb.Controllers
{
    public class ContactController : Controller
    {

        //Instance the SinctecContext
        private SinctecContext db = new SinctecContext();

        // GET: Contact
        public ActionResult Index()
        {
            //return the List of Contact. 
            //After explication will to view that will return.
            return View(db.Contact.ToList());
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            try
            {
                //If IsValid
                if (ModelState.IsValid) {
                    db.Contact.Add(contact);
                    db.SaveChanges();
                }
                //Before alter infommations saves the changes
                return RedirectToAction("Index");
            }

            catch
            {
                return View(contact);
                return RedirectToAction("Index");
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contact/Edit/5
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

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact/Delete/5
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
