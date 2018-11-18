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
            
            Console.WriteLine("Ivestas skaicius." + number);
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
                Console.WriteLine("Test");

            } else {
                Console.WriteLine("Ivestas skaicius neatitinka reziu.");
            }
          
        }
        else
        {
            Console.WriteLine("Ivestas ne skaicius, negalima konvertuoti.");
            
        }
    }

}