using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib.book
{
    public class Library
    {

        book[] books = new book[0] ;
        Order [] orders= new Order[0] ; 
        
       public void AddBook(book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
            book.idd ++;
        }

        public book[] FindAllBooks(string name)
        { 
            
            return Array.FindAll(books, x => x.Name == name);
   
        }
        public book findbook(string code)
        {

            return Array.Find(books, x => x.Code == code);
        }

        public void Remove(string code)
        {
         books=Array.FindAll(books, x=>x.Code != code);

        }

    }
}
