using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.ViewModels
{
    public class InsureeVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Date of birth is required.")]
        public System.DateTime DateOfBirth { get; set; }

        public int CarYear { get; set; }
        public bool DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public bool CoverageType { get; set; }
        public decimal Quote { get; set; }
        public int IdCar { get; set; }
        public decimal ExtraQuote { get; set; }
        public List<SelectListItem> CarMakes { get; set; }
    }
}