
namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book;
            book.name = "Война и мир";
            book.author = "Л.Н.Толстой";
            book.year = 1869;

            //Выведем информацию о книге book на экран
            book.Info();

            Console.ReadLine();
        }
    }

    struct Book
    {

        public string name;
        public string author;
        public int year;

        public void Info()
        {
            Console.WriteLine("Книга {0} (автор {1}) была издана в {2} году", name, author, year);
        }
    }
}