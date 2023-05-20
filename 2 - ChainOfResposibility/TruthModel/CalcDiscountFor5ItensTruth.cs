

namespace DesignPatterns._2___ChainOfResposibility.TruthModel
{
    public class CalcDiscountFor5ItensTruth : IDiscount
    {

        public IDiscount NextRule { get; set; }

        public double Discount(BudgetTruth budget)
        {
            if(budget.Itens.Count > 5)
            {
                return budget.Value * 0.07;
            }
            return NextRule.Discount(budget);
        }
    }
}
