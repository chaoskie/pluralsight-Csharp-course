using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book{
        // variables
        string name;
        List<double> grades;

        public string Name(){return this.name;}

        // constructor
        public Book(string name){
            this.name = name;
            this.grades = new List<double>();
        }

        public Book(string name, List<double> grades){
            this.name = name;
            this.grades = grades;
        }

        // operations
        public void AddGrade(double x){
            this.grades.Add(x);
        }

        public double HighestGrade()
        {
            if(grades.Count<=0){
                return 0.0;
            }
            double highest = this.grades[0];
            foreach (var grade in this.grades)
            {
                highest = Math.Max(grade, highest);
            }
            return highest;
        }

        public double LowestGrade()
        {
            if(grades.Count<=0){
                return 0.0;
            }
            double lowest =this.grades[0];
            foreach (var grade in this.grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            return lowest;
        }

        public double ComputeAverageGrade(){
            double result = 0;
            if(grades.Count<=0){
                return 0.0;
            }

            foreach(var grade in this.grades){
                result+=grade;
            }
            double averageGrade = result /= this.grades.Count;
            
            return averageGrade;
        }

        public void ShowStatistics(){
            Console.Write($"The avarage grade is: {this.ComputeAverageGrade():N1}\n");             
            Console.Write($"The Highest grade is: {this.HighestGrade():N1}\n");             
            Console.Write($"The Lowest grade is: {this.LowestGrade():N1}\n");
        }

        public override string ToString(){
            return $"This book is name {this.name} and contains {this.grades.Count} grades";
        }
    }
}