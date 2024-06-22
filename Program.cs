namespace CSharp6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a mathematical expression: ");
            string input = Console.ReadLine();

            try
            {
                string[] parts = input.Split('*');

                int result = 1;

                foreach (string part in parts)
                {
                    int number = int.Parse(part);
                    result *= number;
                }

                Console.WriteLine("Result: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input contains invalid characters.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: One of the numbers is too large or too small to process.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown error: " + ex.Message);
            }
        }
    }
}
