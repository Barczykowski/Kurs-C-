namespace Apka_Szkoleniowa
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

   

        public void AddGrade(string grade)
        
            {
                switch (grade)
                {
                    case "1":
                        this.grades.Add(0);
                        break;

                    case "2-":
                        this.grades.Add(15);
                        break;

                    case "2":
                        this.grades.Add(20);
                        break;

                    case "2+":
                        this.grades.Add(25);
                        break;

                    case "3-":
                        this.grades.Add(35);
                        break;

                    case "3":
                        this.grades.Add(40);
                        break;

                    case "3+":
                         this.grades.Add(45);
                         break;

                    case "4-":
                        this.grades.Add(55);
                        break;

                    case "4":
                        this.grades.Add(60);
                        break;

                    case "4+":
                        this.grades.Add(65);
                        break;

                    case "5-":
                        this.grades.Add(75);
                        break;
                  
                    case "5":
                        this.grades.Add(80);
                        break;

                    case "5+":
                        this.grades.Add(85);
                        break;

                    case "6-":
                        this.grades.Add(95);
                        break;

                    case "6":
                        this.grades.Add(100);
                        break;
                    
                    default:

                        throw new Exception("podaj ocenę od 1 do 6");
                }
            }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}



