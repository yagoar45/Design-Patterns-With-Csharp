

using DesignPatterns._6___Builder.ErrorModel;
using DesignPatterns._6___Builder_e_Observer.TruthModel;

namespace DesignPatterns._6___Builder.TruthModel
{
    public class BuildInvoice
    {

        public string CorporateName {  get; private set; }   
        public string Cnpj { get; private set; }

        public string Notes { get; private set; }

        public DateTime DateToday { get; private set; } 

        private double totalValue;
        private double taxs;
        private IList<ItemInvoice> items = new List<ItemInvoice>();
        private IList<ISenderForAnyWhere> actionsAfterInvoice = new List<ISenderForAnyWhere>();

        public BuildInvoice()
        {
            this.DateToday = DateTime.Now;
        }

        public void AddAction(ISenderForAnyWhere newAction)
        {
            this.actionsAfterInvoice.Add(newAction);
        }
        
        public Invoice BuildeAInvoice()
        {
            var invoice  =  new Invoice(CorporateName, Cnpj, totalValue,DateToday, taxs, items, Notes);

            foreach(var action in actionsAfterInvoice) 
            {
                action.SendData(invoice);
            }

            return invoice;
        }

       

        public BuildInvoice ForCompanies(string corporateName)
        {
            this.CorporateName = corporateName;
            return this;
        }

        public BuildInvoice WithCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;

        }


        public BuildInvoice WithNotes(string notes)
        {
            this.Notes = notes;
            return this;

        }

        public BuildInvoice WithDate(DateTime date)
        {
            this.DateToday = date;
            return this;

        }

        public BuildInvoice WithItem(ItemInvoice item) 
        {
            items.Add(item);
            totalValue += item.Value;
            taxs += item.Value * 0.05;
            return this;
        }

    }
}
