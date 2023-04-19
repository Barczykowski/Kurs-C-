using Apka_Szkoleniowa;
using System;
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


     try
    {
        employee.AddGrade(input);
    }
    catch(Exception exception)
    {
        Console.WriteLine(exception.Message);
    }


   
}

var Statistics = employee.GetStatistics();
Console.WriteLine($"Average: {Statistics.Average}");
Console.WriteLine($"Max: {Statistics.Max}");
Console.WriteLine($"Min: {Statistics.Min}");


