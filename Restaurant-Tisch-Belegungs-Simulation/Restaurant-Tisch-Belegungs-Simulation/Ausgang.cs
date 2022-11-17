using System;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Ausgang : Program
    {

        public void stuehleFreigeben()
        {
                for (int i = 1; i < 10; i++)
                {
                    try
                    {
                        Console.WriteLine("Leider verlässt uns Tisch" + neueBelegung["Tisch"+i]);
                        FreieStuehleTisch["Tisch" + i] = alteBelegung["Tisch" + i];
                        neueBelegung.Remove("Tisch" + i);

                    }
                    catch
                    {
                        continue;
                    }

                }

        }
    }
}
