using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2___ChainOfResposibility.TruthModel
{
    public class CalcWithOutDiscount : IDiscount
    {
        public IDiscount NextRule { get; set; } 

        public double Discount(BudgetTruth budget)
        {
            return 0;
        }
    }
}
