using DesignPatterns._2___ChainOfResposibility.TruthModel;

namespace DesignPatterns._3___TemplateMethod.ErrorModel
{
    public class IKCV : IDiscount
    {
        public IDiscount NextRule { get; set; } 

        public double Discount(BudgetTruth budget)
        {
            if(budget.Value > 500 && WithItemMore100(budget))
            {
                return budget.Value * 0.1;
            }

            return budget.Value * 0.06; 

        }

        private bool WithItemMore100(BudgetTruth budget)
        {
            foreach (ItemTruth item in budget.Itens)
            {
                if(item.Value > 100)
                    return true;
            }
            return false;
        }
    }
}
