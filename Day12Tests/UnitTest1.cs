using Apka_Szkoleniowa;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

public class Day12Tests
{

    [Test]

    public void TestingMinGrade()

    {
        var Employee = new Employee();

        Employee.AddGrade(60);
        Employee.AddGrade(80);
        Employee.AddGrade(20);

        var statistics = Employee.GetStatistics();

        Assert.AreEqual(statistics.Min, 20);
    }



    [Test]

    public void TestingMaxGrade()

    {
        var Employee = new Employee();

        Employee.AddGrade(64);
        Employee.AddGrade(90);
        Employee.AddGrade(30);

        var statistics = Employee.GetStatistics();

        Assert.AreEqual(statistics.Max, 90);
    }


    [Test]
       public void TestingAverageLetter()

        {
           var Employee = new Employee();
           
            Employee.AddGrade("b");
            Employee.AddGrade("D");
            Employee.AddGrade("c");

            var statistics = Employee.GetStatistics();
    
           Assert.AreEqual(statistics.AverageLetter, 'B');
        }

        [Test]

        public void TestingAverageWithAnotherVars()
    
        {
            var Employee = new Employee();

            Employee.AddGrade(50);
            Employee.AddGrade("D");
            Employee.AddGrade(85);

            // Average 58,333332

            var statistics = Employee.GetStatistics();

            Assert.AreEqual(statistics.Average, 58, 333332);

        }



        [Test]

        public void TestingAverageWithAnotherVars2()

        {
            var Employee = new Employee();

            Employee.AddGrade(50.56);
            Employee.AddGrade("D");
            Employee.AddGrade(85);
            Employee.AddGrade('a');


            // Average 68,89

            var statistics = Employee.GetStatistics();

            Assert.AreEqual(statistics.Average, 68, 89);

          }


    }

