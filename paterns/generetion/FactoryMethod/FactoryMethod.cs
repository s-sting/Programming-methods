using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion.FactoryMethod
{
    internal class FactoryMethod
    {
        public static void Run()
        {
            IComputer pc1 = PCFactory.CreaterNewPC();
            IComputer pc2 = PCFactory.CreaterOldPC();

            pc1.Run();
            pc2.Run();
        }
    }
}
