namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           var farenheit = TempConverter.CelsiusToFahrenheit = 15.7;
           var celsius = TempConverter.FahrenheitToCelsius = 90.5;
          Console.WriteLine("Before conversion");
           Console.WriteLine(farenheit);
           Console.WriteLine("***********");
           Console.WriteLine("After conversion");
           Console.WriteLine(celsius);
       
        }
    }
}
/*Create a static class called TempConverter. 

The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter and return a double, the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.

Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!
*/