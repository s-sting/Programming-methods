using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion
{
    internal class classA
    {
        public ILogger logger { get; set; }
        public classA(ILogger logger)
         {
            this.logger = logger;
            logger.Log("ClassA was init");
            Console.WriteLine(logger.GetHashCode());
        }
    }
}
