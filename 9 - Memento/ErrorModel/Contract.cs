
using DesignPatterns._9___Memento.TruthModel;

namespace DesignPatterns._9___Memento.ErrorModel
{
    public class Contract
    {
        public DateTime Date { get; private set; }

        public string Client { get; private set; }

        public TypeContract Type { get; set; }

        public Contract(DateTime date, string client, TypeContract type)
        {
            this.Client = client;
            this.Date = date;
            this.Type = type;
        }

        public void ParaFrente()
        {
            if(this.Type == TypeContract.NewContract) 
            {
                this.Type = TypeContract.Processing;
            }
            else if(this.Type == TypeContract.Processing)
            {
                this.Type = TypeContract.Agreed;
            }
            else if (this.Type == TypeContract.Agreed)
            {
                this.Type= TypeContract.Concluded;
            }
        }

        public ContractState SaveState()
        {
            return new ContractState(new Contract(this.Date, this.Client, this.Type));
        }
    }
}
