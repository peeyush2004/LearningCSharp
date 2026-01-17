namespace ListApp2
{
    internal class Sortinglist
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 43, 4, 2, 32, 12 };

            Console.WriteLine("Unsorted list:");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            numbers.Sort();
            Console.WriteLine("Sorted list:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
