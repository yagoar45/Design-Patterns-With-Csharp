
using DesignPatterns._5___State.TruthModel.States;

namespace DesignPatterns._5___State.TruthModel
{
    public class BudgetTruthChangeOk
    {

        public IState Currentstate { get; set; }

        public double Value { get; set; }
        public IList<ItemTruth> Itens { get; private set; }

        public BudgetTruthChangeOk(double value)
        {
            this.Value = value;
            this.Itens = new List<ItemTruth>();
            this.Currentstate = new OnApproval();
        }

        public void addItem(ItemTruth item)
        {
            Itens.Add(item);
        }

        public void ApplyExtraTax()
        {
            Currentstate.ApplyExtraTax(this);
        }


        public void IsAprroved()
        {
            Currentstate.StateAprroved(this);
        }

        public void IsOnApproved()
        {
            Currentstate.StateOnApproval(this);
        }

        public void IsDisapproved()
        {
            Currentstate.StateDisaprroved(this);
        }
    }
}
