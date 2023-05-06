namespace Apka_Szkoleniowa
{
    public class EmployeeInMemory : EmployeeBase
    {

        public event GradeAddedDelegate GradeAdded;


        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {            
        }



        public override void AddGrade(float grade)

        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }    
            }

            else
            {
                throw new Exception("zbyt duża liczba");

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

        public override void AddGrade(int intGrade)

        {
            float floatGrade = intGrade;
            this.AddGrade(floatGrade);
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

                    throw new Exception("podaj literę od A do E");
            }


        }

        public override Statistics GetStatistics()
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



            statistics.Average /= this.grades.Count;

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