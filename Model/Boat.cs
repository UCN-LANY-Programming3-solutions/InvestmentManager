using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Boat : IInvestment
    {
        public int Length { get; set; }
        public int MeterPrice { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public int RegYear { get; set; }

        public int CalculatePrice()
        {
            return Length * MeterPrice;
        }

        public string InvestSummary()
        {
            return $"Boat {Description} Length={Length}";
        }

        // NOTE: It can be tempting to change the signature of the CalculatePrice
        //       method, so you do not have to have two methods. However, it is
        //       possible that other classes are dependent on the original method
        //       so we will not change or remove it.
        public int PriceCalculate()
        {
            return CalculatePrice();
        }
    }
}
