using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion.AbstractFactory
{
    internal class HeroFactory
    {
        public static Hero CreareRanger()
        {
            return new Hero(new Shoot(), new Run(), "Ranger");
        }
        public static Hero CrearePudge()
        {
            return new Hero(new Shoot(), new Run(), "Pudge");
        }
        public static Hero CreareViper()
        {
            return new Hero(new Shoot(), new Fly(), "Pudge");
        }
    }
}
