namespace Student_Grading_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare an array of student names
            string[] names = { "Sophia", "Nicolas", "Zahirah", "Jeong" };

            // Declare a two-dimensional array of assignment grades
            int[,] grades = { { 93, 87, 98, 95, 100 }, { 80, 83, 82, 88, 85 }, { 84, 96, 73, 85, 79 }, { 90, 92, 98, 100, 97 } };

            // Declare a variable to store the number of assignments
            int numAssignments = 5;

            // Loop through each student in the array
            for (int i = 0; i < names.Length; i++)
            {
                // Declare a variable to store the total score for each student
                int total = 0;

                // Loop through each assignment grade for each student
                for (int j = 0; j < numAssignments; j++)
                {
                    // Add the grade to the total score
                    total = total + grades[i, j];
                }

                // Calculate the average score by dividing the total score by the number of assignments
                double average = (double)total / numAssignments;

                // Show the student's name and final score on the screen
                Console.WriteLine(names[i] + ": " + average);
            }

        }
    }
}
