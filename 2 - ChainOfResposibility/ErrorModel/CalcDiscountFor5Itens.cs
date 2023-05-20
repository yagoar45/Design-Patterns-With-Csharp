using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2___ChainOfResposibility.ErrorModel
{
    public class CalcDiscountFor5ItensTruth
    {
       public double CalcDiscount(BudgetTruth budget)
        {
            if(budget.Itens.Count > 5)
            {
                return budget.Value * 0.07;
            }
            return 0;
        }
    }
}
