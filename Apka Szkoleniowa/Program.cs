using Apka_Szkoleniowa;

var employee1 = new Employee("Maciek", "Nowak", 45);
var employee2 = new Employee("Marek", "Kowal", 35);
var employee3 = new Employee("Darek", "Krawczyk", 28);


employee1.AddScore(20);
employee1.AddScore(2);
employee1.AddScore(5);

employee2.AddScore(3);
employee2.AddScore(9);
employee2.AddScore(1);

employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(3);

List<Employee> Employers = new List<Employee>()

{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee EmployeeWithMaxResult = null;

foreach (var employee in Employers)

{
if (employee.Result > maxResult)

    {
        maxResult = employee.Result;
        EmployeeWithMaxResult = employee;
    }
}


Console.WriteLine("Najwięcej Punktów Zdobywa");
Console.WriteLine(EmployeeWithMaxResult.Name);
Console.WriteLine(EmployeeWithMaxResult.Surname);
Console.WriteLine("lat" + EmployeeWithMaxResult.Age);
