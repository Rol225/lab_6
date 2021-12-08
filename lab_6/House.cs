using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
    class House
    {
        private Flat flat = new Flat();// Квартира
        private Location location = new Location();//Расположение дома
        private Street street = new Street(); //Описание улицы

        public void Set(int distanceSchool, int distanceHospital, int distanceKindergarten, string houseStreet, int numHouse, int coin, int countRoom, int numFlat, string streetDescription) 
        {
            this.location.Set(distanceSchool, distanceHospital, distanceKindergarten, houseStreet, numHouse);
            this.flat.Set(coin, countRoom, numFlat);
            this.street.Set(houseStreet, streetDescription);
        } // Функция ввода через встроенную функцию
        public void Set_console()
        {
            int distanceSchool, distanceHospital, distanceKindergarten, numHouse, coin, countRoom, numFlat;
            string streetDescription, houseStreet;

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

            location.Set(distanceSchool, distanceHospital, distanceKindergarten, houseStreet, numHouse);
            flat.Set(coin, countRoom, numFlat);
            street.Set(houseStreet, streetDescription);
        } // Функция ввода через внешнюю функцию
        public void Print() 
        {
            Console.Write("\n  Адрес: {0}, дом {1}\n", location.Get_house_street(), location.Get_num_house());
            Console.Write("  Номер квартиры: {0}\n", flat.Get_num_flat());
            Console.Write("  Расстояние до школы: {0} км\n", location.Get_distance_school());
            Console.Write("  Расстояние до больницы: {0} км\n", location.Get_distance_hospital());
            Console.Write("  Расстояние до детского сада: {0} км\n", location.Get_distance_kindergarten());
            Console.Write("  Кол-во комнат: {0}\n", flat.Get_count_room());
            Console.Write("  Цена: {0} рублей\n", flat.Get_coin());
            Console.Write("  Информация о улице: {0}\n\n", street.Get_street_description());
        }  // Функция вывода
    }
}
