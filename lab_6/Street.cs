using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
    class Street
    {
		private string streetName;
		private string streetDescription;

		public void Set(string streetName_2, string streetDescription_2)
		{
			if (streetName_2 != null)
			{
				streetName = streetName_2;
			}
			else
			{
				streetName = "Error";
			}
			if (streetName_2 != null)
			{
				streetDescription = streetDescription_2;
			}
			else
			{
				streetDescription = "Error";
			}
		}// Функция ввода через встроенную функцию
		public void Set_console() 
		{
			Console.WriteLine("\nУлица: ");
			streetName = Console.ReadLine();
			Console.WriteLine("Описание улици: ");
			streetDescription = Console.ReadLine();
		} // Функция ввода через внешнюю функцию
		public void Print() 
		{
			Console.WriteLine("\n  Улица: {0}", streetName);
			Console.WriteLine("  Описание улицы: {0}\n", streetDescription);
		} // Функция вывода

		/// Функции вывода каждой отдельной переменной
		public string Get_street_name() { return streetName; }
		public string Get_street_description() { return streetDescription; }
	}
}
