using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Book
    {
        public static int no {  get; set; }
        public int No { get; set; }
        public string Name;
        public string AuthorName;
        public int PageCount;
        public Book() 
        { }
        public Book(string name, string authorName, int pageCount)
        {
            no++;
            No = no;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
    }
}
