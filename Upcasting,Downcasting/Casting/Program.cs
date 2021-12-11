using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting
            //Animals puma = new Puma();
            //Animals shark = new Shark();
            //Animals eagle = new Eagle();

            //Animals[] animals = { puma, shark, eagle };

            //foreach (var items in animals)
            //{
            //    items.Eat();
            //}
            #endregion

            #region Downcasting
            Animals puma = new Puma();
            Animals shark = new Shark();
            Animals eagle = new Eagle();

            Puma puma2 = (Puma)puma;
            Shark shark2 = (Shark)shark;
            Eagle eagle2 = (Eagle)eagle;

            Console.WriteLine(puma2.Color);
            #endregion
        }
    }
}