using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion
{
    internal class Singlton
    {
        public static void Run()
        {
            classA classA = new classA(Logger.GetInstance());
            ClassB classB = new ClassB(Logger.GetInstance());

        }
    }
}
