using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Program
    {

       

        public static void PrintMenu()
        {
            Console.WriteLine("1) Добавить автора");
            Console.WriteLine("2) Добавить книгу");
            Console.WriteLine("3) Найти автора");
            Console.WriteLine("4) Найти книгу");
            Console.WriteLine("5) Удалить книгу");
            Console.WriteLine("6) Удалить автора");
            Console.WriteLine("7) Выход");
        }

        public static bool Select(char select, LibraryContext context)
        {
            switch (select)
            {
                case '1':
                    Console.WriteLine("Введите имя автора: ");
                    var name = Console.ReadLine();

                    context.AddAutor(name);

                    Console.WriteLine("\n\nНажмите любую кнопку . . .");
                    Console.ReadKey();
                    return false;
                case '2':                
                    Console.WriteLine("Введите имя книги: ");
                    var nameBook = Console.ReadLine();

                    Console.WriteLine("Введите имя автора: ");
                    var nameAutor = Console.ReadLine();

                    context.AddBook(nameBook, nameAutor);

                    Console.WriteLine("\n\nНажмите любую кнопку . . .");
                    Console.ReadKey();
                    return false;
                case '3':
                    Console.WriteLine("Введите имя автора: ");
                    nameAutor = Console.ReadLine();

                    context.SearchAutor(nameAutor);

                    Console.WriteLine("\n\nНажмите любую кнопку . . .");
                    Console.ReadKey();
                    return false;
                case '4':
                    Console.WriteLine("Введите имя книги: ");
                    nameBook = Console.ReadLine();

                    context.SearchBook(nameBook);

                    Console.WriteLine("\n\nНажмите любую кнопку . . .");
                    Console.ReadKey();
                    return false;
                case '5':
                    Console.WriteLine("Введите имя книги или индекс: ");
                    nameBook = Console.ReadLine();

                    int number;
                    if (int.TryParse(nameBook, out number)) context.DeleteBook(number);
                    else context.DeleteBook(nameBook);

                    Console.WriteLine("\n\nНажмите любую кнопку . . .");
                    Console.ReadKey();
                    return false;
                case '6':
                    Console.WriteLine("Введите имя автора или индекс: ");
                    nameAutor = Console.ReadLine();

                    if (int.TryParse(nameAutor, out number)) context.DeleteAutor(number);
                    else context.DeleteAutor(nameAutor);

                    Console.WriteLine("\n\nНажмите любую кнопку . . .");
                    Console.ReadKey();
                    return false;
                case '7':
                    return true;
                default:                  
                    return false;
            }
        }

        static void Main(string[] args)
        {
            using (var context = new LibraryContext())
            {
                bool check = false;
                while (!check)
                {
                    PrintMenu();
                    char select = Console.ReadKey().KeyChar;
                    Console.Clear();
                    check = Select(select, context);
                    Console.Clear();
                }
            }          
        }
    }
}
