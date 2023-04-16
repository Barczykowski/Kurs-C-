using Apka_Szkoleniowa;
using System.Diagnostics;
using System.Runtime.CompilerServices;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("___________________________________________");
Console.WriteLine();



var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
     if (input == "q")
    {
       break;
    }

    employee.AddGrade(input);
}



var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");


