using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion.AbstractFactory
{
    internal class Hero
    {
        public string Name;
        public IHit hit;
        public IMove move;

        public Hero(IHit hit, IMove move, string name)
        {
            this.hit = hit;
            this.move = move;
            Name = name;
        }

        public void Hit() 
        { 
            Console.WriteLine(Name + " ");
            hit.Hit();  
        }
        public void Move() { Console.WriteLine(this.Name); move.Move(); }

    }
}
