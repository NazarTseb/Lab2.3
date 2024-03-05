class Program
{
    static void Main()
    {

        List<int> numbers = new List<int> { 5, -15, 25, 10, 100, 50, 75, 15 };

        var NeededNumbers = numbers.Where(n => n >= 10 && n <= 99).OrderBy(n => n);

        Console.WriteLine("Додатні двозначні числа, відсортовані по зростанню:");
        foreach (var number in NeededNumbers)
        {
            Console.WriteLine(number);
        }
    }
}