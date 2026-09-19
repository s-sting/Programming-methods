using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion.AbstractFactory
{
    internal class Swing : IHit
    {
        public void Hit()
        {
            Console.WriteLine("I am swinging");
        }

    }
}
