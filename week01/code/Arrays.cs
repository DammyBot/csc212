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

        // STEPS
        // 1. Create an array of doubles with size length
        // 2. Loop from 0 to length and for each index i, set the value of the array at index i to be number * (i + 1) so as to increase the multiple by 1 for each index
        // 3. Return the array
        var results = new double[length];
        for(var i=0; i<length; i++)
        {
            results[i] = number * (i + 1);
            Console.WriteLine(results[i]);
        }


        return results; // replace this return statement with your own
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

        // STEPS
        // 1. Create a new list to hold the rotated values
        // 2. Loop from 0 to data.Count and for each index i, calculate the new index as (i + amount) % data.Count and add the value at index i in data to the new list at the new index
        // 3. Clear the original data list and add all the values from the new list back to the original data list
        var rotated = new List<int>(new int[data.Count]);
        for(var i=0; i<data.Count; i++)
        {
            var newIndex = (i + amount) % data.Count;
            rotated[newIndex] = data[i];
        }
        data.Clear();
        data.AddRange(rotated);
    }
}
