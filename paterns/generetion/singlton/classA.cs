using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion
{
    internal class classA
    {
        public classA()
         {
            Logger log = Logger.GetInstance();
            Logger.GetInstance().Log("ClassA was init");
            Console.WriteLine(log.GetHashCode());
        }
    }
}
