using System;

class Program
{

    static void Main()
    {
        string enteredNumberString;




        Console.WriteLine("Iveskite skaiciu nuo -9 iki 9: \n");
        enteredNumberString = Console.ReadLine();

        CheckIfEnteredTextIsNumber(enteredNumberString);
        ConvertAndCheckRange(enteredNumberString);

        Console.ReadKey();
    }

    static bool CheckIfEnteredTextIsNumber(string enteredNumberString)
    {
        if (Int32.TryParse(enteredNumberString, out int number))
        {
            
            Console.WriteLine("Ivestas skaicius: " + number);
            return true;
        }
        else
        {
            Console.WriteLine("Ivestas ne skaicius");
            return false;
        }
    }

    static void ConvertAndCheckRange(string enteredNumberString)
    {
        if (Int32.TryParse(enteredNumberString, out int stringToNumber))
        {
     
            if (stringToNumber >= -9 && stringToNumber <= 9)
            {
                Console.WriteLine("Skaicius " + stringToNumber + " atitinka nurodytus rezius");

            

                string numberToWord = changeOnesToText(stringToNumber);

                Console.WriteLine("Ivestas skaicius " + stringToNumber + " zodziais yra: " + numberToWord);

            } else {
                Console.WriteLine("Ivestas skaicius neatitinka reziu.");
            }
          
        }
        else
        {
            Console.WriteLine("Ivestas ne skaicius, negalima konvertuoti.");
            
        }
    }

    static string changeOnesToText(int stringToNumber)
    {
        string numberToWords = "";
        string minus = "Minus";
        string firstSymbol = stringToNumber.ToString().Substring(0, 1);

        if (firstSymbol != "-")
        {

            switch (stringToNumber)
            {
                case 0:
                    numberToWords = "Nulis";
                    break;
                case 1:
                    numberToWords = "Vienas";
                    break;
                case 2:
                    numberToWords = "Du";
                    break;
                case 3:
                    numberToWords = "Trys";
                    break;
                case 4:
                    numberToWords = "Keturi";
                    break;
                case 5:
                    numberToWords = "Penki";
                    break;
                case 6:
                    numberToWords = "Sesi";
                    break;
                case 7:
                    numberToWords = "Septyni";
                    break;
                case 8:
                    numberToWords = "Astuoni";
                    break;
                case 9:
                    numberToWords = "Devyni";
                    break;

            }
        }else
        {
            switch (stringToNumber)
            {
                case -0:
                    numberToWords =String.Concat(minus," ", "nulis");
                    break;
                case -1:
                    numberToWords = String.Concat(minus, " ", "vienas");
                    break;
                case -2:
                    numberToWords = String.Concat(minus, " ", "du");
                    break;
                case -3:
                    numberToWords = String.Concat(minus, " ", "trys");
                    break;
                case -4:
                    numberToWords = String.Concat(minus, " ", "keturi");
                    break;
                case -5:
                    numberToWords = String.Concat(minus, " ", "penki");
                    break;
                case -6:
                    numberToWords = String.Concat(minus, " ", "sesi");
                    break;
                case -7:
                    numberToWords = String.Concat(minus, " ", "septyni");
                    break;
                case -8:
                    numberToWords = String.Concat(minus, " ", "astuoni"); 
                    break;
                case -9:
                    numberToWords = String.Concat(minus, " ", "devyni");
                    break;

            }
        }
        return numberToWords;
    }

}