namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("../../../input.txt");
                StreamWriter writer = new StreamWriter("../../../output.txt");

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                    writer.WriteLine(line);
                }
                reader.Close();
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}