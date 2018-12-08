﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RunningSite.Models;

namespace RunningSite.Controllers
{
    public class AccountController : Controller
    {
        DAO dao = new DAO();

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult AddAccount()
        //{
        //    return View("Login");
        //}

        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddAccount(Account visitor)
        {
            int counter = 0;
            counter = dao.EnterAccount(visitor);

            if (counter == 1)
            {
                Response.Write("Welcome to our Marathon Festival");
                ModelState.Clear();
            }
            else
            {
                Response.Write("Error, " + dao.message);
            }

            return View();
        }
    }
}