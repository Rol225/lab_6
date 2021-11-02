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
				coin = 0;
			}
			else
			{
				coin = coin_2;
			}
			if (countRoom_2 <= 0)
			{
				countRoom = 0;
			}
			else
			{
				countRoom = countRoom_2;
			}
			if (numFlat_2 <= 0)
			{
				numFlat = 0;
			}
			else
			{
				numFlat = numFlat_2;
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
		public int Get_coin() { return coin; }
		public int Get_count_room() { return countRoom; }
		public int Get_num_flat() { return numFlat; }
	}

}
