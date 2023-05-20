using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2___ChainOfResposibility.ErrorModel
{
    public class DiscountForMore500DolsTruth
    {
          public double CalcDiscount(BudgetTruth budget)
        {
            if(budget.Value > 500)
            {
                return budget.Value * 0.1;
            }
            return 0;
        }
    }
}
