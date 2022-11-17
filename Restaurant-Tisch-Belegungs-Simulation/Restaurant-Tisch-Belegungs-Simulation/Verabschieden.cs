using System;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Verabschieden : Program
    {

        public void stuehleFreigeben()
        {
           
            if (TischeMitBelgung.Count > 0)
            {
                for (int i = 0; i < TischeMitBelgung.Count; i++)
                {
                    try
                    {

                Console.WriteLine("Leider verlässt uns " + TischeMitBelgung[i]);
                var freiWerdeneStuehle = neueBelegung[TischeMitBelgung[i]];
                Console.WriteLine("An " + TischeMitBelgung[i] + " sind " + freiWerdeneStuehle + " Plätze freigeworden");
                var tisch = GruppeTisch[TischeMitBelgung[i]];
                int personen = PersonenGruppe[tisch];
                FreieStuehleTisch.Add(tisch, personen + freiWerdeneStuehle);


                    }
                    catch
                    {
                        continue;
                    }

                }

          
               
            }
        }
    }
}
