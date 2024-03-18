// See https://aka.ms/new-console-template for more information




// modification 3
Console.WriteLine("Hello, World!");

class Calc
{
    public static double getAverage(int[] numbers)
    {
        if (numbers.Length == 0)
            return 0;

        double sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return sum / numbers.Length;
    }
}
