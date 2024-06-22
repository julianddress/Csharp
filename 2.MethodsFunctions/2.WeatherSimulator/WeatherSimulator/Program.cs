namespace WeatherSimulator
{
    internal class Program
    {
        static int days = 0;
        static int greater = 0;
        static int lower = 41;
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days to calculate the weather: ");
            days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Cloudy", "Rainy", "Snowy" };
            string[] weather = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++) {
                temperature[i] = random.Next(-10, 40);
                weather[i] = conditions[random.Next(conditions.Length)];

                Console.Write($"The Temperature for day {i} is: {temperature[i]}°C ");
                Console.WriteLine($"and its Weather is: {weather[i]} ");
            }

            Console.WriteLine();
            
            Console.WriteLine("Higer temperature: " + max(temperature));
            Console.WriteLine("Lower temperature: " + min(temperature));

            Console.WriteLine();

            Console.WriteLine("The average temperature is: " + average(temperature));

            Console.WriteLine();

            Console.WriteLine("The most common weather is: " + maxRepetitions(weather));

            Console.ReadKey();
        }

        static double average(int[] temperature) {

            double average = 0;

            for (int i = 0; i < temperature.Length; i++) {
                average = average + temperature[i];
            }
            
            return average / temperature.Length;
        }

        static int min(int[] temperature) {

            lower = temperature[0];

            foreach (var item in temperature)
            {
                if (item < lower) {
                    lower = item;
                }
            }

            return lower;
        
        }

        static int max(int[] temperature)
        {

            greater = temperature[0];

            foreach (var item in temperature)
            {
                if (item > greater)
                {
                    greater = item;
                }
            }

            return greater;

        }

        static string maxRepetitions(string[] conditions) {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int temCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i] ) {
                        temCount++;
                    }
                }
                if (temCount > count)
                {
                    count = temCount;
                    mostCommon = conditions[i];                  
                }
            }

            return mostCommon;
        }
    }
}
