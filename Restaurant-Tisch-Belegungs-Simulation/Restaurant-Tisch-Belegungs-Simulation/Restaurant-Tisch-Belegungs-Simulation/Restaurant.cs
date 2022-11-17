using System;
using System.Collections.Generic;

namespace Restaurant_Tisch_Belegungs_Simulation
{
    class Restaurant 
    {
           
        public int getTables (){

            var Tables = new Random();

            var NumberofTables = Tables.Next(1, 10);

            return NumberofTables;

        }

        
        public List<string> getStuehle()
        {
            List<string> BelegungStuehle = new List<string>();

            int tables = getTables();

            for (int i = 1; i < tables; i++)
            {
                Random stuehle = new Random();
                int AnzahlStuehle = stuehle.Next(2, 10);
                Program.FreieStuehleTisch.Add("Tisch" + i, AnzahlStuehle);
                for (int z = 1; z < AnzahlStuehle; z++)
                {
                    BelegungStuehle.Add("Tisch" + i + "" + " Stuhl" + z);

                }

            }

            return BelegungStuehle;
        }


    }
}
