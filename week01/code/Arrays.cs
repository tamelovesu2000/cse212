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
        // PLAN:
        // 1. Create a new double array with a size equal to the
        //    length provided to the function.
        // 2. Use a for loop to go through each position in the array.
        // 3. Since the first multiple should be the starting number,
        //    multiply the number by the current index plus 1.
        // 4. Store the calculated multiple in the corresponding
        //    position in the array.
        // 5. After the loop has finished, return the completed array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // 1. Calculate the index where the last 'amount' items begin.
        // 2. Use GetRange() to copy the last 'amount' items into a temporary list.
        // 3. Use RemoveRange() to remove those items from the original list.
        // 4. Use InsertRange() at index 0 to put the saved items at the beginning.
        // 5. The existing data list is now rotated to the right.

        int startIndex = data.Count - amount;

        List<int> lastItems = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);

        data.InsertRange(0, lastItems);
    }
}