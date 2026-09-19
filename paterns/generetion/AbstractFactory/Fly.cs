using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion.AbstractFactory
{
    internal class Fly : IMove
    {
        public void Move()
        {
            Console.WriteLine("I am fling");
        }
    }
}
