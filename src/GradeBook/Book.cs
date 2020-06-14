using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book 
    {
        public string Name;
        private List<double> grades;

        public Book(string name){
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade){
            grades.Add(grade);
        }

        public Statistics GetStatistics(){
            Statistics result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(double grade in this.grades){
                result.High = Math.Max(result.High, grade);
                result.Low = Math.Min(result.Low, grade);
                result.Average += grade;    
            }
            result.Average /= grades.Count;
            
            return result;
        }
        
    }
}