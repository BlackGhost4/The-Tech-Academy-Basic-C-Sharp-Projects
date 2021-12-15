using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Admin
        public ActionResult Index()
        {
            List<QuoteIssued> quotesIssued = new List<QuoteIssued>();
            //using (InsuranceEntities db = new InsuranceEntities())
            //{
                var insurees = (from c in db.Insurees
                               select c).ToList();
                foreach (Insuree insuree in insurees)
                {
                    var quoteIssued = new QuoteIssued();
                    quoteIssued.Id = insuree.Id;
                    quoteIssued.FirstName = insuree.FirstName;
                    quoteIssued.LastName = insuree.LastName;
                    quoteIssued.EmailAddres = insuree.EmailAddress;
                    quoteIssued.Quote = insuree.Quote;
                    quotesIssued.Add(quoteIssued);
                }
            //}
            return View(quotesIssued);
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }
    }
}