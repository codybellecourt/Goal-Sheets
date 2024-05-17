//Write a program to hold the integers of the multiplication table. The table will hold the answers for the 12x12 table. That is to say that the numbers will be the answers for all the simple multiplications from 1 to 12 (do not include 0). (Remember 1x1=1, 1x2=2, 1x3=3, etc.) Note that when storing the numbers, the multiplications are not the same as the indices. They are the multiplications of the index + 1. So calculate accordingly. The 2D List should only be 12 by 12. Also make an interface where you quiz the user with flash cards. Output the random multiplication (3 x 4, for instance), get user input, then check the user input against the answer in the table. Keep giving random multiplications until the user tells you to quit (use a loop). Alternately, you can output the multiplication, wait some amount of time, then flash the answer for a certain amount of time before moving on (or wait for the user to press a key). Make the multiplications random. (As an extension, give the user a choice of looking at the whole table before getting quizzed with flash cards. If you want to get really fancy, you can actually make the UI look like flash cards.)

namespace _10_04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Allow the user to choose what the size of the multiplication table should be.
			Console.WriteLine("How large do you want to you want the multiplication table to be?");
			int size = Convert.ToInt16(Console.ReadLine());

			// Initialize the multiplication table.
			List<List<int>> multiplicationTable = new List<List<int>>();
			for (int a = 1; a <= size; a++)
			{
				List<int> temp = new List<int>();
				for (int b = 1; b <= size; b++)
				{
					temp.Add(a * b);
				}
				multiplicationTable.Add(temp);
			}
			Console.WriteLine($"{size}x{size} multiplication table initialized");
			Thread.Sleep(1000);

			while (true)
			{
				Console.Clear();

				Random rand = new Random();
				int factor1 = rand.Next(0, size);
				int factor2 = rand.Next(0, size);

				Console.Write($"{factor1 + 1} x {factor2 + 1} = ?\n");
				int answer = Convert.ToInt32(Console.ReadLine());

				if (answer == multiplicationTable[factor1][factor2])
				{
					Console.WriteLine("\nYou right");
				}
				else
				{
					Console.WriteLine($"\nYou wrong. The answer is {multiplicationTable[factor1][factor2]}");
				}

				// Intercept the keystroke.
				Console.WriteLine("Press any key to continue");
				Console.ReadKey(intercept: true);
			}
		}
	}
}
