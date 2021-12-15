using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModels
{
    public class FinalQuoteVM
    {
        public decimal quoteMonthly { get; set; }
        public int quoteByAge { get; set; }
        public int quoteByCarYear { get; set; }
        public int quoteBySpeedingTickets { get; set; }
        public decimal quoteByDUI { get; set; }
        public decimal quoteByCoverageTotal { get; set; }
        public int quoteByCarModel { get; set; }
    }
}