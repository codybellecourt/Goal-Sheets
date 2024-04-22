// Make an app that calculates a user’s average speed (miles per hour) and average fuel consumption (miles per gallon). Make sure to address the user when you ask for the input. Get the appropriate input from the user (miles traveled, hours traveled, gallons used). Make sure to address the user when you come up with the answer and label the output appropriately. Output the average speed to the nearest mile per hour (mph) and the average fuel consumption to the nearest tenth of a mile per gallon (mpg). (Hint: use double data and Console.WriteLine() using { 0:0.0} as was shown in earlier example code but which used 3 decimal places instead.)

namespace _2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How far did you drive (in miles)?\n");
            int miles = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How long did it take (in minutes)?\n");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much gas was used (in gallons)?\n");
            int gallons = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(miles + " miles");
            Console.WriteLine(minutes + " minutes");
            Console.WriteLine(gallons + " gallons\n");

            double MPH = miles / (minutes / 60);
            double MPG = miles / gallons;

            double roundedMPH = Math.Round(MPH);
            double roundedMPG = Math.Round(MPG, 1);

            Console.WriteLine(roundedMPH + " Miles per Hour");
            Console.WriteLine(roundedMPG + " Miles per Gallon");
        }
    }
}
