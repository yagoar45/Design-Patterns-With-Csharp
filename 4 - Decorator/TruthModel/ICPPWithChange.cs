
using DesignPatterns._2___ChainOfResposibility.TruthModel;
using DesignPatterns._4___Decorator.TruthModel;

namespace DesignPatterns._3___TemplateMethod.ErrorModel
{
    public class ICPPWithChange : AbstractTax
    {
        public ICPPWithChange(AbstractTax tax) : base(tax)
        {}

        public AbstractTax NextTax { get; set; }

        public override double Calc(BudgetTruth budget)
        {
            return budget.Value * 0.06 + CalcWithNextTax(budget) ; 
        }

 
    }
}
