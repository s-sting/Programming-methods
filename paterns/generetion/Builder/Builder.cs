using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion.Builder
{
    internal class Builder
    {
        public void Run()
        {
            Building building = new worker().foundation("f1")
                .walls("b1")
                .roof("r1")
                .interior("i1")
                .build( );
        }
    }
}
