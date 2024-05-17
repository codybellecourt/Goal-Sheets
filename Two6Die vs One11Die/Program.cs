namespace Two6Die_vs_One11Die
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rng = new Random();
			int dieSix1;
			int dieSix2;
			int dieEleven;

			Console.WriteLine("How many times do you want to test this?");
			int rolls = Convert.ToInt32(Console.ReadLine());

			int[] answersSix = new int[11];
			int[] answersEleven = new int[11];


			for (int i = 0; i < rolls; i++)
			{
				dieSix1 = rng.Next(1,7);
				dieSix2 = rng.Next(1,7);
				int totalSix = dieSix1 + dieSix2;

				answersSix[totalSix - 2]++;
				Console.WriteLine($"Dice 6 iteration {i+1} rolled");
			}
			Console.WriteLine($"Dice 6 rolls have finished");
			Thread.Sleep(1500);
			Console.Clear();

			for (int i = 0; i < rolls; i++)
			{
				dieEleven = rng.Next(2, 13);

				answersEleven[dieEleven - 2]++;
				Console.WriteLine($"Die 11 iteration {i+1} rolled");
			}
			Console.WriteLine($"Die 11 rolls have finished");
			Thread.Sleep(1500);
			Console.Clear();

			for (int i = 0; i < 11; i++)
			{
				Console.WriteLine($"Two 6 sided dice rolled {i + 2} a total of {answersSix[i]} times");
			}
			Console.WriteLine();
			for (int i = 0; i < 11; i++)
			{
				Console.WriteLine($"One 11 sided die rolled {i + 2} a total of {answersEleven[i]} times");
			}
		}
	}
}
