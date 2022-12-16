class Program
{
    static void Main(string[] args)
    {
        string X = Console.ReadLine();
        int x = int.Parse(X);

        int lineCount = 1;

        while (x > lineCount)
        {
            x -= lineCount;
            lineCount++;
        }

        if (lineCount % 2 == 1)
            Console.Write($"{lineCount - x + 1}/{x}");
        else
            Console.Write($"{x}/{lineCount - x + 1}");
    }
}