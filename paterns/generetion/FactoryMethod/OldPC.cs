using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion.FactoryMethod
{
    internal class OldPC : IComputer
    {
        public void Run()
        {
            Console.WriteLine("ON2");
        }

        public void Stop()
        {
            Console.WriteLine("OFF");
        }
    }
}
