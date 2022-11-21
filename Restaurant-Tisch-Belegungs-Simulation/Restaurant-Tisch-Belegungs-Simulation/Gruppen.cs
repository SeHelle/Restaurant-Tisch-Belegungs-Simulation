using System;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Gruppen: BenoetigteDictionary
    {
        int anzahlGruppen()
        {
            Random gruppen = new Random();
            int numbersOfGroups = gruppen.Next(1, 10);
            return numbersOfGroups;
        }

        public void getPersonen(int von, int bis)
        {
            int gruppen = anzahlGruppen();

            for (int i = 1; i < gruppen; i++)
            {
                Random personen = new Random();
                int anzahlPersonen = personen.Next(von, bis);
                personenGruppe.Add("Gruppe" + i, anzahlPersonen);
                mappingGruppen.Add("Gruppe" + i, anzahlPersonen);
            }

        }

    }
}
