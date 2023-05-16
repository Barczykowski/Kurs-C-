
using static Apka_Szkoleniowa.EmployeeBase;

namespace Apka_Szkoleniowa
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        Statistics GetStatistics();

        void AddGrade(int grade);

        void AddGrade(string grade);

        void AddGrade(double grade);

        void AddGrade(char grade);

        void AddGrade(float grade);

        public event GradeAddedDelegate GradeAdded;

    }
}
