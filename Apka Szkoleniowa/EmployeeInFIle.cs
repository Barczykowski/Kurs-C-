﻿namespace Apka_Szkoleniowa
{
    public class EmployeeInFile : EmployeeBase
    {
        public event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)

                {
                    writer.WriteLine(grade);
                    
                    if (GradeAdded != null)
                    {
                      GradeAdded(this, new EventArgs());
                    }
                    
                }

                else
                {
                    throw new Exception("niewłaściwa wartość");
                }
            }
        }

        public override void AddGrade(int grade)

        {
            float gradeAsFloat = (float)grade;
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(gradeAsFloat);
                }
                else
                {
                    throw new Exception("niewłaściwa wartość");
                }
            }
        }


        public override void AddGrade(double grade)

        {
            float gradeAsFloat = (float)grade;
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(gradeAsFloat);
            }
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


        public override void AddGrade(char grade)
        {
            {
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(100);
                        }
                        break;

                    case 'B':
                    case 'b':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(80);
                        }
                        break;


                    case 'C':
                    case 'c':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(60);
                        }
                        break;

                    case 'D':
                    case 'd':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(40);
                        }
                        break;

                    case 'E':
                    case 'e':
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(20);
                        }
                        break;

                    default:

                        throw new Exception("podaj literę od A do E");
                }

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
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
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
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
           
            
            
            foreach (var grade in grades)

            
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
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

