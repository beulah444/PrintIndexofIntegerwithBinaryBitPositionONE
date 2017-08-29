using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter an integer");
        bool isNum = int.TryParse(Console.ReadLine(), out int result);
        if (isNum)
        {
            var binary = Convert.ToString(result, 2);
            string b = binary.ToString();
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == '1')
                {
                    Console.WriteLine("At index {0} has binary 1 bit", i);
                }
                else
                { continue; }
            }

        }
        else
        {
            Console.WriteLine("invalid number");
        }
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();

    }
}