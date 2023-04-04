using System.ComponentModel.Design;
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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }

            else
            {
                Console.WriteLine("Zbyt duża liczba");
            }  

        }

        public void AddGrade(string grade)

        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            
            else
            {
                Console.WriteLine("String is not float");
            }

        }

        public void AddGrade(double doubleGrade)

        {
            var floatGrade = Math.Round(doubleGrade, 2);
            AddGrade(floatGrade);
  
        }

        public void AddGrade(int intGrade)
        
        {
            float floatGrade = intGrade;
            this.AddGrade(floatGrade);
        }

        public void AddGrade(char charGrade)
        {
            var floatgrade = char.ToString(charGrade);
            this.AddGrade(floatgrade);

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
