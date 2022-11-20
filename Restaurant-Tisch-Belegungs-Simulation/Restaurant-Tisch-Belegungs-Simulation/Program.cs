using System;
using System.Collections.Generic;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Program
    {
        public static Dictionary<string, int> FreieStuehleTisch = new Dictionary<string, int>();
        public static Dictionary<string, string> GruppeTisch = new Dictionary<string, string>();
        public static Dictionary<string, int> PersonenGruppe = new Dictionary<string, int>();
        public static Dictionary<string, int> MappingGruppen = new Dictionary<string, int>();
        public static Dictionary<string, int> neueBelegung = new Dictionary<string, int>();
        public static Dictionary<string, int> alteBelegung = new Dictionary<string, int>();
        public static int AnzahlTische;

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
