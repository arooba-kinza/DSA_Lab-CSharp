using System;

class Program
{
    /*
       Natural Language Algorithm:
       1. Initialize sum to 0.
       2. Traverse through the marks array.
       3. Add each mark to sum.
       4. Divide sum by the number of marks.
       5. Return the average.

       Pseudocode:
       START
           INPUT marks
           sum = 0

           FOR each mark in marks
               sum = sum + mark
           END FOR

           average = sum / length of marks
           RETURN average
       STOP
    */

    static double Average(int[] marks)
    {
        int sum = 0;

        foreach (int mark in marks)
        {
            sum += mark;
        }

        return (double)sum / marks.Length;
    }

    static void Main()
    {
        int[] marks = { 7, 8, 6, 9, 10 };

        Console.WriteLine("Average = " + Average(marks).ToString("F2"));
    }
}