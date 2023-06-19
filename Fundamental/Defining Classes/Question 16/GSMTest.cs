using System;

namespace Question_16
{
    internal class GSMTest
    {
        internal void Create()
        {
            GSM gsm1 = new GSM();
            GSM gsm2 = new GSM("Itel S32 mini");
            GSM gsm3 = new GSM("Infinix X657C", "IOS");
            GSM gsm4 = new GSM("Itel A36", "Android", 40000.00m);
            GSM gsm5 = new GSM("Itel A32F", "Android", 45000.00m, "ITEL");

            object[] vs = { gsm1, gsm2, gsm3, gsm4, gsm5 };
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine(vs[i].ToString());
                Console.WriteLine("\n");
            }
        } 
    }
}