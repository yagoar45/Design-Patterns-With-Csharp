
using DesignPatterns._2___ChainOfResposibility.TruthModel;

namespace DesignPatterns._3___TemplateMethod.ErrorModel
{
    public class ICPP : IDiscount
    {
        public IDiscount NextRule { get; set; }

        public double Discount(BudgetTruth budget)
        {
            if(budget.Value >= 500)
            {
                return budget.Value * 0.07;
            }

            return budget.Value * 0.05;
        }
    }
}
