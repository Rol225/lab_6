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

		public Location()
		{
			this.distanceHospital = 0;
			this.distanceKindergarten = 0;
			this.distanceSchool = 0;
			this.houseStreet = "";
			this.numHouse = 0;
		}
		public Location(int numHouse_new)
		{
			this.distanceHospital = 0;
			this.distanceKindergarten = 0;
			this.distanceSchool = 0;
			this.houseStreet = "";
            try
            {
				if (numHouse_new <= 0)
				{
					this.numHouse = 0;
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
				else
				{
					this.numHouse = numHouse_new;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
		}
		public Location(int distanceSchool_new, int distanceHospital_new, int distanceKindergarten_new, string houseStreet_new, int numHouse_new)
		{
            try
            {
				if (distanceSchool_new <= 0)
				{
					this.distanceSchool = 0;
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
				else
				{
					this.distanceSchool = distanceSchool_new;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			try
			{
				if (distanceHospital_new <= 0)
				{
					this.distanceHospital = 0;
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
				else
				{
					this.distanceHospital = distanceHospital_new;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			try
			{
				if (distanceKindergarten_new <= 0)
				{
					this.distanceKindergarten = 0;
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
				else
				{
					this.distanceKindergarten = distanceKindergarten_new;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			try
			{
				if (numHouse_new <= 0)
				{
					this.numHouse = 0;
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
				else
				{
					this.numHouse = numHouse_new;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			try
			{
				if (houseStreet_new[0] != '\0')
				{
					this.houseStreet = houseStreet_new;
				}
				else
				{
					this.houseStreet = "Error";
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
		}
		public void Set(int distanceSchool_2, int distanceHospital_2, int distanceKindergarten_2, string houseStreet_2, int numHouse_2)
		{
			try
			{
				if (distanceSchool_2 <= 0)
				{
					this.distanceSchool = 0;
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
				else
				{
					this.distanceSchool = distanceSchool_2;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			try
			{
				if (distanceHospital_2 <= 0)
				{
					this.distanceHospital = 0;
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
				else
				{
					this.distanceHospital = distanceHospital_2;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			try
			{
				if (distanceKindergarten_2 <= 0)
				{
					this.distanceKindergarten = 0;
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
				else
				{
					this.distanceKindergarten = distanceKindergarten_2;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			try
			{
				if (numHouse_2 <= 0)
				{
					this.numHouse = 0;
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
				else
				{
					this.numHouse = numHouse_2;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
			}
			try
			{
				if (houseStreet_2 != null)
				{
					this.houseStreet = houseStreet_2;
				}
				else
				{
					this.houseStreet = "Error";
					throw new Exception("Ошибка присваивания значения переменной обьекта!");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка!");
				Console.WriteLine(ex);
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
		public int Distance_school {
			get => distanceSchool;
			set => distanceSchool = value;
		}
		public int Distance_hospital {
			get => distanceHospital;
			set => distanceHospital = value;
		}
		public int Distance_kindergarten {
			get => distanceKindergarten;
			set => distanceKindergarten = value;
		}
		public int Num_house {
			get => numHouse;
			set => numHouse = value;
		}
		public string House_street {
			get => houseStreet;
			set => houseStreet = value;
		}
		public void OutData(out int distanceSchool, out int distanceHospital, out int distanceKindergarten)
		{
			distanceSchool = this.distanceSchool;
			distanceHospital = this.distanceHospital;
			distanceKindergarten = this.distanceKindergarten;
		}
		public void RefData(ref string houseStreet, ref int numHouse)
		{
			houseStreet = this.houseStreet;
			numHouse = this.numHouse;
		}
	}
}
