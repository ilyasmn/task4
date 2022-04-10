using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sual_7.book
{
   public class Book
    {

        static int counter = 0;

        public readonly int id;
        public string name;
        public int pageCount; 
        public Author author;
        public int publishYear;

        public Book()

        {
            this.id = ++counter;

        }
        public Book(string name)
            :this()
        {
            this.name = name;

        }
        public Book(string name, int pageCount)
            :this(name)
        {
            this.pageCount = pageCount;

        }
        public Book(string name, int pageCount, int publishYear)
            :this(name, pageCount)
        {
            this.publishYear = publishYear;

        }
        public Book(string name, int pageCount, int publishYear, Author author)
            : this(name, pageCount, publishYear)
        {
            this.author = author;

        }
        

        public override string ToString()
        {
            return $"{id} nomreli kitab" + $" { name},"  + $" { author}," + $" { publishYear}," + $" {pageCount}";
        }
    }
}
