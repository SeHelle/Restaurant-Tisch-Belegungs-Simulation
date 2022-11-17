using System;
using System.Collections.Generic;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Restaurant : Program
    {   

        public void bauen()
        {
            getStuehle();
        }
           
        public int getTische (){

            var Tables = new Random();

            var NumberofTables = Tables.Next(1, 10);

            return NumberofTables;

        }

        
        public void getStuehle()
        {
            List<string> BelegungStuehle = new List<string>();

            int tables = getTische();

            for (int i = 1; i < tables; i++)
            {
                Random stuehle = new Random();
                int AnzahlStuehle = stuehle.Next(2, 10);
                FreieStuehleTisch.Add("Tisch" + i, AnzahlStuehle);
              
            }

          
        }


    }
}
