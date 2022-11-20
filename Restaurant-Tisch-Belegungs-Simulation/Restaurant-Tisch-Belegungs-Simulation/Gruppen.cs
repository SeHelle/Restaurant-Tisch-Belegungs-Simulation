using System;
using System.Collections.Generic;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Gruppen: Program

    {
        int AnzahlGruppen()
        {
            var Gruppen = new Random();
            int NumbersOfGroups = Gruppen.Next(1, 10);
            return NumbersOfGroups;

        }

        public void getPersonen(int von, int bis)
        {
            Dictionary<string, bool> BelegungStuehle = new Dictionary<string, bool>();

            int gruppen = AnzahlGruppen();

            for (int i = 1; i < gruppen; i++)
            {
                Random personen = new Random();
                int AnzahlPersonen = personen.Next(von, bis);
                PersonenGruppe.Add("Gruppe" + i, AnzahlPersonen);
                MappingGruppen.Add("Gruppe" + 1, AnzahlPersonen);
            }

        }
    }
}
