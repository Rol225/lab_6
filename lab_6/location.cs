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

		Location()
		{
			this.distanceHospital = 0;
			this.distanceKindergarten = 0;
			this.distanceSchool = 0;
			this.houseStreet = "";
			this.numHouse = 0;
		}
		Location(int numHouse_new)
		{
			this.distanceHospital = 0;
			this.distanceKindergarten = 0;
			this.distanceSchool = 0;
			this.houseStreet = "";
			if (numHouse_new <= 0)
			{
				this.numHouse = 0;
			}
			else
			{
				this.numHouse = numHouse_new;
			}
		}
		Location(int distanceSchool_new, int distanceHospital_new, int distanceKindergarten_new, string houseStreet_new, int numHouse_new)
		{
			if (distanceSchool_new <= 0)
			{
				this.distanceSchool = 0;
			}
			else
			{
				this.distanceSchool = distanceSchool_new;
			}
			if (distanceHospital_new <= 0)
			{
				this.distanceHospital = 0;
			}
			else
			{
				this.distanceHospital = distanceHospital_new;
			}
			if (distanceKindergarten_new <= 0)
			{
				this.distanceKindergarten = 0;
			}
			else
			{
				this.distanceKindergarten = distanceKindergarten_new;
			}
			if (numHouse_new <= 0)
			{
				this.numHouse = 0;
			}
			else
			{
				this.numHouse = numHouse_new;
			}
			if (houseStreet_new[0] != '\0')
			{
				this.houseStreet = houseStreet_new;
			}
			else
			{
				this.houseStreet = "Error";
			}
		}
		public void Set(int distanceSchool_2, int distanceHospital_2, int distanceKindergarten_2, string houseStreet_2, int numHouse_2)
		{
			if (distanceSchool_2 <= 0)
			{
				this.distanceSchool = 0;
			}
			else
			{
				this.distanceSchool = distanceSchool_2;
			}
			if (distanceHospital_2 <= 0)
			{
				this.distanceHospital = 0;
			}
			else
			{
				this.distanceHospital = distanceHospital_2;
			}
			if (distanceKindergarten_2 <= 0)
			{
				this.distanceKindergarten = 0;
			}
			else
			{
				this.distanceKindergarten = distanceKindergarten_2;
			}
			if (numHouse_2 <= 0)
			{
				this.numHouse = 0;
			}
			else
			{
				this.numHouse = numHouse_2;
			}
			if (houseStreet_2 != null)
			{
				this.houseStreet = houseStreet_2;
			}
			else
			{
				this.houseStreet = "Error";
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
