namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Cloudy", "Rainy", "Stormy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 35); // Temperature between -10 and 35 degrees Celsius
                if (temperature[i] <= 0)
                {
                    weatherConditions[i] = "Snowy";
                }
                else
                {
                    weatherConditions[i] = conditions[random.Next(conditions.Length - 1)];
                }
                Console.WriteLine($"Day {i + 1}: {temperature[i]}°C, {weatherConditions[i]}");

            }
            temperature.Max();
            temperature.Min();
            Console.WriteLine($"The highest Temprature for the following days is: {temperature.Max()}");
            Console.WriteLine($"The lowest Temprature for the following days is: {temperature.Min()}");
            Console.WriteLine($"The average Temprature for the following days is: {CalculateAverage(temperature)}");
            Console.ReadKey();

        }

        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;

            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            double average = sum / temperature.Length;
            return temperature[0];
        }
    }
}
