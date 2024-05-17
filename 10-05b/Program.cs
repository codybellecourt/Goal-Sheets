/* (You may do the matrix multiplication problem instead of doing the card shuffler. You do not need to do both.)

Create a class for a playing card.The class will have two enum datatypes. One for the suits and one for the designation. [Note: There is a hierarchy of suits.They are ranked from lowest to highest: clubs, diamonds, hearts, spades.] The class will also have face values for each card from 1 to 13. So your class will have three instance variables (or properties), suit, designation, and face value. You may also have a string for the name of the card, which will tell you its designation and suit (i.e. Jack of Diamonds).

Create a List and populate it with cards. I would suggest populating it with cards in order. Then, you will need to create a function that shuffles the cards. That function will give you a random number between 0 and 51 (inclusive), which will be used as the index for a card in the List to be switched with the last card in the deck. Then, you exclude the last card in the deck (essentially making the unshuffled deck smaller each iteration) and do the same process until you have swapped all the cards. This is a well-known shuffling algorithm (which I forget the name of right now).

Once you have created the shuffling function, you will deal the deck into four hands. These hands will be held in a two-dimensional List. The first dimension will be the number of hands (4) and the second dimension will be the number of cards each hand holds (13). Make sure to deal the cards into the hands one card at a time from the deck. When you are finished dealing the cards, output each hand to the screen. Your deck may be full or empty when you are finished, but make sure that you output the deck in the shuffled order as well as outputting each hand. Label your output appropriately. [Note: You may label each hand in the output as North, South, East, and West, the traditional positions of bridge hands.] */

namespace _10_05b
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
}
