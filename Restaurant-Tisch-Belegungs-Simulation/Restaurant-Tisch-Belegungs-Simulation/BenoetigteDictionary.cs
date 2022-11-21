using System;
using System.Collections.Generic;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class BenoetigteDictionary
    {
        protected static Dictionary<string, int> freieStuehleTisch = new Dictionary<string, int>();
        protected static Dictionary<string, string> gruppeTisch = new Dictionary<string, string>();
        protected static Dictionary<string, int> personenGruppe = new Dictionary<string, int>();
        protected static Dictionary<string, int> mappingGruppen = new Dictionary<string, int>();
        protected static Dictionary<string, int> neueBelegung = new Dictionary<string, int>();
        protected static Dictionary<string, int> alteBelegung = new Dictionary<string, int>();
    }
}
