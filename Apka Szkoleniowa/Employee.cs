using System.Diagnostics;

namespace Apka_Szkoleniowa
{
    public class Employee
    {

        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
            {

            this.Name = name;
            this.Surname = surname;
            }
    
        public string Name { get; set; }
     
        public string Surname { get; set; }

        public void AddGrade(float grade)
       
        {
            this.grades.Add(grade); 
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;


            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /=  this.grades.Count;

            return statistics; 
        }
            
    }
}
