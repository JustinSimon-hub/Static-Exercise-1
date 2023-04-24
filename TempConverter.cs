using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		 static TempConverter()
		{
		}
		//This assignment uses static access meaning that there is no requirment for a instantiation to access these members 
		//and the members actually belong to the class and not the object of the class
		//In this problem the static props. farenheight and celsius are going to be initialized via the Console.ReadLine method and then plugged into the two methods below to convert them
		public  static double farenheight {get; set;}
		public static double celsius {get; set;}
		public static double FahrenheitToCelsius(double farenheight)
		{
				  double b = (farenheight - 32) * 5 / 9;
				 return b;
		}
		public static double CelsiusToFarenheit(double celsius)
		{
				double d = (celsius * 9 / 5) + 32;
    			return d;
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