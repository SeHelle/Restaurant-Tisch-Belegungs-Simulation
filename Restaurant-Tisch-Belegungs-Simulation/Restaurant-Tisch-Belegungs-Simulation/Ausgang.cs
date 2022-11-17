using System;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Ausgang : Program
    {

        public void stuehleFreigeben()
        {
                for (int stuehle = 1; stuehle < AnzahlTische; stuehle++)
                {
                    if(neueBelegung.ContainsKey("Tisch" + stuehle))
                    {
                        Console.WriteLine("Leider verlässt uns Tisch" + stuehle);
                        FreieStuehleTisch["Tisch" + stuehle] = alteBelegung["Tisch" + stuehle];
                        neueBelegung.Remove("Tisch" + stuehle);

                    }

                }

        }
    }
}
