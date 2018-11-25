using System;
using System.Linq;

class Program
{

    static void Main()
    {

        const int MINVALUE = 100000;
        const int MAXVALUE = 999999;


        char[] skaitmenuMasyvasChar = new char[6];
        int[] paverstasISkaitmenuMasyva = new int[6];
        int[] paverstasISkaitmenuMasyvaPadaugintasSk = new int[6];
        int[] paverstasISkaitmenuMasyvaPadaugintasSk3 = new int[6];
        int[] paverstasISkaitmenuMasyvaPadaugintasSk4 = new int[6];
        int[] paverstasISkaitmenuMasyvaPadaugintasSk5 = new int[6];
        int[] paverstasISkaitmenuMasyvaPadaugintasSk6 = new int[6];

        bool arSkaitmenysSkirtingi;
        bool arPadaugintiSkaitmenysSkirtingi;

        for (int j = MINVALUE; j <= MAXVALUE; j++)
        {   
            int padaugintasSkaicius = 0;
            int padaugintasSkaiciusIs3 = 0;
            int padaugintasSkaiciusIs4 = 0;
            int padaugintasSkaiciusIs5 = 0;
            int padaugintasSkaiciusIs6 = 0;

            int paimtasSkaicius = j;
            paverstasISkaitmenuMasyva = PaverstiIntSkaiciuIIntMasyva(paimtasSkaicius);
            arSkaitmenysSkirtingi = ArVisiSkaitmenysSkirtingi(paverstasISkaitmenuMasyva);

            //Console.WriteLine(arSkaitmenysSkirtingi);

            if (arSkaitmenysSkirtingi)
            {
                padaugintasSkaicius = paimtasSkaicius * 2;
    
                if (padaugintasSkaicius.ToString().Length == 6)
                {
                    paverstasISkaitmenuMasyvaPadaugintasSk = PaverstiIntSkaiciuIIntMasyva(padaugintasSkaicius);
                    arPadaugintiSkaitmenysSkirtingi = ArVisiSkaitmenysSkirtingi(paverstasISkaitmenuMasyvaPadaugintasSk);
                    if (arPadaugintiSkaitmenysSkirtingi)
                    {
                        bool arSutapoPaprastasIrPadaugintasIs2;
                        arSutapoPaprastasIrPadaugintasIs2 = PalygintiDuIntMasyvusSuSkaitmenimis(paverstasISkaitmenuMasyva, paverstasISkaitmenuMasyvaPadaugintasSk);
                        if (arSutapoPaprastasIrPadaugintasIs2)
                        {
                            padaugintasSkaiciusIs3 = paimtasSkaicius * 3;
                            if (padaugintasSkaiciusIs3.ToString().Length == 6)
                            {
                                paverstasISkaitmenuMasyvaPadaugintasSk3 = PaverstiIntSkaiciuIIntMasyva(padaugintasSkaiciusIs3);
                                arPadaugintiSkaitmenysSkirtingi = ArVisiSkaitmenysSkirtingi(paverstasISkaitmenuMasyvaPadaugintasSk3);
                                if (arPadaugintiSkaitmenysSkirtingi)
                                {
                                    bool arSutapoPaprastasIrPadaugintasIs3;
                                    arSutapoPaprastasIrPadaugintasIs3 = PalygintiDuIntMasyvusSuSkaitmenimis(paverstasISkaitmenuMasyva, paverstasISkaitmenuMasyvaPadaugintasSk3);
                                    if (arSutapoPaprastasIrPadaugintasIs3)
                                    {
                                        padaugintasSkaiciusIs4 = paimtasSkaicius * 4;
                                        if (padaugintasSkaiciusIs4.ToString().Length == 6)
                                        {
                                            paverstasISkaitmenuMasyvaPadaugintasSk4 = PaverstiIntSkaiciuIIntMasyva(padaugintasSkaiciusIs4);
                                            arPadaugintiSkaitmenysSkirtingi = ArVisiSkaitmenysSkirtingi(paverstasISkaitmenuMasyvaPadaugintasSk4);
                                            if (arPadaugintiSkaitmenysSkirtingi)
                                            {
                                                bool arSutapoPaprastasIrPadaugintasIs4;
                                                arSutapoPaprastasIrPadaugintasIs4 = PalygintiDuIntMasyvusSuSkaitmenimis(paverstasISkaitmenuMasyva, paverstasISkaitmenuMasyvaPadaugintasSk4);
                                                if (arSutapoPaprastasIrPadaugintasIs4)
                                                {
                                                    
                                                    padaugintasSkaiciusIs5 = paimtasSkaicius * 5;
                                                    if (padaugintasSkaiciusIs5.ToString().Length == 6)
                                                    {
                                                        paverstasISkaitmenuMasyvaPadaugintasSk5 = PaverstiIntSkaiciuIIntMasyva(padaugintasSkaiciusIs5);
                                                        arPadaugintiSkaitmenysSkirtingi = ArVisiSkaitmenysSkirtingi(paverstasISkaitmenuMasyvaPadaugintasSk5);
                                                        if (arPadaugintiSkaitmenysSkirtingi)
                                                        {
                                                            bool arSutapoPaprastasIrPadaugintasIs5;
                                                            arSutapoPaprastasIrPadaugintasIs5 = PalygintiDuIntMasyvusSuSkaitmenimis(paverstasISkaitmenuMasyva, paverstasISkaitmenuMasyvaPadaugintasSk5);
                                                            if (arSutapoPaprastasIrPadaugintasIs5)
                                                            {
                                                                padaugintasSkaiciusIs6 = paimtasSkaicius * 6;
                                                                if(padaugintasSkaiciusIs6.ToString().Length == 6)
                                                                {
                                                                    paverstasISkaitmenuMasyvaPadaugintasSk6 = PaverstiIntSkaiciuIIntMasyva(padaugintasSkaiciusIs6);
                                                                    arPadaugintiSkaitmenysSkirtingi = ArVisiSkaitmenysSkirtingi(paverstasISkaitmenuMasyvaPadaugintasSk6);
                                                                    if (arPadaugintiSkaitmenysSkirtingi)
                                                                    {
                                                                        bool arSutapoPaprastasIrPadaugintasIs6;
                                                                        arSutapoPaprastasIrPadaugintasIs6 = PalygintiDuIntMasyvusSuSkaitmenimis(paverstasISkaitmenuMasyva, paverstasISkaitmenuMasyvaPadaugintasSk6);
                                                                        if (arSutapoPaprastasIrPadaugintasIs6)
                                                                        {
                                                                            Console.WriteLine("Magiskas skaicius: \n");
                                                                            for (int p = 0; p < paverstasISkaitmenuMasyva.Length; p++)
                                                                            {
                                                                                Console.Write(paverstasISkaitmenuMasyva[p]);

                                                                            }
                                                                            Console.WriteLine("\n");
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }

                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                }

            }

        }


        bool PalygintiDuIntMasyvusSuSkaitmenimis(int[] paprastasMasyvas, int[] padaugintasMasyvas)
        {
            int skaitmuo1 = 0;
            int skaitmuo2 = 0;
            int sutapoSkaiciu = 0;
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        skaitmuo1 = paprastasMasyvas[j];
                        skaitmuo2 = padaugintasMasyvas[k];

                        if (skaitmuo1 == skaitmuo2)
                        {
                            sutapoSkaiciu++;
                            

                        }
                    }
                }
                if (sutapoSkaiciu == 6)
                {
                
                return true;
                }
                return false;
        }


        int[] PaverstiIntSkaiciuIIntMasyva(int skaicius)
        {
            int[] skaitmenuMasyvasInt = new int[6];
            string paimtasSkaiciusIString = skaicius.ToString();

            for (int n = 0; n < paimtasSkaiciusIString.Length; n++)
            {
                skaitmenuMasyvasChar[n] = paimtasSkaiciusIString[n];
                //Console.WriteLine(skaitmenuMasyvasChar[n]);
            }

            for (int m = 0; m < skaitmenuMasyvasChar.Length; m++)
            {

               if (int.TryParse(skaitmenuMasyvasChar[m].ToString(), out int result))
               {
                   int digit = result;
                   skaitmenuMasyvasInt[m] = digit;
               }

            }

            

            return skaitmenuMasyvasInt;
        }



        bool ArVisiSkaitmenysSkirtingi(int[] skaiciausSkaitmenysMasyveInt)
        {

            for (int i = 0; i < skaiciausSkaitmenysMasyveInt.Length; i++)
            {
                for (int j = i; j < skaiciausSkaitmenysMasyveInt.Length-1; j++)
                {
                    int skaitmuo1 = skaiciausSkaitmenysMasyveInt[i];
                    int skaitmuo2 = skaiciausSkaitmenysMasyveInt[j+1];

                    if (skaitmuo1 == skaitmuo2)
                    {
                        //Console.WriteLine("Skaiciuje yra vienodu skaitmenu!");
                        return false;
                        
                    }
                }
            }
            return true;
        }

      
        Console.ReadKey();
    }

    
}

