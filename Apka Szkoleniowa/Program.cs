using Apka_Szkoleniowa;

var employee = new Employee("Andrzej", "Gołota");
employee.AddGrade("Andrzej");
employee.AddGrade(120);
employee.AddGrade(4);
employee.AddGrade(2);


var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
