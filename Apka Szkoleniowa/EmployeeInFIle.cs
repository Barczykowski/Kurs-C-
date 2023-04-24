using System.IO.Enumeration;

namespace Apka_Szkoleniowa
{
    public class EmployeeInFIle : EmployeeBase
    {
        private const string fileName = "Grades.txt";

        public EmployeeInFIle(string name, string surname) : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.Write(grade);
            }
        }

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            if (File.Exists(fileName))

            {

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                    }
                }
            }
            return result;
        }

    }
}


