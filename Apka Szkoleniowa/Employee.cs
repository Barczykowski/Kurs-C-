namespace Apka_Szkoleniowa;

class Employee
{
    private List<int> Score = new List<int>();


    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }

    public string Name { get;   set; }

    public string Surname { get;  set; }

    public int Age { get;  set; }

    public int Result
 
    {

        get
        {
            return this.Score.Sum();
        }
    }

    public void AddScore(int number)
    {
        this.Score.Add(number);
    }

}



