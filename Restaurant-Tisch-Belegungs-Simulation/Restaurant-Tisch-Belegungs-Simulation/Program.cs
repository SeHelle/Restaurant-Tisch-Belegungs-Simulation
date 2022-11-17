using System;
using System.Collections.Generic;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Program
    {
        public static Dictionary<string, int> FreieStuehleTisch = new Dictionary<string, int>();
        public static Dictionary<string, string> GruppeTisch = new Dictionary<string, string>();
        public static Dictionary<string, int> PersonenGruppe = new Dictionary<string, int>();
        public static Dictionary<string, int> neueBelegung = new Dictionary<string, int>();
        public static Dictionary<string, int> alteBelegung = new Dictionary<string, int>();
        public static List<string> TischeMitBelgung = new List<string>();

        static void Main(string[] args)
        {
            new Restaurant().bauen();
            new Gruppen().getPersonen();

            Console.WriteLine("Willkommen in unserem Restaurant!");
            new Tischzuweisung().freienTischfinden();
            new Ausgang().stuehleFreigeben();
        }
    }


}
