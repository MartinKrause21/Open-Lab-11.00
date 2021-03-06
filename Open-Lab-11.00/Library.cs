﻿using Open_Lab_10._00;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open_Lab_11._00
{
    class Library
    {
        

        public List<string> sutdentsList = new List<string>() { "John", "Poul" };
        public List<Book> booksList = new List<Book>();


        public Library() : base ()
        {
          

            booksList = new List<Book>
            {
                new Book("Mato sa uci", 120, "komix",  "Marko", 2001 ),
                new Book("Mato sa uci HTML", 200, "scifi",  "Adam", 2020 ),
                new Book("Mato sa uci dejepis", 310, "roman",  "Peter", 1998 ),
                new Book("Mato sa uci pisat", 154, "komix", "Pavol", 2005)
            };   

        }

        public override string ToString()
        {
            return $" {booksList}";
        }


        public int  WriteNumberOfBook()
        {
            string fab = "";
            for (int i = 0; i < booksList.Count(); i++)
            {
                fab += i;
            }
            return fab.Count();
        }

        public int WriteNumberOfStudents()
        {
            string fab = "";
            for (int i = 0; i < sutdentsList.Count(); i++)
            {
                fab += i;
            }
            return fab.Count();
        }


    }
}
