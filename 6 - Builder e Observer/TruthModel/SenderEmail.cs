

using DesignPatterns._6___Builder.ErrorModel;

namespace DesignPatterns._6___Builder_e_Observer.TruthModel
{
    public  class SenderEmail : ISenderForAnyWhere
    {
        public void SendData(Invoice invoice)
        {
            Console.WriteLine("Nota fiscal enviada por email com sucesso");
        }
    }
}
