using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2___ChainOfResposibility.TruthModel
{
    public interface IDiscount
    {
        double Discount(BudgetTruth budget);

        IDiscount NextRule { get; set; }
    }
}
