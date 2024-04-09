class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two integers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int min = GetMin(num1, num2);

        Console.WriteLine("The smallest of the two integers is: " + min);
    }

    static int GetMin(int a, int b)
    {
        return Math.Min(a, b);
    }
}