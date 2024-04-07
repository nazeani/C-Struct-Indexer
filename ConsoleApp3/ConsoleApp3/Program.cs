using Core;
using Core.Models;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book book = new Book();
            book.Name = "Test";
            book.AuthorName = "Test1";
            book.PageCount = 100;
          Book book2 = new Book();
            book2.Name= "Testtt";
            book2.AuthorName = "Testtt2";
            book2.PageCount = 100;
           Library library = new Library();
            library.AddBooks(book);
            library.AddBooks(book2);
            Book[] a=library.FindAllBooksByName("Test");
            foreach (var item in a)
            {
                Console.WriteLine($"Book: {item.Name}, Author: {item.AuthorName}, Page Count: {item.PageCount}");
            }
            library.RemoveAllBookByName("Test");
            library.GetInfo();
            library.SearchBooks("Testtt");



        }
    }
}
