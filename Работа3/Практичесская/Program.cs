﻿using System;
using System.Collections.Generic;
using System.Text;
namespace Practice1
{
    class Program
    {
        
        static void QuadraticEquation(double X)
        { //вычисление значения функции 
            Console.WriteLine("\nКорень уравнения : " + ((7 * (X * X)) - (3 * X) + 4));
        }
        static void CircumFerence(double Radius)
        {//Найти длину окружности и площадь круга.
            const double PI_NUMBER = 3.14;
            Console.WriteLine("\nДлинна Окружности : " + (2 * PI_NUMBER * Radius));
            Console.WriteLine("Площадь Круга : " + (PI_NUMBER * (Radius * Radius)));
        }
        static void MetersInSantimeters(int Santimeters)
        { //число полных метров в сантиметрах
            const int Thousand = 1000;
            Console.WriteLine("Это " + (Santimeters / Thousand) + " метров");
        }
        static void ConvertDaysToWeeks(int Days)
        {//переводит дни в недели
            const int Days_in_Week = 7;
            Console.WriteLine("Это " + (Days / Days_in_Week) + " недель");
        }
        static void InfoAboutMultiValuedDigitNumber(int MultiDigitNumber)
        {
            const int Dozen = 10; // десяток
             int CountOfUnits = 0; // кол-во едениц
            int CopyOfTwoDigitNumber = MultiDigitNumber; // Копия входящего числа чтобы не изменять это число
            int AmountOfNumbers = 0;
            int CompositionOfNumbers = 1;
            while (CopyOfTwoDigitNumber > 0)
            {
                if (CopyOfTwoDigitNumber % Dozen == 1) { CountOfUnits++; }
                CompositionOfNumbers *= CopyOfTwoDigitNumber % Dozen;
                AmountOfNumbers += CopyOfTwoDigitNumber % Dozen;
                CopyOfTwoDigitNumber /= 10;
            }
            Console.WriteLine("\nЧисло Десятков в этом числе : " + (MultiDigitNumber % Dozen));
            Console.WriteLine("Число едениц в этом числе :" + CountOfUnits);
            Console.WriteLine("Сумма его цифр : " + AmountOfNumbers);
            Console.WriteLine("Произведение его цифр : " + CompositionOfNumbers);
        }
        static void EncryptNumber(int NumberX){
            string NewString = NumberX.ToString(); // преобразуем число в строку
            string SecondDigit = NewString.Substring(1,1);
            string NumberXWithoutSecondDigit = NewString.Remove(1,1);
            string EcryptedNumber;
           Console.WriteLine("\nЗашифрованное число : " + (EcryptedNumber = string.Concat(NumberXWithoutSecondDigit, SecondDigit)));
        }
  
        static void Main(string[] args){



            //1
           InputNumbers1:
            Console.WriteLine("Введите Х для вычисления значения функции y=7x^2-3x+4");
            double X;
            try { if(( X = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch(System.FormatException){
            Console.Clear();
            Console.WriteLine("Вы ввели не число!");
                goto InputNumbers1;
            }
            QuadraticEquation(X);
        Console.Write("Нажмите любую кнопку .  .  .");
        Console.ReadKey();
        Console.Clear();


            //2
            InputNumbers2:
            Console.WriteLine("Введите радиус окружности : ");
            double Radius;
            try { if(( Radius = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch(System.FormatException){
            Console.Clear();
            Console.WriteLine("Вы ввели не число!");
                goto InputNumbers2;
            }

            CircumFerence(Radius);

        Console.Write("Нажмите любую кнопку .  .  .");
        Console.ReadKey();
        Console.Clear();


            //3
            InputNumbers3:
            Console.WriteLine("Введите расстояние в сантиметрах : ");
            int Santimeters;
            try { if(( Santimeters = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch(System.FormatException){
            Console.Clear();
            Console.WriteLine("Вы ввели не число!");
                goto InputNumbers3;
            }

            MetersInSantimeters(Santimeters);

        Console.Write("Нажмите любую кнопку .  .  .");
        Console.ReadKey();
        Console.Clear();


            //4
             InputNumbers4:
            Console.WriteLine("Введите кол-во дней : ");
            int Days;
            try { if(( Days = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch(System.FormatException){
            Console.Clear();
            Console.WriteLine("Вы ввели не число!");
                goto InputNumbers4;
            }

            ConvertDaysToWeeks(Days);

        Console.Write("Нажмите любую кнопку .  .  .");
        Console.ReadKey();
        Console.Clear();


            //5 and 6
             InputNumbers5:
            Console.WriteLine("Введите целое число : ");
            int Number;
            try { if(( Number = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch(System.FormatException){
            Console.Clear();
            Console.WriteLine("Вы ввели не число!");
                goto InputNumbers5;
            }

            InfoAboutMultiValuedDigitNumber(Number);

        Console.Write("Нажмите любую кнопку .  .  .");
        Console.ReadKey();
        Console.Clear();


            //7
             InputNumbers6:
            Console.WriteLine("Введите трехзначное число для зашифровки (2 цифра передвинется в конец) : ");
            int TreeDigitNumber;
            try { if(( TreeDigitNumber = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch(System.FormatException){
            Console.Clear();
            Console.WriteLine("Вы ввели не число!");
                goto InputNumbers6;
            }

            EncryptNumber(TreeDigitNumber);

        Console.Write("Нажмите любую кнопку .  .  .");
        Console.ReadKey();
        Console.Clear();

        }
    }
}