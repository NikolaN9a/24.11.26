using System.Globalization;

namespace Практически_задачи_с_цикли
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете стъпка K: ");
            int k = int.Parse(Console.ReadLine());

            double sum = 0;
            double maxLoad = -1;
            int maxHour = 0;
            int count = 0;
            int criticalPeaks = 0;

            for (int hour = 0; hour <= 23; hour += k)
            {
                Console.Write($"Въведете CPU натоварване за {hour}:00: ");
                double load = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                sum += load;
                count++;

                if (load > maxLoad)
                {
                    maxLoad = load;
                    maxHour = hour;
                }

                if (load > 85.0)
                {
                    criticalPeaks++;
                }
            }

            double average = sum / count;

            Console.WriteLine();
            Console.WriteLine($"Средно натоварване: {average:F2}%");
            Console.WriteLine($"Пиков час: {maxHour}:00 ({maxLoad:F1}%)");
            Console.WriteLine($"Критични пикове (>85%): {criticalPeaks}");
        }
    }
}
