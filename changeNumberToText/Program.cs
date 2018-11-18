using System;

class Program
{

    static void Main()
    {
        string enteredNumberString;

        Console.WriteLine("Iveskite skaiciu nuo -19 iki 19: \n");
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

            if (stringToNumber >= -19 && stringToNumber <= 19)
            {
                Console.WriteLine("Skaicius " + stringToNumber + " atitinka nurodytus rezius");

                string numberToWord;
                if (stringToNumber >= -9 && stringToNumber <= 9)
                {
                    numberToWord = ChangeOnesToText(stringToNumber);
                }
                else
                {
                    numberToWord = ChangeTensToText(stringToNumber);
                }


                Console.WriteLine("Ivestas skaicius " + stringToNumber + " zodziais yra: " + numberToWord);

            }
            else
            {
                Console.WriteLine("Ivestas skaicius neatitinka reziu.");
            }

        }
        else
        {
            Console.WriteLine("Ivestas ne skaicius, negalima konvertuoti.");

        }
    }

    static string ChangeOnesToText(int stringToNumber)
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
        }
        else
        {
            switch (stringToNumber)
            {
                case -0:
                    numberToWords = String.Concat(minus, " ", "nulis");
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


    static string ChangeTensToText(int stringToNumber)
    {
        string numberToWords = "";
        string minus = "Minus";
        string firstSymbol = stringToNumber.ToString().Substring(0, 1);

        if (firstSymbol != "-")
        {

            switch (stringToNumber)
            {
                case 10:
                    numberToWords = "Desimt";
                    break;
                case 11:
                    numberToWords = "Vienuolika";
                    break;
                case 12:
                    numberToWords = "Dvylika";
                    break;
                case 13:
                    numberToWords = "Trylika";
                    break;
                case 14:
                    numberToWords = "Keturiolika";
                    break;
                case 15:
                    numberToWords = "Penkiolika";
                    break;
                case 16:
                    numberToWords = "Sesiolika";
                    break;
                case 17:
                    numberToWords = "Septyniolika";
                    break;
                case 18:
                    numberToWords = "Astuoniolika";
                    break;
                case 19:
                    numberToWords = "Devyniolika";
                    break;
            }

            return numberToWords;

        }
        else
        {
            switch (stringToNumber)
            {
                case -10:
                    numberToWords = String.Concat(minus, " ", "desimt");
                    break;
                case -11:
                    numberToWords = String.Concat(minus, " ", "vienuolika");
                    break;
                case -12:
                    numberToWords = String.Concat(minus, " ", "dvylika");
                    break;
                case -13:
                    numberToWords = String.Concat(minus, " ", "trylika");
                    break;
                case -14:
                    numberToWords = String.Concat(minus, " ", "keturiolika");
                    break;
                case -15:
                    numberToWords = String.Concat(minus, " ", "penkiolika");
                    break;
                case -16:
                    numberToWords = String.Concat(minus, " ", "sesiolika");
                    break;
                case -17:
                    numberToWords = String.Concat(minus, " ", "septyniolika");
                    break;
                case -18:
                    numberToWords = String.Concat(minus, " ", "astuoniolika");
                    break;
                case -19:
                    numberToWords = String.Concat(minus, " ", "devyniolika");
                    break;
            }
            return numberToWords;
        }
    }

}