using System;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Tischzuweisung : BenoetigteDictionary
    {
        public void freienTischfinden()
        {
            for (int stuehle = 1; stuehle <= freieStuehleTisch.Count; stuehle++)
            {
                for(int gruppe =1; gruppe <= personenGruppe.Count; gruppe ++)
                {
                    if(freieStuehleTisch.ContainsKey("Tisch" + stuehle) && personenGruppe.ContainsKey("Gruppe" + gruppe))
                     {
                            if (freieStuehleTisch["Tisch" + stuehle] >= personenGruppe["Gruppe" + gruppe])
                            {
                             Console.WriteLine("Gruppe " + gruppe + " nehmen Sie doch bitte an Tisch"+stuehle+" Platz");
                             int neueBelegungStuehle = freieStuehleTisch["Tisch" + stuehle] - personenGruppe["Gruppe" + gruppe];
                             alteBelegung.Add("Tisch" + stuehle, freieStuehleTisch["Tisch" + stuehle]);
                             neueBelegung.Add("Tisch" + stuehle, neueBelegungStuehle);
                             gruppeTisch.Add("Tisch" + stuehle, "Gruppe" + gruppe);
                             freieStuehleTisch.Remove("Tisch" + stuehle);
                             personenGruppe.Remove("Gruppe" + gruppe);
                            }
                    }
                }
            }
           for(int stuehle = 1; stuehle <= freieStuehleTisch.Count; stuehle++)
            {
                for (int gruppe = 1; gruppe < personenGruppe.Count; gruppe++)
                {
                    if(neueBelegung.ContainsKey("Tisch" + stuehle) && personenGruppe.ContainsKey("Gruppe" + gruppe))
                    {
                        if (neueBelegung["Tisch" + stuehle] >= personenGruppe["Gruppe" + gruppe])
                        {
                            Console.WriteLine("Gruppe " + gruppe + " nehmen Sie doch bitte an Tisch" + stuehle + " Platz");
                            int neueBelegungStuehle = freieStuehleTisch["Tisch" + stuehle] - personenGruppe["Gruppe" + gruppe];
                            personenGruppe.Remove("Gruppe" + gruppe);
                            neueBelegung["Tisch" + stuehle] = neueBelegungStuehle;
                            gruppeTisch.Add("Tisch" + stuehle, "Gruppe" + gruppe);
                        }
                    }
                }
            }
            for (int gruppe = 0; gruppe < personenGruppe.Count; gruppe++)
            {
                if(personenGruppe.ContainsKey("Gruppe"+gruppe))
                { 
                  Console.WriteLine("Gruppe " + gruppe + "! Leider haben wir heute keinen Platz für Sie");
                }
            }
        }
    }
}                       
                       