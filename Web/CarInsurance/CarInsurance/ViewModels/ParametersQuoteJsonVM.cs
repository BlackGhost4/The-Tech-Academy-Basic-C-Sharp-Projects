using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModels
{
    public class ParametersQuoteJsonVM
    {
        public string DateOfBirth { get; set; }
        public string CarYear { get; set; }
        public string SpeedingTickets { get; set; }
        public string DUI { get; set; }
        public string CoverageType { get; set; }
        public string ExtraQuote { get; set; }
    }
}