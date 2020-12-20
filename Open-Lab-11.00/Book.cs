using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {

        public string title;
        public int pages;
        public string cathegory;
        public string author;
        public int releaseDate;


        /// <summary>
        /// v tomto liste sa nachadzaju typy knih
        /// </summary>
        /// 
        public static List<string> categoryList = new List<string> { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };


        public Book()
        {
            title = "-1";
            pages = -1;
            cathegory = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
            cathegory = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string title, int pages, string cathegory, string author, int releaseDate)
        {
            this.title = title;
            this.pages = pages;
            this.cathegory = cathegory;
            this.author = author;
            this.releaseDate = releaseDate;

        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    pages = 1;
                }
            }

        }
        public string Cathegory
        {
            get { return cathegory; }
            set { cathegory = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }


        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (value >= 1450 && value <= 2021)
                {
                    releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }
            }

        }


        public override string ToString()
        {
            return $"{Title}, {Pages}, {Cathegory}, {Author},{ReleaseDate}";
        }







    }
}

