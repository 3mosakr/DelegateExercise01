namespace DelegateExercise01
{
    internal class GradingSystem
    {

        public void DisplayGradinginfo(List<Student> students,
            Func<List<int>, double> calculateAverage,
            Predicate<double> checkIfPassed,
            Action<Student, double, bool> displayData)
        {
            foreach (Student student in students)
            {
                double averageGrades = calculateAverage(student.Grades);
                bool passed = checkIfPassed(averageGrades);

                displayData(student, averageGrades, passed);
                
            }
        }
    }
}
