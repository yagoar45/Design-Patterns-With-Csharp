public class BudgetTruth
{
    public double Value { get; private set; }
    public IList<ItemTruth> Itens {get; private set;}
    public BudgetTruth(double value)
    {
        this.Value = value;
        this.Itens = new List<ItemTruth>();
    }

    public void addItem(ItemTruth item)
    {
        Itens.Add(item);
    }
}