
namespace DesignPatterns._9___Memento.TruthModel
{
    public class Historic
    {
        private IList<ContractState> contractsStates = new List<ContractState>();

            
        public void AddState(ContractState state)
        {
            this.contractsStates.Add(state);
        }

        public ContractState ReturnStateFromList(int index) 
        {
            return contractsStates[index];
        }
    }
}
