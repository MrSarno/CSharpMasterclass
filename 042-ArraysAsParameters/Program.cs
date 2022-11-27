namespace ArraysAsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 89, 42, 76, 42, 59, 71, 48, 64, 90, 36 };
            double averageResult = GetAverage(studentsGrades);

            Console.WriteLine("The average is: {0}.", averageResult);
            Console.WriteLine("Grades from {0} students were provided.", studentsGrades.Length);
            Console.ReadLine();
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum+= gradesArray[i];
            }
            average = (double)sum/size; // using a double to ensure precision
            return average;
        }
    }
}