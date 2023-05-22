using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3___TemplateMethod.TruthModel
{
    public class IHIT : TaxWithConditionTemplate
    {
        public override double MaxTax(BudgetTruth budget)
        {
            return budget.Value * 0.13 + 100;
        }

        public override double MinTax(BudgetTruth budget)
        {
            return budget.Value * 0.01 * budget.Itens.Count(); 
        }

        public override bool MustUseMaxTax(BudgetTruth budget)
        {
            IList<String> inList = new List<String>();

            foreach (var item in budget.Itens)
            {
                if(inList.Contains(item.Name))
                {
                    return true;
                }
                else
                {
                    inList.Add(item.Name);  
                }
            }

            return false;
        }
    }
}
