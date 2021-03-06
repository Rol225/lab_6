using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
    class Street
    {
		private string streetName;
		private string streetDescription;

		public Street()
		{
			this.streetName = "";
			this.streetDescription = "";
		}
		public Street(string streetName_2)
		{
			this.streetDescription = "";
			try
			{
				if (streetName_2[0] != '\0')
				{
					this.streetName = streetName_2;
				}
				else
				{
					this.streetName = "Error";
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
		}
		public Street(string streetName_new, string streetDescription_new)
		{
            try
            {
				if (streetName_new[0] != '\0')
				{
					this.streetName = streetName_new;
				}
				else
				{
					this.streetName = "Error";
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			try
			{
				if (streetName_new[0] != '\0')
				{
					this.streetDescription = streetDescription_new;
				}
				else
				{
					this.streetDescription = "Error";
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			
			
		}
		public void Set(string streetName_2, string streetDescription_2)
		{
            try
            {
				if (streetName_2 != null)
				{
					this.streetName = streetName_2;
				}
				else
				{
					this.streetName = "Error";
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			try
			{
				if (streetName_2 != null)
				{
					this.streetDescription = streetDescription_2;
				}
				else
				{
					this.streetDescription = "Error";
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			
			
		}// Функция ввода через встроенную функцию
		public void Set_console() 
		{
			Console.WriteLine("\nУлица: ");
			this.streetName = Console.ReadLine();
			Console.WriteLine("Описание улици: ");
			this.streetDescription = Console.ReadLine();
		} // Функция ввода через внешнюю функцию
		public void Print() 
		{
			Console.WriteLine("\n  Улица: {0}", streetName);
			Console.WriteLine("  Описание улицы: {0}\n", streetDescription);
		} // Функция вывода

		/// Функции вывода каждой отдельной переменной
		public string Street_name
		{
			get => streetName;
			set => streetName = value;
		}
		public string Street_description {
			get => streetDescription;
			set => streetDescription = value;
		}
	}
}
