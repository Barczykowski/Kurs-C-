using Apka_Szkoleniowa;
namespace Piersze.Testowanie;


    internal class Tests
    {
        [Test]
        public void Test1()
        {
            var employee = new Employee("Maciek", "Nowak", 45);
            employee.AddScore(5);
            employee.AddScore(2);
            employee.AddScore(8);
            employee.AddScore(-15);
            
           var result = employee.Result;

            Assert.AreEqual(0, result);
        }
 
    }
