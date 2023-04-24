namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
//Uses the static members of the TempConverter class, meaning that no instantiation is neccessary to use the members
//Asks the user for the tempature in the format they would like converted 
//The users input is stored as a varible for the static members: farenheight and celsius 
//Those values are then plugged into the conversion methods and printed to the screen



     Console.WriteLine("What tempature in celsius would you like converted to farenhight?");
            TempConverter.celsius = double.Parse(Console.ReadLine());
           Console.WriteLine($" The tempature for celsius converted to farenheight is: {TempConverter.CelsiusToFarenheit(TempConverter.celsius)}");
           Console.WriteLine("----------------------------------");
           Console.WriteLine("What tempature in farenheight would you like converted to celsius?");
           TempConverter.farenheight = double.Parse(Console.ReadLine());
           Console.WriteLine($"The tempature for farenheight converted to celsius is: {TempConverter.FahrenheitToCelsius(TempConverter.farenheight)}");
        }
    }
}
/*
The class should have at least 2 methods, one called FahrenheitToCelsius 
that will require a double as a parameter and return a double, 
the other CelsiusToFahrenheit which will also require 
a double as a parameter and return a double.

Fill out these methods and call them in your Program.cs file. 
Make sure they’re accurate!

For reference:
https://github.com/mvdoyle/StaticExercise
*/