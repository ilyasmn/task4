using System;
using sual_7.book;


namespace sual_7
{
   public class Program
    {
        static void Main(string[] args)
        {
            

            Author author = new Author("A", "B");
            
            Author author2 = new Author("A3", "B3");
          
            Author author3 = new Author("A4", "B4");
          
            Author author4 = new Author("A5", "B5");        

            Author author5 = new Author("A6", "B6");
            
            Author author6 = new Author("A2", "B2");
          


            Book b1 = new Book("k", 111, 2020, author);

            Book b2 = new Book("k2", 222, 2019, author2);

            Book b3 = new Book("k3", 333, 2018, author3);

            Book b4 = new Book("k4", 444, 2017, author4);

            Book b5 = new Book("k5", 555, 2016, author5);

            Book b6 = new Book("k6", 666, 2015, author6);



            Console.WriteLine(Books);
     
            
     
           







        }
    }
}
