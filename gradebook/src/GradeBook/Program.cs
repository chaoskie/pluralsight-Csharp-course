using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() {12.4, 37.1, 11.78, 44.2, 26.1, 82.6};
            Book book = new Book("MyBooklet", grades);
            
            book.ShowStatistics();             
        }
    }
}
