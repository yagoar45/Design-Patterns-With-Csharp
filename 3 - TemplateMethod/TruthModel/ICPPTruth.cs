

namespace DesignPatterns._3___TemplateMethod.TruthModel
{
    public class ICPPTruth : TaxWithConditionTemplate
    {
        public override bool  MustUseMaxTax(BudgetTruth budget)
        {
            return budget.Value > 500;
        }

        public override double MaxTax(BudgetTruth budget)
        {
            return budget.Value * 0.07;
        }

        public override double MinTax(BudgetTruth budget)
        {
            return budget.Value * 0.02;
        }
    }
}
