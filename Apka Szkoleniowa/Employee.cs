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

        public Employee()
        {
           
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



        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;

                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;


                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;

                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;

                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;

                default:
                    Console.WriteLine("Niewłaściwa wartość");
                    break;

            }


        }


        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            var statistic = 0;


            foreach (var grade in this.grades)
            {


                statistics.Max = Math.Max(statistics.Max, this.grades[statistic]);
                statistics.Min = Math.Min(statistics.Min, this.grades[statistic]);
                statistics.Average += grades[statistic];

            }



            statistics.Average /= this.grades.Count;

            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                break;

                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                break;

                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                break;

                case var average when average >= 20:
                    statistics.AverageLetter = 'C';
                break;

                default:
                    statistics.AverageLetter = 'E';
                break;
            }

            return statistics;
        }


     

    }
}