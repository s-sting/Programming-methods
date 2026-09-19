using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion
{
    internal class ClassB
    {
        public ClassB()
        {
            Logger log = Logger.GetInstance();
            Logger.GetInstance().Log("ClassB was init");
            Console.WriteLine(log.GetHashCode());
        }
    }
}
