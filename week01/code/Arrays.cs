public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Step 1: Create a new array with the requested length.
        double[] multiples = new double[length];

        // Step 2: Start a loop that goes through each position in the array.
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple by multiplying the starting
            // number by the current position plus one.
            multiples[i] = number * (i + 1);
        }

        // Step 4: Return the completed array.
        return multiples;
    }


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Get the total number of elements in the list.
        int count = data.Count;

        // Step 2: Calculate where the list should be divided.
        int splitIndex = count - amount;

        // Step 3: Get the last elements that need to move to the beginning.
        List<int> lastElements = data.GetRange(splitIndex, amount);

        // Step 4: Get the elements that will remain after the rotation.
        List<int> firstElements = data.GetRange(0, splitIndex);

        // Step 5: Clear the original list.
        data.Clear();

        // Step 6: Add the last elements to the beginning of the list.
        data.AddRange(lastElements);

        // Step 7: Add the remaining elements to the end of the list.
        data.AddRange(firstElements);
    }

}
