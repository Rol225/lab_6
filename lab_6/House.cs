﻿using System;
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

            Console.Write("\nВыберите расстояние до школы: ");
            while (!int.TryParse(Console.ReadLine(), out distanceSchool)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("\nВыберите расстояние до больницы: ");
            while (!int.TryParse(Console.ReadLine(), out distanceHospital)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("\nВыберите расстояние до детского сада: ");
            while (!int.TryParse(Console.ReadLine(), out distanceKindergarten)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("\nВыберите стоимость квартиры: ");
            while (!int.TryParse(Console.ReadLine(), out coin)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("\nВыберите кол-во комнат: ");
            while (!int.TryParse(Console.ReadLine(), out countRoom)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("\nНомер дома: ");
            while (!int.TryParse(Console.ReadLine(), out numHouse)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("\nНомер квартиры: ");
            while (!int.TryParse(Console.ReadLine(), out numFlat)) { Console.WriteLine("Ошибка. Введите число: "); }

            Console.Write("\n\nУлица: "); houseStreet = Console.ReadLine();
            Console.Write("\nОписание улици: "); streetDescription = Console.ReadLine();

            location.Set(distanceSchool, distanceHospital, distanceKindergarten, houseStreet, numHouse);
            flat.Set(coin, countRoom, numFlat);
            street.Set(houseStreet, streetDescription);
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
    }
}
