using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class House : IInvestment
    {
        public string Address { get; set; }
        public int SquareMeters { get; set; }
        public int SquareMeterPrice { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }

        public int PriceCalculate()
        {
            return SquareMeters * SquareMeterPrice;
        }

        public string InvestSummary()
        {
            return $"House: {Address} Area={SquareMeters}";
        }
    }
}
