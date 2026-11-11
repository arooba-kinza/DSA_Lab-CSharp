
using System;

class Program
{
    static void Main()
    {
        // Array with capacity of 10
        int[] rollList = new int[10];

        // Number of students currently in the list
        int count = 4;

        // Initial roll numbers
        rollList[0] = 1001;
        rollList[1] = 1004;
        rollList[2] = 1007;
        rollList[3] = 1010;

        // 1. INSERT 1005 AT POSITION 2

        int position = 2;
        int newRoll = 1005;

        // Shift elements one position to the right
        for (int i = count; i > position; i--)
        {
            rollList[i] = rollList[i - 1];
        }

        // Insert new roll number
        rollList[position] = newRoll;

        // Increase count
        count++;

        Console.WriteLine("After insertion:");

        for (int i = 0; i < count; i++)
        {
            Console.Write(rollList[i] + " ");
        }

        Console.WriteLine();


        // 2. DELETE ROLL NUMBER AT POSITION 0

        position = 0;

        // Shift elements one position to the left
        for (int i = position; i < count - 1; i++)
        {
            rollList[i] = rollList[i + 1];
        }

        // Decrease count
        count--;

        Console.WriteLine("\nAfter deletion:");

        for (int i = 0; i < count; i++)
        {
            Console.Write(rollList[i] + " ");
        }

        Console.WriteLine();


        // 3. LINEAR SEARCH FOR 1007

        int searchValue = 1007;
        int foundPosition = -1;

        for (int i = 0; i < count; i++)
        {
            if (rollList[i] == searchValue)
            {
                foundPosition = i;
                break;
            }
        }

        if (foundPosition != -1)
        {
            Console.WriteLine(
                "1007 found at position: " + foundPosition
            );
        }
        else
        {
            Console.WriteLine("Not found");
        }


        // 4. TOTAL NUMBER OF STUDENTS

        Console.WriteLine("Total students: " + count);
    }
}
