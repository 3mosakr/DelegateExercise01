


namespace DelegateExercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            while (true)
            {

                Console.WriteLine("Welcome to the graing system");

                Console.WriteLine("Please enter your name or 'done' to exit: ");
                string studentName = Console.ReadLine();

                if (studentName == "done")
                    break;
                List<int> studentGrades = new List<int>();
                Console.WriteLine("Please enter your graders: (5 subjects) ");
                for (int i = 0; i < 5; i++)
                {
                    int gradeValue = int.Parse(Console.ReadLine());
                    studentGrades.Add(gradeValue);
                }

                Student student = new Student
                {
                    Name = studentName,
                    Grades = studentGrades
                };

                students.Add(student);

                Console.WriteLine($"A new student added to the system with name {student.Name} with total {student.Grades.Count} ");

            }

            GradingSystem gradingSystem = new GradingSystem();
            //gradingSystem.DisplayGradinginfo(students,
            //    (grades) => grades.Sum() / grades.Count,
            //    (a) => a >= 30,
            //    (s, a, p)=> Console.WriteLine($"Student {s.Name} with average {a} is {(p ? "Passed" : "Failed")}"));
            
            gradingSystem.DisplayGradinginfo(students,
                calculageAverage,
                checkIfStudentPassed,
                displayData);

        }


        private static void displayData(Student student, double average, bool isPassed)
        {
            Console.WriteLine($"The student name is {student.Name} and average grade is {average}");
            Console.WriteLine($"The student name is {student.Name} and status is {(isPassed ? "Passed" : "Failed")}");
        }

        private static double calculageAverage(List<int> grades)
        {
            return grades.Sum() / grades.Count;
        }

        private static bool checkIfStudentPassed(double averageValue)
        {
            if (averageValue >= 30)
                return true;
            return false;
        }
    }
}
