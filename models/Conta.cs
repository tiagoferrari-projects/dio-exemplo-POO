using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_exemplo_POO.models
{
    public abstract class Conta
    {
        protected decimal saldo;
        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é {saldo}");
        }
    }
}