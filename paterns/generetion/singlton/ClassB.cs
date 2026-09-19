using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion
{
    internal class ClassB
    {
        public ILogger logger { get; set; }
        public ClassB(ILogger logger)
        {
            this.logger = logger;
            logger.Log("ClassB was init");
            Console.WriteLine(logger.GetHashCode());
        }
    }
}
