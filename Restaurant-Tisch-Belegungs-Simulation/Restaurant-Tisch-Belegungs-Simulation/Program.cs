using System;
using System.Collections.Generic;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Program 
    {
        protected static Dictionary<string, int> freieStuehleTisch = new Dictionary<string, int>();
        protected static Dictionary<string, string> gruppeTisch = new Dictionary<string, string>();
        protected static Dictionary<string, int> personenGruppe = new Dictionary<string, int>();
        protected static Dictionary<string, int> mappingGruppen = new Dictionary<string, int>();
        protected static Dictionary<string, int> neueBelegung = new Dictionary<string, int>();
        protected static Dictionary<string, int> alteBelegung = new Dictionary<string, int>();
        protected static int AnzahlTische;

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
