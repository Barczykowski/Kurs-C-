using Apka_Szkoleniowa;


Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Maciek", "Barczykowski");
employee.AddGrade(10);
employee.AddGrade(50);
employee.AddGrade(28.5);
employee.AddGrade('A');
employee.AddGrade(30);
employee.AddGrade("C");




var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
