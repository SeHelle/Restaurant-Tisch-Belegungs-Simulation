using System;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Tischzuweisung : Program
    {
        public void freienTischfinden()
      
        {
            for (int stuehle = 1; stuehle <= FreieStuehleTisch.Count; stuehle++)
            {
           
                for(int gruppe =1; gruppe <= PersonenGruppe.Count; gruppe ++)
                {
                    if(FreieStuehleTisch.ContainsKey("Tisch" + stuehle) && PersonenGruppe.ContainsKey("Gruppe" + gruppe))
                   
                     {
                            if (FreieStuehleTisch["Tisch" + stuehle] >= PersonenGruppe["Gruppe" + gruppe])
                            {
                             Console.WriteLine("Gruppe " + gruppe + " nehmen Sie doch bitte an Tisch"+stuehle+" Platz");
                             int neueBelegungStuehle = FreieStuehleTisch["Tisch" + stuehle] - PersonenGruppe["Gruppe" + gruppe];
                             alteBelegung.Add("Tisch" + stuehle, FreieStuehleTisch["Tisch" + stuehle]);
                             neueBelegung.Add("Tisch" + stuehle, neueBelegungStuehle);
                             GruppeTisch.Add("Tisch" + stuehle, "Gruppe" + gruppe);
                             FreieStuehleTisch.Remove("Tisch" + stuehle);
                             PersonenGruppe.Remove("Gruppe" + gruppe);
                            }
                    }

                    
                }
            }


           for(int stuehle = 1; stuehle <= FreieStuehleTisch.Count; stuehle++)
            {
                for (int gruppe = 1; gruppe < PersonenGruppe.Count; gruppe++)
                {
                    if(neueBelegung.ContainsKey("Tisch" + stuehle) && PersonenGruppe.ContainsKey("Gruppe" + gruppe))
                    {
                        if (neueBelegung["Tisch" + stuehle] >= PersonenGruppe["Gruppe" + gruppe])
                        {
                            Console.WriteLine("Gruppe " + gruppe + " nehmen Sie doch bitte an Tisch" + stuehle + " Platz");
                            int neueBelegungStuehle = FreieStuehleTisch["Tisch" + stuehle] - PersonenGruppe["Gruppe" + gruppe];
                            PersonenGruppe.Remove("Gruppe" + gruppe);
                            neueBelegung["Tisch" + stuehle] = neueBelegungStuehle;
                            GruppeTisch.Add("Tisch" + stuehle, "Gruppe" + gruppe);
                        }
                    }
  
                }

            }


            for (int gruppe = 0; gruppe < PersonenGruppe.Count; gruppe++)
            {
                if(PersonenGruppe.ContainsKey("Gruppe"+gruppe))
                { 
                  Console.WriteLine("Gruppe " + gruppe + "! Leider haben wir heute keinen Platz für Sie");
                }
            }
        }
    }
}                       
                       