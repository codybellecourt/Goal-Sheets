// Write a program or modify problem GS06-03 to have 20 different fortunes stored in a List of strings. Output a fortune based on a random number which will be the index of the List. Continue giving random fortunes until the user chooses to exit.

namespace _10_02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool continueBool = true;
			List<string> fortunesList = new List<string>()
			{
				"You will find unexpected joy today.",
				"A new opportunity will come your way.",
				"Your hard work will pay off soon.",
				"Take a risk; it will be worth it.",
				"Someone you care about will surprise you.",
				"Good things are coming your way.",
				"Your creativity will shine today.",
				"Trust your instincts; they won’t lead you astray.",
				"A pleasant surprise awaits you.",
				"Your kindness will be appreciated.",
				"Stay positive; good things are on the horizon.",
				"A new friendship will blossom.",
				"Your determination will lead to success.",
				"Be open to new experiences.",
				"Your future is bright.",
				"You will overcome a challenge.",
				"Listen to your intuition.",
				"A lucky break is coming your way.",
				"Your dreams are within reach.",
				"Embrace change; it will lead to growth."
			};

			Console.WriteLine("Press any key for a new fortune or press ESC to exit.");

			while (continueBool)
			{
				Random rng = new Random();
				int fortuneNumber = rng.Next(0, fortunesList.Count);

				Console.SetCursorPosition(0, 1);
				Console.Write("                                                          ");
				Console.SetCursorPosition(0, 1);
				Console.Write(fortunesList[fortuneNumber]);

				var keyInfo = Console.ReadKey(intercept: true);

				if (keyInfo.Key == ConsoleKey.Escape)
				{
					continueBool = false;
				}
			}
		}
	}
}
