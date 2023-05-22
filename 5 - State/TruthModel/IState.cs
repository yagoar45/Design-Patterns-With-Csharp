using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._5___State.TruthModel
{
    public interface IState
    {
        void ApplyExtraTax(BudgetTruthChangeOk budget);

        void StateAprroved(BudgetTruthChangeOk budget);
        void StateDisaprroved(BudgetTruthChangeOk budget);
        void StateOnApproval(BudgetTruthChangeOk budget);

    }

}
