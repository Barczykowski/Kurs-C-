using Apka_Szkoleniowa;

namespace Apka_Szkoleniowa
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


                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
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

            AddGrade(gradeAsFloat);
        }


        public override void AddGrade(double grade)

        {
            float gradeAsFloat = (float)grade;

            AddGrade(gradeAsFloat);
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
            var statistics = new Statistics();
            int lineCount = 0;
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var number = float.Parse(line);
                        Console.WriteLine(line);
                        statistics.AddGrade(number);
                    }
                }
            }

            return statistics;
        }
    }
}
















        //{
        //    var gradesFromFile = this.ReadGradesFromFile();
        //    var result = this.CountStatistics(gradesFromFile);
        //    return result;
        //}



//    private Statistics CountStatistics(List<float> grades)
//    {
//        var statistics = new Statistics();

//        foreach (var grade in "grades.txt")
//        {
//            statistics.AddGrade(grade);
//        }

//        return statistics;
//    }


//    private List<float> ReadGradesFromFile()
//    {
//        var grades = new List<float>();
//        if (File.Exists(fileName))
//        {
//            using (var reader = File.OpenText(fileName))
//            {
//                var line = reader.ReadLine();
//                while (line != null)
//                {
//                    var number = float.Parse(line);
//                    grades.Add(number);
//                    line = reader.ReadLine();
//                }
//            }
//        }
//        return grades;
//    }



//}










