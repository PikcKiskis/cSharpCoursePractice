using System;

class Program
{

    static void Main()
    {
        string enteredNumberString;




        Console.WriteLine("Iveskite skaiciu nuo -9 iki 9: \n");
        enteredNumberString = Console.ReadLine();

       // CheckIfEnteredTextIsNumber(enteredNumberString);
        ConvertAndCheckRange(enteredNumberString);

        Console.ReadKey();
    }

    static bool CheckIfEnteredTextIsNumber(string enteredNumberString)
    {
        if (Int32.TryParse(enteredNumberString, out int number))
        {
            
            Console.WriteLine("Ivestas skaicius" + number);
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

    static string changeOnesToText(int enteredNumberString)
    {
        string numberToWords = "";
        switch(enteredNumberString)
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

        return numberToWords;
    }

}