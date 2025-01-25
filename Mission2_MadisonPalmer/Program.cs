namespace Mission2_MadisonPalmer;

internal static class Program
{
    private static void Main()
    {
        // Import RandArray class
        var ar = new RandArray();
        
        // Gather user input with validation
        Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many rolls would you like to simulate?");
        int numRolls;

        while (!int.TryParse(Console.ReadLine(), out numRolls) || numRolls <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer for the number of rolls:");
        }

        // Pass data to a new class "RandArray"
        // Assign the returned array to 'result'
        int[] result = ar.CreateArray(numRolls);

        // Write the results
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n" +
                          "Each '*' represents 1% of the total number of rolls.\n" +
                          "Total number of rolls = " +  numRolls + ".\n");

        for (int i = 2; i < result.Length; i++) // For every spot in the array
        {
            // Calculate the percentage
            int pct = result[i] * 100 / numRolls;

            // Write the number we are looking at
            Console.Write(i + ": ");
            
            // Write an asterisk for the percent value
            for (int j = 0; j < pct; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }

        // Thank the user for playing!
        Console.WriteLine("\nThank you for using the dice throwing simulator!");
    }
}