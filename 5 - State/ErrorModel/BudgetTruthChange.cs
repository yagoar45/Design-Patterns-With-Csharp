
namespace DesignPatterns._5___State
{
    public class BudgetTruth
    {

        public int APRROVED = 1;
        public int ON_APPROVAL = 2;
        public int DISAPRROVED = 3;

        public int State { get; set; }



        public double Value { get; private set; }
        public IList<ItemTruth> Itens { get; private set; }
        public BudgetTruth(double value)
        {
            this.Value = value;
            this.Itens = new List<ItemTruth>();
        }


        public void ApplyExtraDiscount()
        {
            if (State == ON_APPROVAL) Value -= (Value * 0.05);
            else if (State == DISAPRROVED) Value -= (Value * 0.02);
            else throw new Exception("Orçamentos finalizados e reprovados não recebem desconto extra");
        }

        public void addItem(ItemTruth item)
        {
            Itens.Add(item);
        }
    }
}
