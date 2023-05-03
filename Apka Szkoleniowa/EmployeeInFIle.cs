﻿using System.IO.Enumeration;

namespace Apka_Szkoleniowa
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.Write(grade);
            }
        }

        public override void AddGrade(int intGrade)

        {
            float floatGrade = intGrade;
            this.AddGrade(floatGrade);
        }

        public override void AddGrade(string grade)

        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }

            else if (grade.Length == 1)
            {
                AddGrade(Convert.ToChar(grade));
            }

            else
            {
                throw new Exception("niewłaściwa wartość");

            }

        }

        public override void AddGrade(double doubleGrade)

        {
            float floatGrade = (float)Math.Round(doubleGrade, 2);
            this.AddGrade(floatGrade);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;

                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;


                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;

                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;

                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;

                default:

                    throw new Exception("podaj literę od A do E");
            }

        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }



        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MaxValue;
            statistics.Min = float.MinValue;


            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Max(statistics.Min, grade);
                    statistics.Average += grade;
                }

            }

            statistics.Average /= grades.Count;

            switch (statistics.Average)
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
                    statistics.AverageLetter = 'D';

                    break;

                default:
                    statistics.AverageLetter = 'E';

                    break;
            }

            return statistics;
        }

    }

}

