using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;
using Newtonsoft.Json;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
       private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
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

        // GET: Insuree/Create
        public ActionResult Create()
        {
            var insureevm = new InsureeVM();
            insureevm.Quote = 50;
            insureevm.DateOfBirth = DateTime.Now;
            insureevm.CarMakes = getCarMakes();
            return View(insureevm);
        }

        private List<SelectListItem> getCarMakes()
        {
            var carMakes = new List<SelectListItem>();
            foreach (Car auxCar in db.Cars.OrderBy(n => n.Model).ToList())
            {
                carMakes.Add(new SelectListItem() {
                    Text = string.Concat(auxCar.Model, " (", db.Car_Makes.Where(x => x.IdCarMake == auxCar.IdCarMake).FirstOrDefault().Make, ")"),
                    Value = auxCar.IdCar.ToString(), Selected = false 
                });
            }
            return carMakes;
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,DUI,SpeedingTickets,CoverageType,Quote,IdCar,ExtraQuote")] InsureeVM insureevm)
        {
            if (ModelState.IsValid)
            {
                
                //db.Insurees.Add(insuree);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insureevm);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        [HttpGet]
        public ActionResult ExtraQuoteVehicle(int idCar)
        {
            List<Car> cars = db.Cars.Where(x => x.IdCar == idCar).ToList();
            if (cars.Count == 1)
            {
                return Json(new { Success = "true", Data = new { extraQuote = cars[0].extraQuote } }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Success = "true", Data = new { extraQuote = 0 } }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetTotalQuote(string jsonInput)
        {
            try
            {
                //JsonResult jsonResult = new JsonResult();
                string data = "";
                ParametersQuoteJsonVM parametersJson = JsonConvert.DeserializeObject<ParametersQuoteJsonVM>(jsonInput);
                ParametersQuoteVM parameters = new ParametersQuoteVM(parametersJson);
                FinalQuoteVM finalQuote = new FinalQuoteVM();

                finalQuote.quoteMonthly = 0;
                finalQuote.quoteByAge = 0;
                finalQuote.quoteByCarYear = 0;
                finalQuote.quoteBySpeedingTickets = (parameters.SpeedingTickets > 0 ? (parameters.SpeedingTickets * 10) : 0);
                finalQuote.quoteByDUI = 0;
                finalQuote.quoteByCoverageTotal = 0;
                finalQuote.quoteByCarModel = parameters.ExtraQuote;

                int age = DateTime.Today.AddTicks(parameters.DateOfBirth.Ticks * -1).Year - 1;
                if (age <= 18)
                {
                    finalQuote.quoteByAge = 100;
                }
                else if (age >= 19 && age <= 25)
                {
                    finalQuote.quoteByAge = 50;
                }
                else
                {
                    finalQuote.quoteByAge = 25;
                }

                if (parameters.CarYear < 2000 || parameters.CarYear > 2015)
                {
                    finalQuote.quoteByCarYear = 25;
                }

                finalQuote.quoteMonthly = finalQuote.quoteByAge + finalQuote.quoteByCarYear + finalQuote.quoteBySpeedingTickets + finalQuote.quoteByCarModel;
                if (parameters.DUI == true)
                {
                    finalQuote.quoteByDUI = Decimal.Multiply(finalQuote.quoteMonthly, 0.25M);
                    finalQuote.quoteMonthly += finalQuote.quoteByDUI;
                }
                if (parameters.CoverageType == true)
                {
                    finalQuote.quoteByCoverageTotal = Decimal.Multiply(finalQuote.quoteMonthly, 0.5M);
                    finalQuote.quoteMonthly += finalQuote.quoteByCoverageTotal;
                }

                //data = "{ \"Success\":\"true\", \"Data\":{ " +
                //    "\"quoteMonthly\":\"" + finalQuote.quoteMonthly + "\", " +
                //    "\"quoteByAge\":\"" + finalQuote.quoteByAge + "\", " +
                //    "\"quoteByCarYear\":\"" + finalQuote.quoteByCarYear + "\", " +
                //    "\"quoteBySpeedingTickets\":\"" + finalQuote.quoteBySpeedingTickets + "\", " +
                //    "\"quoteByCarModel\":\"" + finalQuote.quoteExtra + "\", " +
                //    "\"quoteByDUI\":\"" + finalQuote.quoteByDUI + "\", " +
                //    "\"quoteByCoverageTotal\":\"" + finalQuote.quoteByCoverageTotal + "\" } }";
                //return this.Json(JsonConvert.SerializeObject(data), JsonRequestBehavior.AllowGet);
                return Json(finalQuote, JsonRequestBehavior.AllowGet);


                //return Json(new
                //{
                //    Success = "true",
                //    Data = new
                //    {
                //        quoteMonthly = quoteMonthly,
                //        quoteByAge = quoteByAge,
                //        quoteByCarYear = quoteByCarYear,
                //        quoteBySpeedingTickets = quoteBySpeedingTickets,
                //        quoteByCarModel = parameters.ExtraQuote,
                //        quoteByDUI = quoteByDUI,
                //        quoteByCoverageTotal = quoteByCoverageTotal
                //    }
                //}, JsonRequestBehavior.AllowGet); ;
            }catch (Exception ex)
            {
                return Json(new { Success = "false" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
