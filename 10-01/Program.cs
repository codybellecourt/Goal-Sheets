// Write a program that declares an integer List of 50 elements. (Use a loop to populate the List with consecutive or random numbers.) Then use the fact that scalar multiplication of matrices (Lists) is simply the multiplication of each element in the matrix by the given scalar. Let the user input a number (scalar) that will be used to multiply the matrix (List). Then multiply the matrix by that number. Output the new List values to the screen.

using System.ComponentModel.DataAnnotations;

namespace _10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> intList = new List<double>();
            Random rng = new Random();

            int maxPossibleNumber = 1000;


            for (int i = 0; i < 50; i++)
            {
                double x = rng.Next(1, maxPossibleNumber + 1);
				intList.Add(x);
                Console.WriteLine(x);
            }
            while (true)
            {
                Console.Write("\nEnter a scalar to multiply the list\n");
                double scalar = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\n");

                for (int i = 0; i < 50; i++)
                {
                    Console.Write(intList[i] + " * " + scalar);
                    intList[i] = Convert.ToDouble(intList[i]) * scalar;
                    Console.WriteLine(" = " + intList[i]);
                }
            }
		}
	}
}
