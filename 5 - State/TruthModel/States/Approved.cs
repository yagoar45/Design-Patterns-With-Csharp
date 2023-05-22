using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._5___State.TruthModel.States
{
    public class Approved : IState
    {
        public void ApplyExtraTax(BudgetTruthChangeOk budget)
        {
            budget.Value = budget.Value - (budget.Value * 0.02);
        }

        public void StateAprroved(BudgetTruthChangeOk budget)
        {
            throw new Exception("Já foi aprovado");
        }

        public void StateDisaprroved(BudgetTruthChangeOk budget)
        {
            budget.Currentstate = new Disaprroved();
        }

        public void StateOnApproval(BudgetTruthChangeOk budget)
        {
            budget.Currentstate = new OnApproval();
        }
    }

}
