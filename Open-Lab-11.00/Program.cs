using Open_Lab_10._00;
using System;
using System.Linq;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Library schoolLibrary = new Library();

            

            Book book = new Book();
                                    
            //john
            Console.WriteLine(schoolLibrary.sutdentsList[0]);

            //knihy
            Console.WriteLine(schoolLibrary.booksList[0]);
            Console.WriteLine(schoolLibrary.booksList[1]);


               Console.WriteLine();

            //poul
            Console.WriteLine(schoolLibrary.sutdentsList[1]);

            //knihy
            Console.WriteLine(schoolLibrary.booksList[2]);
            Console.WriteLine(schoolLibrary.booksList[3]);

               Console.WriteLine();

            //pocet knih
            Console.WriteLine("pocet knih");
            Console.WriteLine(schoolLibrary.WriteNumberOfBook());

               Console.WriteLine();

            //pocet ludi
            Console.WriteLine("pocet ludi");
            Console.WriteLine(schoolLibrary.WriteNumberOfStudents());





        }
    }
}
