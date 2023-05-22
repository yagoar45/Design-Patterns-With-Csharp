using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._5___State.TruthModel.States
{
    public class Disaprroved : IState
    {
        public void ApplyExtraTax(BudgetTruthChangeOk budget)
        {
            throw new Exception("Orçamentos finalizados e reprovados não recebem desconto extra");
        }

        public void StateAprroved(BudgetTruthChangeOk budget)
        {
            throw new Exception("Não há como aprovar se já foi reprovado ");
        }

        public void StateDisaprroved(BudgetTruthChangeOk budget)
        {
            throw new Exception("Já foi reprovado");
        }

        public void StateOnApproval(BudgetTruthChangeOk budget)
        {
            throw new Exception("O procedimento já foi finalizado");
        }
    }
}
