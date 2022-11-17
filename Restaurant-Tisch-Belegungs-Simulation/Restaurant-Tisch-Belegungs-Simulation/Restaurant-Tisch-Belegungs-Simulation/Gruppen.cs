using System;
using System.Collections.Generic;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Gruppen

    {
        int AnzahlGruppen()
        {
            var Gruppen = new Random();
            int NumbersOfGroups = Gruppen.Next(1, 10);
            return NumbersOfGroups;

        }

        public void getPersonen()
        {
            Dictionary<string, bool> BelegungStuehle = new Dictionary<string, bool>();

            int gruppen = AnzahlGruppen();

            for (int i = 1; i < gruppen; i++)
            {
                Random personen = new Random();
                int AnzahlPersonen = personen.Next(2, 10);
                Program.PersonenGruppe.Add("Gruppe" + i, AnzahlPersonen);
            }

        }
    }
}
