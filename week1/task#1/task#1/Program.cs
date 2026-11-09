/*
Name: Your Name
Roll Number: Your Roll Number
Date: 09-11-2026
Task: Calculate Average of Quiz Marks

NATURAL LANGUAGE ALGORITHM:
1. Start.
2. Initialize an array containing quiz marks.
3. Initialize sum to 0.
4. Traverse the array.
5. Add each mark to sum.
6. Divide sum by the number of elements.
7. Return the average.
8. Stop.

PSEUDOCODE:

BEGIN
    marks ← [7, 8, 6, 9, 10]
    sum ← 0

    FOR each mark in marks
        sum ← sum + mark
    END FOR

    average ← sum / length(marks)
    RETURN average
END
*/

using System;

class Program
{
    static double Average(int[] marks)
    {
        int sum = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            sum = sum + marks[i];
        }

        double average = (double)sum / marks.Length;

        return average;
    }

    static void Main()
    {
        int[] marks = { 7, 8, 6, 9, 10 };

        double result = Average(marks);

        Console.WriteLine($"Average = {result:F2}");
    }
}

/*
Time Complexity: O(n)
Space Complexity: O(1)
*/