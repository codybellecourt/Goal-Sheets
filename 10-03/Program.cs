// Lists can be used as lookup tables for values that are often calculated in a program. By using lookup tables instead of always calculating the answer, you can often make programs run faster because the tables hold the data that takes up processor time to calculate. Create two lookup tables (Lists) – one for the sine and one for the cosine values. Each lookup table should hold the sine or cosine value for each degree from 0 to 359. (You may create one 2D lookup table if you would like.) When calculating the sine or cosine value, you must make sure that the argument of the function (sin(), cos()) is in radians. Remember that 180° equal π radians. Use Math.PI as your constant for π.

namespace _10_03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// The lists for the sine and cosine values for each angle.
			List<double> sinLookup = new List<double>();
			List<double> cosLookup = new List<double>();

			// For each angle (0 through 359).
			for (int i = 0; i < 360; i++)
			{
				// Calculate the sine and cosine for the angle and add it to the data list.
				sinLookup.Add(Math.Sin(i * (Math.PI / 180)));
				cosLookup.Add(Math.Cos(i * (Math.PI / 180)));
			}
			Console.WriteLine("Lookup tables created.");
			Thread.Sleep(1000);
			Console.Clear();

			while (true)
			{
				Console.WriteLine("What angle would you like to view?");
				// Read the user input, and calculate with a modulus of 360, and get the output. The modulus allows angles above 359 to be calculated, as 0 = 360, 720, etc.
				int input = Convert.ToInt16(Console.ReadLine()) % 360;

				// Print the corresponding values.
				Console.WriteLine($"\nSin: {sinLookup[input]}\nCos: {cosLookup[input]}");
			}
		}
	}
}
