// Write a C# program to input your .net technology marks into array
// and find min,max and average marks.

using System;
using System.ComponentModel;
using System.Linq;

namespace Lab1
{
    internal class Marks
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());
            int[] marks = new int[numStudents];
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter the marks for student {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            int minMarks = marks[0];
            int maxMarks = marks[0];
            int sum = 0;

            for (int i = 0; i < numStudents; i++)
            {
                if (marks[i] < minMarks)
                    minMarks = marks[i];

                if (marks[i] > maxMarks)
                    maxMarks = marks[i];

                sum += marks[i];
            }
            double averageMarks = (double)sum / numStudents;

            Console.WriteLine($"\nMinimum Marks: {minMarks}");
            Console.WriteLine($"Maximum Marks: {maxMarks}");
            Console.WriteLine($"Average Marks: {averageMarks:F2}");
            Console.ReadKey();
        }
    }
}