
using Apka_Szkoleniowa;
using System.Reflection.Metadata;

namespace TestProject1
{
    public class Test_Name
    {


        [Test]
        public void EmployeeNameTest()
        {
            // przygotowanie
            var employee1 = GetEmployee("Andrzej", "Gołota", 54);
            var employee2 = GetEmployee("Mike", "Tyson", 52);


            // uruchomienie testu 


            // sprawdzanie rezultatu 

            Assert.AreNotEqual(employee1, employee2);

        }


        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }


        [Test]
        public void SexTest()
        {
            bool female = false;
            bool male = true;

            Assert.AreNotEqual(male, female);

        }

        [Test]

        public void HeightTest()
        {
            float Height1 = 1.85f;
            float Height2 = 1.85f;

            Assert.AreEqual(Height1, Height2);

        }


        [Test]

        public void WeightTest()
        {
            int Weight1 = 100;
            int Weight2 = 100; 

            Assert.AreEqual(Weight1, Weight2);

        }


        [Test]

        public void NameSurnameDiffrence()
        {
            string name = "Abdrzej";
            string surname = "Gołota";

            Assert.AreNotEqual(name, surname);

        }


    }
}

  