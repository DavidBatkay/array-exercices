namespace array_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadNumber("No. of elements= ", 3);
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = ReadNumber($"Element at index {i}= ", 1);
            }

            string elements= string.Join(", ", array);
            Console.WriteLine("Array=" + elements);

            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }

        static int ReadNumber(string label, int maxAttempts)
        {
            int attempts = 1;
            
            do
            {
                Console.Write(label);
                string input = Console.ReadLine();
                bool isValidNumber = int.TryParse(input, out int result);
                if (isValidNumber)
                {
                    return result;
                }
                if (attempts < maxAttempts)
                {
                    Console.WriteLine($"Value '{input}' is not a valid number, please try again.");
                }
                attempts++;
               
            } while (attempts<=maxAttempts);
            Console.WriteLine($"No valid number input, continuing with 0 as value");
            return 0;
        }
    }
}