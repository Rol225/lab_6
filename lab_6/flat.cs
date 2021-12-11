using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
	class Flat
	{
		private int coin; //цена
		private int countRoom; //кол-во комнат
		private int numFlat; //Номер квартиры

		public void Set(int coin_2, int countRoom_2, int numFlat_2) {
			if (coin_2 <= 0)
			{
				this.coin = 0;
			}
			else
			{
				this.coin = coin_2;
			}
			if (countRoom_2 <= 0)
			{
				this.countRoom = 0;
			}
			else
			{
				this.countRoom = countRoom_2;
			}
			if (numFlat_2 <= 0)
			{
				this.numFlat = 0;
			}
			else
			{
				this.numFlat = numFlat_2;
			}
		} // Функция ввода через внешнюю функцию
		public void Set_console() {
			Console.WriteLine("\nВыберите стоимость квартиры: ");
			do
			{
				while (!int.TryParse(Console.ReadLine(), out coin)) { Console.WriteLine("Ошибка. Введите число: "); }
			} while (coin <= 0);

			Console.WriteLine("Выберите кол-во комнат: ");
			do
			{
				while (!int.TryParse(Console.ReadLine(), out countRoom)) { Console.WriteLine("Ошибка. Введите число: "); }
			} while (countRoom <= 0);

			Console.WriteLine("Номер квартиры: ");
			do
			{
				while (!int.TryParse(Console.ReadLine(), out numFlat)) { Console.WriteLine("Ошибка. Введите число: "); }
			} while (numFlat <= 0);
		}  // Функция ввода через встроенную функцию
		public void Print() {
			Console.WriteLine("\n  Цена: {0}", coin);
			Console.WriteLine("  Количество комнат: {0}", countRoom);
			Console.WriteLine("  Номер квартиры: {0}\n", numFlat);
		} // Функция вывода

		/// Функции вывода каждой отдельной переменной
		public int Coin {
			get => coin;
			set => coin = value;
		}
		public int Count_room {
			get => countRoom;
			set => countRoom = value;
		}
		public int Num_flat {
			get => numFlat;
			set => numFlat = value;
		}
	}

}
