using Apka_Szkoleniowa;

var employee = new Employee("Andrzej", "Gołota");
employee.AddGrade(5);
employee.AddGrade(3);
employee.AddGrade(4);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

SetSth(out statistics);
 void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}