using System;

class MediaDeCoxinhas
{
    static void Main(string[] args)
    {
        String[] line = Console.ReadLine().Split(" ");

        float H = Int32.Parse(line[0]);
        float P = Int32.Parse(line[1]);

        float total = (H / P);

        if (H % P != 0)
            Console.WriteLine(Math.Round(total, 2).ToString("0.00"));
        else
            Console.WriteLine(total.ToString("0.00"));

    }
}