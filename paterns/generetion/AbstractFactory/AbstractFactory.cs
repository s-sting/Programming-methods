using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion.AbstractFactory
{
    internal class AbstractFactory
    {
      public static void Run()
        {
            Hero ranger = HeroFactory.CreareRanger();
            Hero pudge = HeroFactory.CrearePudge();
            Hero viper = HeroFactory.CreareViper();

            ranger.Hit();
        }
    }
}
