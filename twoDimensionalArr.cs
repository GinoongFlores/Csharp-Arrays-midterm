namespace Arrays
{
    public class twoDimensionalArr
    {
        public static void Main(string[] args)
        {
            /* int[,] numbers = new int[3, 2] { { 2, 4 }, { 12, 5 }, { 10, 9 } };
            foreach (int i in numbers)
            {
                Console.Write("{0} ", i);
            } */

            string[,] alphabet = new string[2, 3] { { "A", "B", "C" }, { "D", "E ", "F" } };
            foreach (string letters in alphabet)
            {
                Console.WriteLine(letters);
            }

            // Iterating C# Array using Loop

            /*   int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 } };

              for (int i = 0; i < numbers.GetLength(0); i++)
              {
                  Console.Write("Row " + i + ": ");

                  for (int j = 0; j < numbers.GetLength(1); j++)
                  {
                      Console.Write(numbers[i, j] + " ");
                  }

                  Console.WriteLine();
              } */
        }
    }
}