using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    public class Puma : WildAnimals
    {
        public string Color = "Black";

        public override void Eat()
        {
            Console.WriteLine("Puma eats meat");
        }
    }
}
