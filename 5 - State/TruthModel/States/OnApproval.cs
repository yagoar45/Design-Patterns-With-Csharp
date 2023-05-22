using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._5___State.TruthModel.States
{
    public class OnApproval : IState
    {
        public void ApplyExtraTax(BudgetTruthChangeOk budget)
        {
            budget.Value = budget.Value - (budget.Value * 0.01);
        }

        public void StateAprroved(BudgetTruthChangeOk budget)
        {
            budget.Currentstate = new Approved();
        }

        public void StateDisaprroved(BudgetTruthChangeOk budget)
        {
            budget.Currentstate = new Disaprroved();
        }

        public void StateOnApproval(BudgetTruthChangeOk budget)
        {
            throw new Exception("Já está em aprovação ");
        }
    }
}
