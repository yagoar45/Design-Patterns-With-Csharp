public class ItemTruth
{
    public string Name {get; private set;}

    public double Value {get; private set;}

    public ItemTruth(string name, double value)
    {
        this.Name= name;
        this.Value = value;
    }
}