namespace Avg_Temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dayTemp = { 7, 4, 5, 5, 4, 4, 4 };//defines the data
            double sum = 0;//gives a sum variable for adding up
            double maxTemp = dayTemp[0];
            double minTemp = dayTemp[0];
            for (int i = 0; i < dayTemp.Length; i++) //starta a for loop for counting numbers
            {
                sum += dayTemp[i];
                if (dayTemp[i] > maxTemp)
                {
                    maxTemp = dayTemp[i];
                }
                if (dayTemp[i] < minTemp)
                {
                    minTemp = dayTemp[i];
                }
            }
            Console.WriteLine(sum / dayTemp.Length);
            Console.WriteLine(maxTemp);
            Console.WriteLine(minTemp);


        }
    }
}
