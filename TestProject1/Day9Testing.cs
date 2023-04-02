using Apka_Szkoleniowa;

internal class Day9Tests
{
    [Test]
    public void TestEmployeeScoreMax()
    {
        var employee = new Employee("Maciek", "Nowak");
        employee.AddGrade(5);
        employee.AddGrade(2);
        employee.AddGrade(8);
        employee.AddGrade(-15);

        var statistics = employee.GetStatistics();

        Assert.AreEqual(8, statistics.Max);
    }

    [Test]
    public void TestEmployeeScoreMin()

    {
        var employee = new Employee("Maciek", "Nowak");
        employee.AddGrade(5);
        employee.AddGrade(2);
        employee.AddGrade(8);
        employee.AddGrade(-15);

        var statistics = employee.GetStatistics();

        Assert.AreEqual(-15, statistics.Min);
    }

    [Test]
    public void TestEmployeeScoreAverage()
    {
        var employee = new Employee("Maciek", "Nowak");
        employee.AddGrade(5);
        employee.AddGrade(2);
        employee.AddGrade(8);
        employee.AddGrade(-15);

        var statistics = employee.GetStatistics();

        Assert.AreEqual(0, statistics.Average);
    }

}
