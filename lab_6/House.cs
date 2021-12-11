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
        private static int countData = 0; // Кол-во домов в базе

        public House()
        {
            this.flat = new Flat();
            this.location = new Location();
            this.street = new Street();
            CountData();
        }
        public House(int distanceSchool, int distanceHospital, int distanceKindergarten, string houseStreet, int numHouse, int coin, int countRoom, int numFlat, string streetDescription)
        {
            this.location.Set(distanceSchool, distanceHospital, distanceKindergarten, houseStreet, numHouse);
            this.flat.Set(coin, countRoom, numFlat);
            this.street.Set(houseStreet, streetDescription);
            CountData();
        }

        public House(Street street_new)
        {
            this.flat = new Flat();
            this.location = new Location();
            this.street = street_new;
            CountData();
        }

        public void Set(int distanceSchool, int distanceHospital, int distanceKindergarten, string houseStreet, int numHouse, int coin, int countRoom, int numFlat, string streetDescription) 
        {
            this.location.Set(distanceSchool, distanceHospital, distanceKindergarten, houseStreet, numHouse);
            this.flat.Set(coin, countRoom, numFlat);
            this.street.Set(houseStreet, streetDescription);
            CountData();
        } // Функция ввода через встроенную функцию
        public void Set_console()
        {
            int distanceSchool, distanceHospital, distanceKindergarten, numHouse, coin, countRoom, numFlat;
            string streetDescription, houseStreet;

            Console.Write("\nВыберите расстояние до школы: ");
            while (!int.TryParse(Console.ReadLine(), out distanceSchool)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("Выберите расстояние до больницы: ");
            while (!int.TryParse(Console.ReadLine(), out distanceHospital)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("Выберите расстояние до детского сада: ");
            while (!int.TryParse(Console.ReadLine(), out distanceKindergarten)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("Выберите стоимость квартиры: ");
            while (!int.TryParse(Console.ReadLine(), out coin)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("Выберите кол-во комнат: ");
            while (!int.TryParse(Console.ReadLine(), out countRoom)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("Номер дома: ");
            while (!int.TryParse(Console.ReadLine(), out numHouse)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("Номер квартиры: ");
            while (!int.TryParse(Console.ReadLine(), out numFlat)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("\nУлица: "); houseStreet = Console.ReadLine();
            Console.Write("Описание улици: "); streetDescription = Console.ReadLine();

            location.Set(distanceSchool, distanceHospital, distanceKindergarten, houseStreet, numHouse);
            flat.Set(coin, countRoom, numFlat);
            street.Set(houseStreet, streetDescription);
            CountData();
        } // Функция ввода через внешнюю функцию
        public void Print() 
        {
            int distanceSchool;
            int distanceHospital;
            int distanceKindergarten;
            string houseStreet = "";
            int numHouse = 0;
            location.OutData(out distanceSchool, out distanceHospital, out distanceKindergarten);
            location.RefData(ref houseStreet, ref numHouse);

            Console.Write("\n  Адрес: {0}, дом {1}\n", houseStreet, numHouse);
            Console.Write("  Номер квартиры: {0}\n", flat.Num_flat);
            Console.Write("  Расстояние до школы: {0} км\n", distanceSchool);
            Console.Write("  Расстояние до больницы: {0} км\n", distanceHospital);
            Console.Write("  Расстояние до детского сада: {0} км\n", distanceKindergarten);
            Console.Write("  Кол-во комнат: {0}\n", flat.Count_room);
            Console.Write("  Цена: {0} рублей\n", flat.Coin);
            Console.Write("  Информация о улице: {0}\n\n", street.Street_description);
        }  // Функция вывода
        public static int CountData()
        {
            countData++;
            Console.Write("\n  Кол-во домов использованных в базе: {0}\n", countData);
            return countData;
        } // Функия счётчик
    }
    
}
