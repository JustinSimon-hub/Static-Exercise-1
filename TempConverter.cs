using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		 static TempConverter()
		{
			
		}
		private static double far2cel;
		public static double FahrenheitToCelsius 
		{
				get{return far2cel;}
				set{far2cel = value;}
		}
		private static double cel2far;
		public static double CelsiusToFahrenheit 
		{
			get{return cel2far;}
			set{cel2far = value;}
		}
		
		
	}
}


//The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter and return a double, the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.
