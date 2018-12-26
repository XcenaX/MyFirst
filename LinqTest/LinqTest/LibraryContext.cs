namespace LinqTest
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=SportContext")
        {
        }

       public DbSet<Autor> Autors { get; set; }
       public DbSet<Book> Books { get; set; }

        public  void AddAutor(string name)
        {
            var autors = Autors.Where(book => book.Name == name);
            if (autors.Count() != 0)
            {
                Console.Clear();
                Console.WriteLine("Автор с таким именем уже существует!");
                return;
            }
                Autors.Add(new Autor() { Name = name });
                SaveChanges();            
        }

        public void AddBook(string name, string autorName)
        {
            var books = Books.Where(book => book.Name == name);
            if (books.Count() != 0)
            {
                Console.Clear();
                Console.WriteLine("Книга с таким именем уже существует!");
                return;
            }
            var autors = Autors.Where(autor => autor.Name.Contains(autorName));
            if (autors.Count() == 1)
            {
                Autors.Add(new Autor() { Name = name });
            }
            else if (autors.Count() > 1)
            {
                while (true)
                {
                    Console.WriteLine("Есть несколько похожих авторов выберите одного: ");
                    int count = 1;
                    foreach (var autor in autors)
                    {
                        Console.WriteLine(count + ") " + autor.Name);
                        count++;
                    }
                    string select = Console.ReadLine();
                    int number;
                    if (int.TryParse(select, out number))
                    {
                        if (number > 0 && number < autors.Count())
                        {
                            Books.Add(new Book() { Name = name, Autor = autors.ElementAt(number - 1) });
                            SaveChanges();
                            break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Вы ввели некорректный номер! Введите еще раз!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Примерно такого автора не найдено!");
            }
        }

        public  void SearchAutor(string name)
        {            
                var autors = Autors.Where(autor => autor.Name.Contains(name));
                int count = 1;
                if (autors.Count() == 0)
                {
                    Console.WriteLine("ничего не найдено!");
                }
                else
                {
                    foreach (var autor in autors)
                    {
                        Console.WriteLine(count + ") " + autor.Name);
                    }
                }            
        }

        public  void SearchBook(string name)
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.Where(book => book.Name.Contains(name));
                int count = 1;
                if (books.Count() == 0)
                {
                    Console.WriteLine("ничего не найдено!");
                }
                else
                {
                    foreach (var book in books)
                    {
                        Console.WriteLine(count + ") " + book.Name);
                    }
                }
            }
        }

        public void DeleteBook(int index)
        {
            Books.Remove(new Book() { Id = index });
        }

        public void DeleteBook(string name)
        {
            Books.Remove(new Book() { Name = name });
        }

        public void DeleteAutor(int index)
        {
            Autors.Remove(new Autor() { Id = index });
        }

        public void DeleteAutor(string name)
        {
            Autors.Remove(new Autor() { Name = name });
        }

    }
}