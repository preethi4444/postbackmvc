﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using postbackmvc.Models;

namespace postbackmvc.Controllers
{
    public class customerController : Controller
    {
        // GET: customer/Index
        public ActionResult Index()
        {
            using(mvccurdEntities db=new mvccurdEntities())
            {
                return View(db.customerrs.ToList());
            }
            
        }

        // GET: customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: customer/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: customer/Create
        [HttpPost]
        public ActionResult Create(customerr objct)
        {
            try
            {
                // TODO: Add insert logic here
                using(mvccurdEntities db=new mvccurdEntities())
                {
                    db.customerrs.Add(objct);
                    db.SaveChanges();
                   
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: customer/Edit/5
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

        // GET: customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: customer/Delete/5
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
