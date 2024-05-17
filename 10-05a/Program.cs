/* (You may do the card shuffler instead of doing the matrix multiplication problem. You do not need to do both.) The mathematical concept of matrix multiplication is a useful tool in 2-D and 3-D graphics. Write a program that will find the dot product of two 3x3 matrices. See below for the formulas used to take the dot product of two 3x3 matrices:

Dot Product of two 3x3 matrices.

Let:

	┌				┐
	│ a00  a01  a02	│
A = │ a10  a11  a12	│
	│ a20  a21  a22	│
	└				┘
	┌				┐
	│ b00  b01  b02	│
B = │ b10  b11  b12	│
	│ b20  b21  b22	│
	└				┘
	┌				┐
	│ c00  c01  c02	│
C = │ c10  c11  c12	│
	│ c20  c21  c22	│
	└				┘
The subscripts represent the row and column of the item in the matrices. The first row of matrix A is thus a00 a01 a02 while the first column of A is a00 a10 a20. When you take the dot product of two matrices, you multiply the first element of the row by the first element of the column and add it to the product of the second element of the row multiplied by the second element of the column and add it to the product of the third element of the row multiplied by the third element of the column. So when we multiply matrices C = AB, and the first element of C is c00 = a00b00 + a01b10 + a02b20. The complete dot product array is thus:

	┌																					┐
	│ a00*b00+a01*b10+a02*b20     a00*b01+a01*b11+a02*b21      a00*b02+a01*b12+a02*b22	│
C = │ a10*b00+a11*b10+a12*b20     a10*b01+a11*b11+a12*b21      a10*b02+a11*b12+a12*b22	│
	│ a20*b00+a21*b10+a22*b20     a20*b01+a21*b11+a22*b21      a20*b02+a21*b12+a22*b22	│
	└																					┘
Remember that the matrix dot product is not commutative (AB != BA).

(If you pay attention to the subscripts, you should be able to see an easy way to do the dot product for multiplying 3x3 List using loops.) */

namespace _10_05a
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Matrix A (Factor 1).
			List<List<int>> a = new List<List<int>>()
			{
				new List<int> {3, 2, 8},
				new List<int> {7, 5, 4},
				new List<int> {1, 9, 6}

			};
			// Matrix B (Factor 2).
			List<List<int>> b = new List<List<int>>()
			{	new List<int> {1, 2, 3},
				new List<int> {4, 5, 6},
				new List<int> {7, 8, 9}	
			};
			// Matrix C (result).
			List<List<int>> c = new List<List<int>>()
			{
				new List<int> {0, 0, 0},
				new List<int> {0, 0, 0},
				new List<int> {0, 0, 0}
			};

			// Loop for each column.
			for (int x = 0; x < 3; x++)
			{
				// Loop for each row.
				for (int y = 0; y < 3; y++)
				{
					// Loop for each part of the equation.
					for(int z = 0; z < 3; z++)
					{
						// Calculate the matrix multiplication.
						c[x][y] += (a[x][z] * b[z][y]);

						// Credit for formula
						// https://www.c-sharpcorner.com/article/matrix-multiplication-in-c-sharp-applying-transformations-to-images/
					}
				}
			}

			// Print the final result to the console.
			Console.WriteLine($"[ {c[0][0]} ]  [ {c[0][1]} ]  [ {c[0][2]} ]");
			Console.WriteLine($"[ {c[1][0]} ]  [ {c[1][1]} ]  [ {c[1][2]} ]");
			Console.WriteLine($"[ {c[2][0]} ]  [ {c[2][1]} ]  [ {c[2][2]} ]");

			Console.Write("Matrix Multiplication complete");
		}
	}
}
