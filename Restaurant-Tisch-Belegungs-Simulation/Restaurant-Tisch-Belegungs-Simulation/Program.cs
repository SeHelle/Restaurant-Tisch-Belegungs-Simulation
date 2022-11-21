using System;
using System.Collections.Generic;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Program 
    {
        static void Main(string[] args)
        {
            new Restaurant().erzeugeStuehle(2,10);
            new Gruppen().getPersonen(2,10);
            Console.WriteLine("Willkommen in unserem Restaurant!");
            new Tischzuweisung().freienTischfinden();
            new Ausgang().stuehleFreigeben();
        }
    }
}
