using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns._6___Builder.ErrorModel;

namespace DesignPatterns._6___Builder_e_Observer.TruthModel
{
    public  class SenderSMS : ISenderForAnyWhere
    {
        public void SendData(Invoice invoice)
        {
            Console.WriteLine("Nota fiscal enviada por SMS com sucesso");
        }
    }
}
