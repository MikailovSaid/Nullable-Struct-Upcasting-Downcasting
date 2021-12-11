using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    public class Shark : WildAnimals
    {
        public string Color = "Blue";
        public override void Eat()
        {
            Console.WriteLine("Shark eats fishes");
        }
    }
}
