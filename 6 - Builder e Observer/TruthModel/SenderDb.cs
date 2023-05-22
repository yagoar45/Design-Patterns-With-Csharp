using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns._6___Builder.ErrorModel;

namespace DesignPatterns._6___Builder_e_Observer.TruthModel
{
    public  class SenderDb : ISenderForAnyWhere
    {


        public void SendData(Invoice invoice)
        {
            Console.WriteLine("Nota fiscal enviada para o banco de dados com sucesso");
        }
    }
}
