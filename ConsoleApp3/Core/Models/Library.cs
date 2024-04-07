using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Models
{
    public class Library
    {
        Book[] books;
        public Library()
        {
            books = new Book[0];
        }
        
        public void AddBooks(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }
        public void GetInfo()
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Book:{books[i].Name}, Author:{books[i].AuthorName}, Page Count:{books[i].PageCount}");
            }
            
        }
        public Book[] FindAllBooksByName(string name) 
        {
            Book[] fbooks = new Book[0];
            for (int i = 0; i < books.Length; i++) 
            {
                if (books[i].Name == name)
                {
                    Array.Resize(ref fbooks, fbooks.Length + 1);
                    fbooks[fbooks.Length - 1] = books[i];

                }
            }

            
            return fbooks;
        }
        public Book[] RemoveAllBookByName(string name)
        {
            Book[] rbooks = new Book[0];
            for (int i = 0;i < books.Length;i++) 
            {
                if (books[i].Name != name) 
                {
                    Array.Resize(ref rbooks, rbooks.Length + 1);
                    rbooks[rbooks.Length - 1] = books[i];
                }
            }
            books = rbooks;
            return rbooks;
        }
        public void SearchBooks( string a)
        {
            Book[] sbooks = new Book[0];
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Name == a || books[i].AuthorName==a || books[i].PageCount.ToString()==a )
                {
                    Array.Resize(ref sbooks, sbooks.Length + 1);
                    sbooks[sbooks.Length - 1] = books[i];
                }
            }
            books = sbooks;
            GetInfo() ;
        }

    }
}
