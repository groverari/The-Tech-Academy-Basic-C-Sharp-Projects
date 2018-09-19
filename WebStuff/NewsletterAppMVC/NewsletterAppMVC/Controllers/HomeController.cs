﻿
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string FirstName, string LastName, string EmailAddress)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new Signup();
                    signup.FirstName = FirstName;
                    signup.LastName = LastName;
                    signup.EmailAddress = EmailAddress;

                    db.Signups.Add(signup);
                    db.SaveChanges();
                }
                return View("Success");
            }
           
            
        }
        

    }
}