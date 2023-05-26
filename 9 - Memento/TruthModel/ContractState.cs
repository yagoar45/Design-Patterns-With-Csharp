


using System.Diagnostics.Contracts;

namespace DesignPatterns._9___Memento.TruthModel
{
    public class ContractState
    {
        public Contract Contract{ get;  set; }


        public ContractState(Contract contract)
        {
            this.Contract = contract;
        }
    }
}
