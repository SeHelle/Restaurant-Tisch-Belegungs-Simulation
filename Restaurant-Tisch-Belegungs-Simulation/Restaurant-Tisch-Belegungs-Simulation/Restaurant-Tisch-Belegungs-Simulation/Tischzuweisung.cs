using System;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Tischzuweisung : Program
    {
        public void freienTischfinden()
      
        {
            bool zugewiesen = false;

            for (int gruppe = 1; gruppe <= PersonenGruppe.Count-1; gruppe++)
            {
                for (int i = 1; i < FreieStuehleTisch.Count; i++)
                {

                    if (FreieStuehleTisch?["Tisch" + i] > PersonenGruppe["Gruppe" + gruppe])
                    {

                        Console.WriteLine("Gruppe " + gruppe + " kann an Tisch " + i + " Platz nehmen.");

                        int neueBelegungStuehle = FreieStuehleTisch["Tisch" + i] - PersonenGruppe["Gruppe" + gruppe];
                        FreieStuehleTisch["Tisch" + i] = neueBelegungStuehle;
                        Console.WriteLine("An Tisch " + i + " sind jetzt noch " + neueBelegungStuehle + " Plätze frei.");
                        GruppeTisch.Add("Tisch" + i, "Gruppe" + gruppe);
                        FreieStuehleTisch.Remove("Tisch" + i);
                        TischeMitBelgung.Add("Tisch" + i);
                        neueBelegung.Add("Tisch" + i, neueBelegungStuehle);
                        zugewiesen = true;
                        break;
                    }
                }
               

                if (zugewiesen != false)
                {
                    for (int x = 0; x < neueBelegung.Count; x++)
                    {
                        foreach (var tisch in TischeMitBelgung)
                        {
                            try
                            {
                                if (neueBelegung[tisch] >= PersonenGruppe["Gruppe" + gruppe])

                                {
                                    Console.WriteLine("Für Gruppe" + gruppe + " ist am Tisch " + x + " noch Platz, da sitzt zwar schon eine andere Gruppe aber sie werden sich sicher verstehen!");
                                    neueBelegung["Tisch" + x] = neueBelegung["Tisch" + x] - PersonenGruppe["Gruppe" + gruppe];
                                    zugewiesen = true;
                                }


                            }
                            catch
                            {
                                break;
                            }

                        }
                    }
                }

                if(zugewiesen!=true)
                Console.WriteLine("Leider haben wir für Gruppe " + gruppe + " kein Platz mehr!");
             }
            
        }
    }
}                       
                       