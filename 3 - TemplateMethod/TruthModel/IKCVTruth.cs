using DesignPatterns._2___ChainOfResposibility.TruthModel;
using DesignPatterns._3___TemplateMethod.TruthModel;

namespace DesignPatterns._3___TemplateMethod.ErrorModel
{
    public class IKCVTruth : TaxWithConditionTemplate
    {

        public override bool MustUseMaxTax(BudgetTruth budget)
        {
            return budget.Value > 500 && WithItemMore100(budget);
        }

        public override double MaxTax(BudgetTruth budget)
        {
            return budget.Value * 0.10;
        }

        public override double MinTax(BudgetTruth budget)
        {
            return budget.Value * 0.06;
        }

        private bool WithItemMore100(BudgetTruth budget)
        {
            foreach (ItemTruth item in budget.Itens)
            {
                if (item.Value > 100)
                    return true;
            }
            return false;
        }
    }
}
