using System;


public class TempConversion
{
    public static void Main()
    {
        Console.WriteLine("Please enter the temp to be converted to Fahrenheit scale: ");

        double tempInCelsius = double.Parse(Console.ReadLine());

        double tempInFahr = (tempInCelsius * 9 / 5) + 32;


        if(tempInFahr <=32)
        {
            Console.WriteLine($"Converted in F: {tempInFahr}\n It is very cold today!!");


        }
        else
        {
            Console.WriteLine($"Converted in F: {tempInFahr}\n It is not very cold today!!");

        }

    }


}