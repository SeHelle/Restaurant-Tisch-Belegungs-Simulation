using System;
using System.Collections.Generic;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Gruppen: Program
    {
        int anzahlGruppen()
        {
            Random gruppen = new Random();
            int numbersOfGroups = gruppen.Next(1, 10);
            return numbersOfGroups;
        }

        public void getPersonen(int von, int bis)
        {
            Dictionary<string, bool> belegungStuehle = new Dictionary<string, bool>();

            int gruppen = anzahlGruppen();

            for (int i = 1; i < gruppen; i++)
            {
                Random personen = new Random();
                int AnzahlPersonen = personen.Next(von, bis);
                personenGruppe.Add("Gruppe" + i, AnzahlPersonen);
                mappingGruppen.Add("Gruppe" + 1, AnzahlPersonen);
            }

        }
    }
}
