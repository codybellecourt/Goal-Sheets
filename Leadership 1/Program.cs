namespace Leadership_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int Heads = 0;
            int Tails = 0;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    int coinFlip = rng.Next(1, 3);

                    switch (coinFlip)
                    {
                        case 1:
                            Heads++;
                            break;

                        case 2:
                            Tails++;
                            break;
                    }
                }

            }
        }
    }
}
