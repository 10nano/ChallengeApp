using ChallengeApp;

Console.WriteLine("Witamy w Programie ABC do oceny pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new Employee("Adam", "Kowalski");

while(true)
{
    Console.WriteLine("Podaj kolejną ocenę: ");
    var input = Console.ReadLine();
    if(input == "")
    {
        break;
    }
    employee.AddScore(input);
}

var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");

