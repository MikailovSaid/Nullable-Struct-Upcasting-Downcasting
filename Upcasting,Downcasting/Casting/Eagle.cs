using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    public class Eagle : WildAnimals 
    {
        public string Color = "Brown";
        public override void Eat()
        {
            Console.WriteLine("Eagle eats snakes");
        }
    }
}
