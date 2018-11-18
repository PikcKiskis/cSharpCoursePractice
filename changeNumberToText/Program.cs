using System;

class Program
{

    static void Main()
    {
        string enteredNumberString;

        Console.WriteLine("Iveskite skaiciu nuo -9 iki 9: \n");
        enteredNumberString = Console.ReadLine();

        CheckIfEnteredTextIsNumber(enteredNumberString);

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

}