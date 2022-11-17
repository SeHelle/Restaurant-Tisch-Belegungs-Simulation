using System;
using System.Collections.Generic;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Restaurant : Program
    {   

       
           
        public int erzeugeTische (){

            var Tables = new Random();

            var NumberofTables = Tables.Next(1, 10);

            return NumberofTables;

        }

        
        public void erzeugeStuehle(int von, int bis)
        {
            List<string> BelegungStuehle = new List<string>();

            int tables = erzeugeTische();

            for (int i = 1; i < tables; i++)
            {
                Random stuehle = new Random();
                int AnzahlStuehle = stuehle.Next(von, bis);
                FreieStuehleTisch.Add("Tisch" + i, AnzahlStuehle);
                
            }

          AnzahlTische = FreieStuehleTisch.Count;
        }


    }
}
