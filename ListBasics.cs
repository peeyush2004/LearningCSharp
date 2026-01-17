namespace ListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring a list and initializing
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Yellow");
            colors.Add("Orange");
            colors.Add("Red");
            colors.Add("Red");
            colors.Add("Red");

            //another method of adding items to list 
            List<string> days =
                ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];


            Console.WriteLine("Current colors in list");
            //iterating through the list
            foreach (string color in colors)
            {
                Console.WriteLine(color);

            }

            bool isDeletingSuccessful = colors.Remove("Red");
            while (isDeletingSuccessful)
            {
                isDeletingSuccessful = colors.Remove("Red");
                isDeletingSuccessful = colors.Remove("Red");
            }
            Console.WriteLine();
            Console.WriteLine("Current colors in list");
            foreach (string color in colors)
            {
                Console.WriteLine(color);

            }
            Console.WriteLine();
            Console.WriteLine("Days in the days list: ");
            foreach (string Day in days)
            {
                Console.WriteLine(Day);
            }

            Console.ReadKey();
        }
    }
}
