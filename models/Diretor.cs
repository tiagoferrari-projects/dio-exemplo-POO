using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_exemplo_POO.models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine("Diretor");
        }
    }
}