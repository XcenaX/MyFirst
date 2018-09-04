using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Train train = new Train();
            train.AddVagon(34,25);
            train.AddVagon(12, 41);        
            train.ShowInfoAboutVagons();

            Console.WriteLine("\nПока только один вагон, добавьте еще");
            InputNumbers1:
            Console.WriteLine("Введите номер вагона: ");

            int number;
            try { if ((number = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch(System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число!");
                goto InputNumbers1;
            }

            InputNumbers2:
            Console.WriteLine("Введите кол-во пассажиров: ");

            int countOfPeople;
            try { if ((countOfPeople = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число!");
                goto InputNumbers2;
            }

            try
            {
                train.AddVagon(number,countOfPeople);
            }
            catch(Exception)
            {
                Console.Clear();
                Console.WriteLine("Вагон с таким номером уже существует!");
                goto InputNumbers1;
            }

            Console.Clear();

            Console.WriteLine("Теперь попробуйте удалить вагон");

            InputNumber3:

            train.ShowInfoAboutVagons();
            Console.WriteLine("\nпросто введите номер вагона: ");

            int number2;

            try { if ((number2 = Convert.ToInt32(Console.ReadLine())) == null) throw new System.FormatException(); }
            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число!");
                goto InputNumber3;
            }

            try { train.DeleteVagon(number2); }
            catch(Exception)
            {                
                goto InputNumber3;
            }

            Console.Clear();
            Console.WriteLine("Вагон успешно удален!");
            train.ShowInfoAboutVagons();

            Console.WriteLine("\nНажмите любую кнопку !!!");
            Console.ReadKey();
            Console.Clear();


            Console.Write("Введите имя поезда: ");
            train.SetName(Console.ReadLine());
            
            InputNumber4:

            Console.Write("Введите скорость поезда: ");
            double speed;
            try { if ((speed = Convert.ToDouble(Console.ReadLine())) == null) throw new Exception(); }
            catch(Exception)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число!");
                goto InputNumber4;
            }

            train.SetSpeed(speed);

            Console.WriteLine("\nИнформация об этом поезде");
            train.ShowInfoAboutTrain();
            train.ShowInfoAboutVagons();

            Console.ReadKey();

        }
    }
}
