using System;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Ausgang : Program
    {

        public void stuehleFreigeben()
        {
                for (int stuehle = 1; stuehle <= GruppeTisch.Count+1; stuehle++)
                {
                if (GruppeTisch.ContainsKey("Tisch" + stuehle))
                {
                    Console.WriteLine("Leider verlässt uns" + GruppeTisch["Tisch"+stuehle]);

                    int PersonenGruppe = MappingGruppen[GruppeTisch["Tisch" + stuehle]];
                    int NochFreieStuehle = neueBelegung["Tisch" + stuehle];
                    FreieStuehleTisch["Tisch" + stuehle] = NochFreieStuehle + PersonenGruppe;
                    GruppeTisch.Remove("Tisch" + stuehle);

                    }

                }

        }
    }
}
