using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void PrintNumbersInLine(double Number1, double Number2, double Number3){
            Console.WriteLine(Number1 + "  " + Number2 + "  " + Number3 );
        }


        static void PrintNumbersDown(double Number1, double Number2, double Number3)
        {
            Console.WriteLine(Number1 + "\n" + Number2 + "\n" + Number3);
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
            Console.WriteLine("\nЧисло Десятков в этом числе : " + (MultiDigitNumber / Dozen));
            Console.WriteLine("Число едениц в этом числе :" + CountOfUnits);
            Console.WriteLine("Сумма его цифр : " + AmountOfNumbers);
            Console.WriteLine("Произведение его цифр : " + CompositionOfNumbers);
        }


        static void AreaComparsion(double Radius, double SideOfSquare){
            const double PI_NUMBER = 3.14;
            double AreaOfCircle = (PI_NUMBER * Radius * Radius);
            double AreaOfSquare = (SideOfSquare * SideOfSquare);
            if (AreaOfCircle > AreaOfSquare) {Console.WriteLine("Площадь Круга больше!");}
            else{Console.WriteLine("Площадь Квадрата больше!");}
                Console.WriteLine("Площадь Квадрата : " + AreaOfSquare + "\nПлощадь Круга : " + AreaOfCircle);
        }

        static void ComparsionOfDensities(double Amount1, double Weight1, double Amount2, double Weight2){
            double Density1 = Amount1 / Weight1;
            double Density2 = Amount2 / Weight2;
            if (Density1 > Density2) Console.WriteLine("Плотность Первого Тела Больше!");
            else Console.WriteLine("Плотность Второго Тела Больше!");
            Console.WriteLine("Плотность Первого Тела : " + Density1 + "\nПлотность Второго Тела : " + Density2);
        }

        static void PrintInfo(int b, int a){
            Console.WriteLine("Все числа от 20 до 35");
            for (int i = 20; i <= 35; i++ )Console.WriteLine(i);
            Console.WriteLine("\nКвадраты Чисел от 10 до " + b);
            for (int i = 10; i <= b; i++) Console.WriteLine(i*i);
            Console.WriteLine("\nТретьи Степени Чисел от " + a + " до " + 50);
            for (int i = a; i <= 50; i++) Console.WriteLine(i * i * i);
            Console.WriteLine("\nЧисла от " + a + " до " + b);
            for (int i = a; i <= b; i++) Console.WriteLine(i * i * i);
        }




        static void Main(string[] args){
            
            InputNumbers1:
            Console.WriteLine("Введите Три Числа : ");
            double Number1, Number2, Number3;

            try
            {
                Console.Write("1) ");
                if ((Number1 = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException();
                
                Console.Write("2) ");
                if ((Number2 = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException();
               
                Console.Write("3) ");
                if ((Number3 = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException();
            }

            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число!");
                goto InputNumbers2;
            }

            PrintNumbersInLine(Number1, Number2, Number3);

            Console.Write("Нажмите любую кнопку .  .  .");
            Console.ReadKey();
            Console.Clear();



        InputNumbers2:
            double Radius, SideOfSquare;
            try { 
            Console.Write("Введите радиус окружности : ");
                if ((Radius = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException();
                Console.Write("\nВведите Сторону Квадрата : ");
                if ((SideOfSquare = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); 
            }
            
            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число!");
                goto InputNumbers2;
            }

            AreaComparsion(Radius,SideOfSquare);

            Console.Write("Нажмите любую кнопку .  .  .");
            Console.ReadKey();
            Console.Clear();



            PrintNumbersDown(5,10,21);
            Console.Write("Нажмите любую кнопку .  .  .");
            Console.ReadKey();
            Console.Clear();


        InputNumbers3:
            Console.WriteLine("Введите расстояние в сантиметрах : ");
            int Santimeters;
            try { if ((Santimeters = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число!");
                goto InputNumbers3;
            }

            MetersInSantimeters(Santimeters);

            Console.Write("Нажмите любую кнопку .  .  .");
            Console.ReadKey();
            Console.Clear();



        InputNumbers4:
            Console.WriteLine("Введите кол-во дней : ");
            int Days;
            try { if ((Days = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число!");
                goto InputNumbers4;
            }

            ConvertDaysToWeeks(Days);

            Console.Write("Нажмите любую кнопку .  .  .");
            Console.ReadKey();
            Console.Clear();



        InputNumbers5:
            Console.WriteLine("Введите целое число : ");
            int Number;
            try { if ((Number = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число!");
                goto InputNumbers5;
            }

            InfoAboutMultiValuedDigitNumber(Number);

            Console.Write("Нажмите любую кнопку .  .  .");
            Console.ReadKey();
            Console.Clear();



        InputNumbers6:
            double Amount1,Amount2,Weight1,Weight2;
            try
            {
                Console.Write("Введите объём первого тела : ");
                if ((Amount1 = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException();
               
                Console.Write("\nВведите массу первого тела : ");
                if ((Weight1 = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException();
                
                Console.Write("Введите объём второго тела : ");
                if ((Amount2 = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException();
               
                Console.Write("\nВведите массу второго тела : ");
                if ((Weight2 = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException();
            }

            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число!");
                goto InputNumbers6;
            }

            ComparsionOfDensities(Amount1, Weight1,Amount2, Weight2);

            Console.Write("Нажмите любую кнопку .  .  .");
            Console.ReadKey();
            Console.Clear();



        InputNumbers7:
            int a,b;
        Console.WriteLine(" a<b ; b>10 ; a<50 ");
                
            try
            {
                Console.Write("Введите целое число а : ");
                if ((a = Convert.ToInt32(Console.ReadLine())) == null 
                    || a  >= 50 ) throw new System.FormatException();

                Console.Write("\nВведите целое число b : ");
                if ((b = Convert.ToInt32(Console.ReadLine())) == null || b <= 10 || b  < a) throw new System.FormatException();                
            }

            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Некорректно Введены данные!");
                goto InputNumbers7;
            }

            PrintInfo(b,a);

            Console.Write("Нажмите любую кнопку .  .  .");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
