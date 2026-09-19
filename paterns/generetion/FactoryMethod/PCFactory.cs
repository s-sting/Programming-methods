using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion.FactoryMethod
{
    internal class PCFactory
    {
        public static IComputer CreaterNewPC()
        {
            return new NewPC();
        }
        public static IComputer CreaterOldPC()
        {
            return new OldPC();
        }
    }
}
