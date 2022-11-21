using System;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Ausgang : BenoetigteDictionary
    {
        public void stuehleFreigeben()
        {
                for (int stuehle = 1; stuehle <= gruppeTisch.Count+1; stuehle++)
                {
                 if (gruppeTisch.ContainsKey("Tisch" + stuehle))
                    {
                        Console.WriteLine("Leider verlässt uns" + gruppeTisch["Tisch"+stuehle]);
                        int personenGruppe = mappingGruppen[gruppeTisch["Tisch" + stuehle]];
                        int nochFreieStuehle = neueBelegung["Tisch" + stuehle];
                        freieStuehleTisch["Tisch" + stuehle] = nochFreieStuehle + personenGruppe;
                        gruppeTisch.Remove("Tisch" + stuehle);
                    }
                }
        }
    }
}
