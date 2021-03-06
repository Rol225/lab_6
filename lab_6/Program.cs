using System;

namespace lab_6

{
    class Program
    {
        static void Main(string[] args)
        {
			int option;

			do
			{
				 Console.WriteLine("  1) Класс location\n  2) Класс flat\n  3) Класс street\n  4) Класс house\n  5) Массив обьектов класса house\n  6) 2-x мерный массив объектов flat\n  7) Выход\n");
				 Console.WriteLine("Выберите действие: ");
				do
				{
					while (!int.TryParse(Console.ReadLine(), out option)) { Console.WriteLine("Ошибка. Введите число: "); }
					if (option > 7 || option <=0)
					{
						Console.WriteLine("\nОшибка. выбирете из допустимых значений: ");
					}
				} while (option > 7 || option <= 0);
				
				if (option == 1)
				{
					FunckForLocation();
				}
				else if (option == 2)
				{
					FunckForFlat();
				}
				else if (option == 3)
				{
					FunckForStreet();
				}
				else if (option == 4)
				{
					FunckForHouse();
				}
				else if (option == 5)
				{
					FunckForHouses();
				}
				else if (option == 6)
				{
					TwodimensionalArrayFlats();
				}
			} while (option != 7);

			void FunckForLocation()
			{

				int distanceSchool, distanceHospital, distanceKindergarten, numHouse, option;
				string houseStreet;

				Location location_1 = new Location();

				do
				{
					Console.WriteLine("  1) Заполнить через встроенную функцию\n  2) Заполнить через внешнюю функцию\n  3) Вывести информацию об обьекте\n  4) Выход в главное меню\n");
					Console.WriteLine("Выберите действие: ");
					do
					{
						while (!int.TryParse(Console.ReadLine(), out option)) { Console.WriteLine("Ошибка. Введите число: "); }
						if (option > 4)
						{
							Console.WriteLine("\nОшибка. выбирете из допустимых значений: ");
						}
					} while (option > 4 || option <= 0);

					if (option == 1)
					{
						location_1.Set_console();
					}
					else if (option == 2)
					{
						Console.WriteLine("\nВыберите расстояние до школы: ");
						while (!int.TryParse(Console.ReadLine(), out distanceSchool)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("Выберите расстояние до больницы: ");
						while (!int.TryParse(Console.ReadLine(), out distanceHospital)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("Выберите расстояние до детского сада: ");
						while (!int.TryParse(Console.ReadLine(), out distanceKindergarten)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("Номер дома: ");
						while (!int.TryParse(Console.ReadLine(), out numHouse)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("\nУлица: "); houseStreet = Console.ReadLine();

						location_1.Set(distanceSchool, distanceHospital, distanceKindergarten, houseStreet, numHouse);
					}
					else if (option == 3)
					{
						Console.WriteLine("\n");
						location_1.Print();
					}
				} while (option != 4);

			}
			
			void FunckForFlat()
			{
				int coin, countRoom, numFlat, option;

				Flat flat_1 = new Flat();

				do
				{
					Console.WriteLine("  1) Заполнить через встроенную функцию\n  2) Заполнить через внешнюю функцию\n  3) Вывести информацию об обьекте\n  4) Выход в главное меню\n");
					Console.WriteLine("Выберите действие: ");
					do
					{
						while (!int.TryParse(Console.ReadLine(), out option)) { Console.WriteLine("Ошибка. Введите число: "); }
						if (option > 4)
						{
							Console.WriteLine("\nОшибка. выбирете из допустимых значений: ");
						}
					} while (option > 4 || option <= 0);

					if (option == 1)
					{
						flat_1.Set_console();
					}
					else if (option == 2)
					{
						Console.WriteLine("\nВыберите стоимость квартиры: ");
						while (!int.TryParse(Console.ReadLine(), out coin)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("Выберите кол-во комнат: ");
						while (!int.TryParse(Console.ReadLine(), out countRoom)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("Номер квартиры: ");
						while (!int.TryParse(Console.ReadLine(), out numFlat)) { Console.WriteLine("Ошибка. Введите число: "); }

						flat_1.Set(coin, countRoom, numFlat);
					}
					else if (option == 3)
					{
						flat_1.Print();
					}

				} while (option != 4);

			}
			
			void FunckForStreet()
			{
				string streetName;
				string streetDescription;

				Street street_1 = new Street();

				int option = 0;
				do
				{
					Console.WriteLine("  1) Заполнить через встроенную функцию\n  2) Заполнить через внешнюю функцию\n  3) Вывести информацию об обьекте\n  4) Выход в главное меню\n");
					Console.WriteLine("Выберите действие: ");
					do
					{
						while (!int.TryParse(Console.ReadLine(), out option)) { Console.WriteLine("Ошибка. Введите число: "); }
						if (option > 4)
						{
							Console.WriteLine("\nОшибка. выбирете из допустимых значений: ");
						}
					} while (option > 4 || option <= 0);

					if (option == 1)
					{
						street_1.Set_console();
					}
					else if (option == 2)
					{
						Console.WriteLine("\nУлица: ");
						streetName = Console.ReadLine();
						Console.WriteLine("Описание улици: ");
						streetDescription = Console.ReadLine();

						street_1.Set(streetName, streetDescription);
					}
					else if (option == 3)
					{
						street_1.Print();
					}

				} while (option != 4);

			}
			
			void FunckForHouse()
			{
				int distanceSchool, distanceHospital, distanceKindergarten, numHouse, coin, countRoom, numFlat;
				string streetDescription, houseStreet;

				House house_1 = new House();
				Street street_1 = new Street();
				Location location_1 = new Location();
				Flat flat_1 = new Flat();

				int option = 0;
				do
				{
					Console.WriteLine("  1) Заполнить через встроенную функцию\n  2) Заполнить через внешнюю функцию\n  3) Вывести информацию об обьекте\n  4) Выход в главное меню\n");
					Console.WriteLine("Выберите действие: ");
					do
					{
						while (!int.TryParse(Console.ReadLine(), out option)) { Console.WriteLine("Ошибка. Введите число: "); }
						if (option > 4)
						{
							Console.WriteLine("\nОшибка. выбирете из допустимых значений: ");
						}
					} while (option > 4 || option <= 0);

					if (option == 1)
					{
						house_1.Set_console();
					}
					else if (option == 2)
					{

						Console.WriteLine("Выберите расстояние до школы: ");
						while (!int.TryParse(Console.ReadLine(), out distanceSchool)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("Выберите расстояние до больницы: ");
						while (!int.TryParse(Console.ReadLine(), out distanceHospital)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("Выберите расстояние до детского сада: ");
						while (!int.TryParse(Console.ReadLine(), out distanceKindergarten)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("Выберите стоимость квартиры: ");
						while (!int.TryParse(Console.ReadLine(), out coin)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("Выберите кол-во комнат: ");
						while (!int.TryParse(Console.ReadLine(), out countRoom)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("Номер дома: ");
						while (!int.TryParse(Console.ReadLine(), out numHouse)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("Номер квартиры: ");
						while (!int.TryParse(Console.ReadLine(), out numFlat)) { Console.WriteLine("Ошибка. Введите число: "); }

						Console.WriteLine("\nУлица: "); houseStreet = Console.ReadLine();
						Console.WriteLine("Описание улици: "); streetDescription = Console.ReadLine();

						location_1.Set(distanceSchool, distanceHospital, distanceKindergarten, houseStreet, numHouse);
						flat_1.Set(coin, countRoom, numFlat);
						street_1.Set(houseStreet, streetDescription);
						house_1.Set(street_1, flat_1, location_1);
					}
					else if (option == 3)
					{
						house_1.Print();
					}

				} while (option != 4);

			}

			void FunckForHouses()
            {
				int size;
				Console.WriteLine("  Сколько домов вы хотите создать: ");
				while (!int.TryParse(Console.ReadLine(), out size)) { Console.WriteLine("Ошибка. Введите число: "); }
				House[] list = new House[size];
				for(int i = 0; i < size; i++)
                {
					list[i] = new House();
					list[i].Set_console();
                }
				Console.WriteLine("  Введённые вами данные: ");
				for(int i = 0; i < size; i++)
                {
					list[i].Print();
					Console.WriteLine();
				}
				Console.WriteLine();
			}
			void TwodimensionalArrayFlats()
			{
				int size, size_2;

				Console.Write("\n\n  Введите размерность основного массива: ");
				while (!int.TryParse(Console.ReadLine(), out size)) { Console.WriteLine("Ошибка. Введите число: "); }
				Console.Write("\n  Введите размерность дочерних массивов: ");
				while (!int.TryParse(Console.ReadLine(), out size_2)) { Console.WriteLine("Ошибка. Введите число: "); }

				Flat[][] Flats = new Flat[size][];
				for (int i = 0; i < size; i++)
				{
					for (int j = 0; j < size_2; j++)
					{
						Flats[i] = new Flat[size_2];
					}
				}
				Console.Write("\n\n  Введите значения: ");
				for (int i = 0; i < size; i++)
				{
					Console.Write("\n");
					for (int j = 0; j < size_2; j++)
					{
						Flats[i][j] = new Flat();
						Flats[i][j].Set_console();
					}
				}

				Console.Write("\n\n  Ваши данные: ");
				for (int i = 0; i < size; i++)
				{
					Console.Write("\n");
					for (int j = 0; j < size_2; j++)
					{
						Flats[i][j].Print();
					}
				}
				Console.Write("\n");
			}
		}	
	}
}
