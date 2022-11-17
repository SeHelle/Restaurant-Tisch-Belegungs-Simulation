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
        public static List<string> TischeMitBelgung = new List<string>();

        static void Main(string[] args)
        {

            var restaurant = new Restaurant().getStuehle();
            new Gruppen().getPersonen();

            Console.WriteLine("Willkommen in unserem Restaurant! Heute haben wir "+restaurant.Count+" Stühle frei.");
            Console.WriteLine("Da sind schon die ersten Gruppen, heute sind es " + PersonenGruppe.Count + " Gruppen welche wir gerne beköstigen.");
            new Tischzuweisung().freienTischfinden();
            new Verabschieden().stuehleFreigeben();
        }
    }


}
