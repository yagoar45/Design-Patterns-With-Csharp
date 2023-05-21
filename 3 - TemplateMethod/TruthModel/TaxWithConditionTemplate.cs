
using DesignPatterns._2___ChainOfResposibility.TruthModel;

namespace DesignPatterns._3___TemplateMethod.TruthModel
{
    public abstract class TaxWithConditionTemplate : IDiscount
    {
        public IDiscount NextRule { get; set; }
        public double Discount(BudgetTruth budget)
        {
            if (MustUseMaxTax(budget))
            {
                return MaxTax(budget);
            }

            return MinTax(budget);
        }

        public abstract bool MustUseMaxTax(BudgetTruth budget);
        public abstract double MinTax(BudgetTruth budget);
        public abstract double MaxTax(BudgetTruth budget);
    }
}
