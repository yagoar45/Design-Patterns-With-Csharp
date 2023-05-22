

namespace DesignPatterns._6___Builder.ErrorModel
{
    public class Invoice
    {
        public string CorporateName { get; set; }
        
        public string Cnpj { get; set; }

        public DateTime IssueDate { get; set; }

        public double GrossValue { get; set; }

        public double Taxs { get; set; }
        public IList<ItemInvoice> Itens { get; set; }

        public string Note { get; set; }


        public Invoice(string corporateName, string cnpj,double grossValue, DateTime issueDate, double taxs, 
            IList<ItemInvoice> itens, string note
            )
        {
            this.CorporateName = corporateName;
            this.Cnpj = cnpj;
            this.IssueDate = issueDate;
            this.Note = note;
            this.Taxs = taxs;
            this.Itens = itens;
            this.GrossValue = grossValue;
        }
    }
}
