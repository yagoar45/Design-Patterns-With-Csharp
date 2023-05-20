

namespace DesignPatterns._2___ChainOfResposibility.TruthModel
{
    public class CalcDiscountForMore500DolsTruth : IDiscount
    {
        public IDiscount NextRule { get; set; }

        public double Discount(BudgetTruth budget)
        {

            if(budget.Value > 500)
            {
                return budget.Value * 0.1; 
            }

            return NextRule.Discount(budget);
        }
    }
}
