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
                    

                    FreieStuehleTisch["Tisch" + stuehle] = alteBelegung["Tisch" + stuehle];
                    GruppeTisch.Remove("Tisch" + stuehle);

                    }

                }

        }
    }
}
