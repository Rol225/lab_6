using System;

namespace lab_6

{
    class Program
    {
        static void Main(string[] args)
        {
			//Подключение Русского языка
			//SetConsoleCP(1251);
			//SetConsoleOutputCP(1251);

			int option = 0;

			do
			{
				 Console.WriteLine("  1) Структура location\n  2) Структура flat\n  3) Структура street\n  4) Структура house\n  5) Выход\n");
				 Console.WriteLine("Выберите действие: ");
				do
				{
					while (!int.TryParse(Console.ReadLine(), out option)) { Console.WriteLine("Ошибка. Введите число: "); }
					if (option > 5 || option <=0)
					{
						Console.WriteLine("\nОшибка. выбирете из допустимых значений: ");
					}
				} while (option > 5 || option <= 0);
				
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
					//FunckForHouse();
				}
			} while (option != 5);

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
			/*
			void FunckForHouse()
			{
				int distanceSchool, distanceHospital, distanceKindergarten, numHouse, coin, countRoom, numFlat;
				string streetDescription, houseStreet;

				house house_1 = new house();

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

						house_1.Set(distanceSchool, distanceHospital, distanceKindergarten, houseStreet, numHouse, coin, countRoom, numFlat, streetDescription);
					}
					else if (option == 3)
					{
						house_1.Print();
					}

				} while (option != 4);

			}
			*/
		}	
	}
}
