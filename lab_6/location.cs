using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
    class Location
    {
		private int distanceSchool; //Расстояние до школы
		private int distanceHospital;//Расстояние до больници
		private int distanceKindergarten;//Расстояние до детского сада
		private string houseStreet; //адрес дома
		private int numHouse;

		public void Set(int distanceSchool_2, int distanceHospital_2, int distanceKindergarten_2, string houseStreet_2, int numHouse_2)
		{
			if (distanceSchool_2 <= 0)
			{
				distanceSchool = 0;
			}
			else
			{
				distanceSchool = distanceSchool_2;
			}
			if (distanceHospital_2 <= 0)
			{
				distanceHospital = 0;
			}
			else
			{
				distanceHospital = distanceHospital_2;
			}
			if (distanceKindergarten_2 <= 0)
			{
				distanceKindergarten = 0;
			}
			else
			{
				distanceKindergarten = distanceKindergarten_2;
			}
			if (numHouse_2 <= 0)
			{
				numHouse = 0;
			}
			else
			{
				numHouse = numHouse_2;
			}
			if (houseStreet_2 != null)
			{
				houseStreet = houseStreet_2;
			}
			else
			{
				houseStreet = "Error";
			}
		}//Функция ввода через внешнюю функцию
		public void Set_console()
		{
			Console.WriteLine("\nВыберите расстояние до школы: ");
			do
			{
				while (!int.TryParse(Console.ReadLine(), out distanceSchool)) { Console.WriteLine("Ошибка. Введите число: "); }
			} while (distanceSchool <= 0);

			Console.WriteLine("Выберите расстояние до больницы: ");
			do
			{
				while (!int.TryParse(Console.ReadLine(), out distanceHospital)) { Console.WriteLine("Ошибка. Введите число: "); }
			} while (distanceHospital <= 0);


			Console.WriteLine("Выберите расстояние до детского сада: ");
			do
			{
				while (!int.TryParse(Console.ReadLine(), out distanceKindergarten)) { Console.WriteLine("Ошибка. Введите число: "); }
			} while (distanceKindergarten <= 0);

			Console.WriteLine("Номер дома: ");
			do
			{
				while (!int.TryParse(Console.ReadLine(), out numHouse)) { Console.WriteLine("Ошибка. Введите число: "); }
			} while (numHouse <= 0);

			Console.WriteLine("\nУлица: "); houseStreet = Console.ReadLine();
		}//Функция ввода через встроенную функцию
		public void Print()
		{
			Console.WriteLine("\n  Расстояние до школы: {0}", distanceSchool);
			Console.WriteLine("  Расстояние до больницы: {0}", distanceHospital);
			Console.WriteLine("  Расстояние до детскогосада: {0}", distanceKindergarten);
			Console.WriteLine("  Название улицы: {0}", houseStreet);
			Console.WriteLine("  Номер дома: {0}\n", numHouse);
		} //Вывод
		/// Вывод каждой отдельной переменной
		public int Get_distance_school() { return distanceSchool; }
		public int Get_distance_hospital() { return distanceHospital; }
		public int Get_distance_kindergarten() { return distanceKindergarten; }
		public int Get_num_house() { return numHouse; }
		public string Get_house_street() { return houseStreet; }
	}
}
