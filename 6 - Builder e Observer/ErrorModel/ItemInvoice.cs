

namespace DesignPatterns._6___Builder.ErrorModel
{
    public class ItemInvoice
    {
        public string Name { get; set; }    
        public double Value { get; set; }

        public ItemInvoice(string name, double value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
