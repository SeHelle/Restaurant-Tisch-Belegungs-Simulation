using System;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Restaurant : BenoetigteDictionary
    {  
        private static int erzeugeTische ()
        {
            Random tables = new Random();
            var numberofTables = tables.Next(1, 10);
            return numberofTables;
        }

        public void erzeugeStuehle(int von, int bis)
        {
            int tables = erzeugeTische();

            for (int i = 1; i < tables; i++)
            {
                Random stuehle = new Random();
                int anzahlStuehle = stuehle.Next(von, bis);
                freieStuehleTisch.Add("Tisch" + i, anzahlStuehle);
            }

        }
    }
}
