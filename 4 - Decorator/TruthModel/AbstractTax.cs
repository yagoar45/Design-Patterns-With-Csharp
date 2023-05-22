using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._4___Decorator.TruthModel
{
    public abstract class AbstractTax
    {
        public AbstractTax? NextTax {get;set;}


        public AbstractTax(AbstractTax tax)
        {
            this.NextTax = tax;
        }


        public AbstractTax()
        {
            this.NextTax = null;
        }

        public abstract double Calc(BudgetTruth budget);

        protected double CalcWithNextTax(BudgetTruth budget)
        {
            if (NextTax == null) return 0;

            return NextTax.Calc(budget);
        }
    }
}
