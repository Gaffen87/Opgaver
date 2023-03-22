﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book) 
        { 
            books.Add(book);
        }

        public Book GetBook(string itemId) 
        {
            foreach (var book in books)
            {
                if (book.ItemId == itemId) 
                    return book;
            }
            return null;
        }

        //public double GetTotalValue() 
        //{ 
        //    double total = 0;
        //    Utility utility = new Utility();

        //    foreach (var book in books)
        //    {
        //        total += utility.GetValueOfBook(book);
        //    }
        //    return total;
        //}


    }
}
