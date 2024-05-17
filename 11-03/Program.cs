namespace _11_03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// The path to the file that will be read.
			string filePathRead = "../../../TextFile.txt";

			// Lists that will contain the data.
			List<string> dataNames = new List<string>();
			List<int> dataAges = new List<int>();
			List<int> dataHeights = new List<int>();
			List<int> dataWeights = new List<int>();
			List<string> dataPhones = new List<string>();

			// Read the file line by line.
			StreamReader fileReader = new StreamReader(filePathRead);
			while (!fileReader.EndOfStream)
			{
				string line = fileReader.ReadLine();

				// Create a temporary list that contains the data of the current line in the file.
				List<string> dataTemp =
				[
					// Splice the string apart using the tabs.
					.. line.Split('\t'),
				];

				// Add the data from the temporary list to its corresponding data list.
				dataNames.Add(dataTemp[0]);
				dataAges.Add(Convert.ToInt32(dataTemp[1]));
				dataHeights.Add(Convert.ToInt32(dataTemp[2]));
				dataWeights.Add(Convert.ToInt32(dataTemp[3]));
				dataPhones.Add(dataTemp[4]);

			}
			fileReader.Close();
			Console.WriteLine("Data initiated.");
			Thread.Sleep(1000);


			while (true)
			{
				Console.Clear();
				Console.WriteLine("1 - Search by name");
				Console.WriteLine("2 - Search by age");
				Console.WriteLine("3 - Search by height");
				Console.WriteLine("4 - Search by weight");
				Console.WriteLine("5 - Search by phone number");

				// Get user input to search by name, age, height, weight, or phone number.
				var keyInfo = Console.ReadKey(intercept: true);

				switch (keyInfo.Key)
				{
					// If "1" is pressed to search by name.
					case ConsoleKey.D1:
						Console.Clear();
						Console.WriteLine("Searching by name\n");

						// How many times this name occurs in the data list.
						int searchNameOccur = 0;

						// Get user input for what to search for.
						string searchName = Console.ReadLine();

						// For each name in the data list.
						for(int i = 0; i < dataNames.Count; i++)
						{
							// If the name is what the user searched.
							if (Convert.ToString(dataNames[i]).ToUpper() == searchName.ToUpper())
							{
								// Increment the occurrence variable and print the corresponding name.
								searchNameOccur++;
								Console.WriteLine($"{dataNames[i]} is {dataAges[i]} years old");
								Console.WriteLine($"{dataNames[i]} is {dataHeights[i]} inches tall");
								Console.WriteLine($"{dataNames[i]} is {dataWeights[i]} pounds heavy");
								Console.WriteLine($"{dataNames[i]}'s phone number is {dataPhones[i]}");
							}
						}
						if (searchNameOccur == 0)
						{
							Console.WriteLine($"There are no entries with the name {searchName}");
						}
						break;

					// If "2" is pressed to search by age.
					case ConsoleKey.D2:
						Console.Clear();
						Console.WriteLine("Searching by age\n");

						// How many times this age occurs in the data list.
						int searchAgeOccur = 0;

						// Get user input for what to search for.
						string searchAge = Console.ReadLine();

						// For each age value in the data list.
						for (int i = 0; i < dataAges.Count; i++)
						{
							// If the age value is what the user searched.
							if (Convert.ToString(dataAges[i]) == searchAge)
							{
								// Increment the occurrence variable and print the corresponding name.
								searchAgeOccur++;
								Console.WriteLine($"{dataNames[i]} is {searchAge} years old");
							}
						}

						// If the searched age value is not in the data list.
						if (searchAgeOccur == 0)
						{
							Console.WriteLine($"There are no entries with the age {searchAge}");
						}
						break;

					// If "3" is pressed to search by height.
					case ConsoleKey.D3:
						Console.Clear();
						Console.WriteLine("Searching by height\n");

						// How many times this height occurs in the data list.
						int searchHeightOccur = 0;

						// Get user input for what to search for.
						string searchHeight = Console.ReadLine();

						// For each height value in the data list.
						for (int i = 0; i < dataHeights.Count; i++)
						{
							// If the height data is what the user searched.
							if (Convert.ToString(dataHeights[i]) == searchHeight)
							{
								// Increment the occurrence variable and print the corresponding name.
								searchHeightOccur++;
								Console.WriteLine($"{dataNames[i]} is {searchHeight} inches tall");
							}
						}

						// If the searched height value is not in the data list.
						if (searchHeightOccur == 0)
						{
							Console.WriteLine($"There are no entries with the height {searchHeight}");
						}
						break;

					// If "4" is pressed to search by weight.
					case ConsoleKey.D4:
						Console.Clear();
						Console.WriteLine("Searching by weight\n");

						// How many times this weight occurs in the data list.
						int searchWeightOccur = 0;

						// Get user input for what to search for.
						string searchWeight = Console.ReadLine();

						// For each weight value in the data list.
						for (int i = 0; i < dataWeights.Count; i++)
						{
							// If the weight value is what the user searched.
							if (Convert.ToString(dataWeights[i]) == searchWeight)
							{
								// Increment the occurrence variable and print the corresponding name.
								searchWeightOccur++;
								Console.WriteLine($"{dataNames[i]} is {searchWeight} pounds heavy");
							}
						}

						// If the searched weight value is not in the data list.
						if (searchWeightOccur == 0)
						{
							Console.WriteLine($"There are no entries with the weight {searchWeight}");
						}
						break;

					// If "5" is pressed to search by phone number.
					case ConsoleKey.D5:
						Console.Clear();
						Console.WriteLine("Searching by phone number\n");

						// How many times this phone number occurs in the data list.
						int searchPhoneOccur = 0;

						// Get user input for what to search for.
						string searchPhone = Console.ReadLine();

						// For each phone number in the data list.
						for (int i = 0; i < dataPhones.Count; i++)
						{
							// If the phone number is what the user searched.
							if (Convert.ToString(dataPhones[i]) == searchPhone)
							{
								// Increment the occurrence variable and print the corresponding name.
								searchPhoneOccur++;
								Console.WriteLine($"{dataNames[i]}'s phone number is {searchPhone}");
							}
						}

						// If the searched phone number is not in the data list.
						if (searchPhoneOccur == 0)
						{
							Console.WriteLine($"There are no entries with the phone number {searchPhone}");
						}
						break;
				}

				// If the pressed key was a valid option.
				if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.D4 || keyInfo.Key == ConsoleKey.D5)
				{
					// Prompt the user to search for something else and restart the program.
					Console.WriteLine("\nPress any key to continue");
					Console.ReadKey(intercept: true);
				}
			}
		}
	}
}
