// Create a comma-delimited file with an int, a double, a String (with or without spaces), and a char (in that order) on each of 10 rows. Write a program to get in the data and then output it into a tab-delimited file. 

namespace _11_02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// The path to the file that will be read.
			string filePathRead = "../../../TextFile.txt";

			// The path to the file that will be written.
			string filePathWrite = "../../../TextFileWrite.txt";

			// Clear the TextFileWrite file.
			File.WriteAllText(filePathWrite, null);
			StreamReader fileReader = new StreamReader(filePathRead);
			StreamWriter fileWriter = new StreamWriter(filePathWrite);

			// For each line in the file.
			while (!fileReader.EndOfStream)
			{
				// Splice the string apart using the commas.
				string line = fileReader.ReadLine();
				string[] tempData = line.Split(',');

				// Convert the temp data to the corresponding list.
				int dataInt = Convert.ToInt32(tempData[0]);
				double dataDouble = Convert.ToDouble(tempData[1]);
				string dataString = Convert.ToString(tempData[2]);
				char dataChar = Convert.ToChar(tempData[3]);

				// Write the data to the file and to the console.
				fileWriter.WriteLine(dataInt + "\t" + dataDouble + "\t" + dataString + "\t" + dataChar);
				Console.WriteLine(dataInt + "\t" + dataDouble + "\t" + dataString + "\t" + dataChar);

			}
			fileReader.Close();
			fileWriter.Close();
		}
	}
}