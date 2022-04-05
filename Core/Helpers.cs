public static class Helpers
{
    static void Main()
    { }
    public static double GetNumberFromUser(string nameOfNumber)
    {
        Console.Write($"Enter number {nameOfNumber}: ");
        string userInput = Console.ReadLine();
        bool isNumber = double.TryParse(userInput, out double result);
        if (isNumber)
        {
            return result;
        }
        else
        {
            throw new Exception("Input value is not a number");
        }
    }
    public static string GetStringFromUser(string nameOfString)
    {
        Console.WriteLine($"Enter string {nameOfString}: ");
        string input = Console.ReadLine();
        return input;
    }
}