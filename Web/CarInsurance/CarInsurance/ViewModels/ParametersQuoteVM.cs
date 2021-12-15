using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModels
{
    public class ParametersQuoteVM
    {
        public ParametersQuoteVM(ParametersQuoteJsonVM parameters) {        
            DateOfBirth = DateTime.ParseExact(parameters.DateOfBirth, "MM/dd/yyyy", null);
            CarYear = Convert.ToInt32(parameters.CarYear);
            SpeedingTickets = Convert.ToInt32(parameters.SpeedingTickets);
            DUI = (parameters.DUI == "true" ? true : false);
            CoverageType = (parameters.CoverageType == "true" ? true : false);
            ExtraQuote = Convert.ToInt32(parameters.ExtraQuote);
        }

        public DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public int SpeedingTickets { get; set; }
        public bool DUI { get; set; }
        public bool CoverageType { get; set; }
        public int ExtraQuote { get; set; }
    }
}