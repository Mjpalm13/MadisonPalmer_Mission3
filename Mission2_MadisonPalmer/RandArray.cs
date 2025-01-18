namespace Mission2_MadisonPalmer
{
    internal class RandArray
    {
        public int[] CreateArray(int num)
        {
            // Create the empty array
            int[] rollTotals = new int[13];

            // Initialize random object
            Random rnd = new Random();

            for (int i = 0; i < num; i++) // Loop through num
            {
                int die1 = rnd.Next(1, 7); // Random number for die1
                int die2 = rnd.Next(1, 7); // Random number for die2
                int total = die1 + die2;   // Sum of the two dice

                rollTotals[total]++; // Increment array accordingly
            }
            
            // Return rolls array
            return rollTotals;
        }
    }
}