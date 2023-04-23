using Apka_Szkoleniowa;
using System.ComponentModel;

public class Day12Tests

{
    [Test]
    public void TestingGradesAsString()
    {
    
    var Employee = new Employee();

        var statistics = Employee.GetStatistics().Min;

        Employee.AddGrade(20);
        Employee.AddGrade(30);
        Employee.AddGrade(40);


       Assert.AreEqual(statistics, 20);

    }
}
