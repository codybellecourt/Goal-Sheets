// Write a program or modify problem GS04-03 to read the data of a text file and count the number of digits (0-9), tabs, spaces, newlines, and total characters (not just the letters but all the characters). Make sure that the counting routine runs until the end of the file is reached. One way to do this is read each line into a String, then check each character in the String one by one (but you cannot count newlines in the String, you will need to count the number of times you read lines). If you decide to modify the old code, copy the .cs file or the whole project. Create a text file for testing the data. (You can do so with any text editor, even your compiler.) Make sure the text file has a known number of digits, tabs, spaces, and newlines (for testing). The total number of characters should just be the number of times your code runs through the inner loop (if you read each line), not the number of letters (you do not need to count letters).

namespace _11_01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// The path to the file that will be read.
			string filePath = "../../../TextFile.txt";

			// The list containing the contents of each line in the file.
			List<string> fileLinesList = new List<string>();

			// The amount of times each digit occurs in the file.
			int[] occurrencesDigits = new int[10];
			int occurrencesDigit = 0;

			// The amount of times each alphabetical letter occurs in the file.
			int[] occurrencesLetters = new int[26];
			int occurrencesLetter = 0;

			// The amount of times the new-line character occurs in the file.
			int occurrencesLine = 0;

			// The amount of times the tab character occurs in the file.
			int occurrencesTab = 0;

			// The amount of times the space character occurs in the file.
			int occurrencesSpace = 0;

			// The amount of times each misc character (such as .?!<>:;'") occurs in the file.
			int occurrencesMisc = 0;

			// The total amount of character occurrences in the file.
			int totalCharacters = 0;

			try
			{
				StreamReader fileReader = new StreamReader(filePath);
				// For each line in the text file.
				while (!fileReader.EndOfStream)
				{
					// Append the line to the fileLinesList and increment the occurrences variable.
					string line = fileReader.ReadLine();
					fileLinesList.Add(line);
					occurrencesLine++;
				}
				fileReader.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				Environment.Exit(0);
			}

			for (int i = 0; i < fileLinesList.Count; i++)
			{
				foreach (char c in fileLinesList[i])
				{
					if (char.IsDigit(c))
					{
						occurrencesDigits[c - '0']++;
						occurrencesDigit++;
					}
					else if (char.IsLetter(c))
					{
						occurrencesLetters[char.ToLower(c) - 'a']++;
						occurrencesLetter++;
					}
					else if (c == '\t')
					{
						occurrencesTab++;
					}
					else if (c == ' ')
					{
						occurrencesSpace++;
					}
					else
					{
						occurrencesMisc++;
					}
					totalCharacters++;
				}
			}

			Console.WriteLine($"Digits: {occurrencesDigit}");
			Console.WriteLine($"Letters: {occurrencesLetter}");
			Console.WriteLine($"Lines: {occurrencesLine}");
			Console.WriteLine($"Tabs: {occurrencesTab}");
			Console.WriteLine($"Spaces: {occurrencesSpace}");
			Console.WriteLine($"Misc Chars: {occurrencesMisc}");
			Console.WriteLine($"Total Chars: {totalCharacters}");
			Console.WriteLine("Press SPACEBAR to see advanced stats, or press any key to exit.");
			var keyInfo = Console.ReadKey(intercept: true);

			if (keyInfo.Key == ConsoleKey.Spacebar)
			{
				for (int i = 0; i < 10; i++)
				{
					Console.WriteLine($"{i}: {occurrencesDigits[i]}");
				}
				for (int i = 0; i < 26; i++)
				{
					Console.WriteLine($"{(char)('a' + i)}: {occurrencesLetters[i]}");
				}
			}
		}
	}
}
