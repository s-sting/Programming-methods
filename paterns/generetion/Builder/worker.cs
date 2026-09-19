using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion.Builder
{
    internal class worker
    {
        public worker() 
        { 
            building = new Building();
        }

        private Building building;
        public Building build()
        {
            return building;
        }
        public worker foundation(string foundation)
        {
            building.foundation = foundation;
            return this;
        }
        public worker walls(string walls)
        {
            building.walls = walls;
            return this;
        }
        public worker roof(string roof)
        {
            building.roof = roof;
            return this;
        }
        public worker interior(string interior)
        {
            building.interior = interior;
            return this;
        }

    }
}
