using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.generetion
{
    internal class Prototype
    {
        public static void Run()
        {
            Task task1 = new Task();
            task1.description = "First Task";

            var task2 = task1.Clone();
            int hash1 = task1.GetHashCode();
            int hash2 = task2.GetHashCode();
            Console.WriteLine(hash2);
            Console.WriteLine(hash1);
        } 
    }
}
