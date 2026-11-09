class Program
{
    // The input {-5, -2, -9} gives a wrong answer because max
    // is initialized to 0. Since all array elements are negative,
    // none is greater than 0, so the method incorrectly returns 0.
    static int FindMax(int[] values)
    {
        int max = values[0];// time complexity O(1) , space complexity O(1) reason:assignment takes constant time because we 
                            /**Both normal variable assignment and assigning an individual array element to a variable have O(1) time and auxiliary space complexity.

        In normal assignment, we store a fixed value in a variable, requiring a constant amount of work and memory.

In array assignment, we use direct indexing to retrieve an element from a known position.Array access does not depend on the total number of elements because we don't traverse or search the array.

In both cases, only a fixed amount of additional memory is required, so auxiliary space complexity is O(1).**/
        

        foreach (int v in values)//O(1) complexity as long as the input is increasing loop will run increase so its proportional to input 
            // space is O(1) because will inputs itration increase and it require more space to store the nos
        {
            if (v > max)
                max = v;
        }

        return max;
    }
    static void Main()
    {
        int[] numbers = { -5, -2, -9 };
        int result = FindMax(numbers);
        Console.WriteLine($"the max no is : {result}");
        int[] no2 = { 4, 9, 12 };
        int result2 = FindMax(no2);
        Console.WriteLine($"max no in sec list is:{result2}");


    }
}