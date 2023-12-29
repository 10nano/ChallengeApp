using ChallengeApp;

Console.WriteLine("Witamy w Programie ABC do oceny pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

var employeeFile = new EmployeeInFile("Adam", "Kowalski");
var employeeMemory = new EmployeeInMemory("Jan", "Nowak");

employeeFile.ScoreAdded += EmployeeScoreAdded;

void EmployeeScoreAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

employeeFile.AddScore(0.5f);
employeeFile.AddScore(5);
employeeFile.AddScore("55");
employeeFile.AddScore('A');

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę: ");
    var input = Console.ReadLine();
    if (input == "")
    {
        break;
    }
    try
    {
        employeeMemory.AddScore(input);
    }
    catch (Exception exc)
    {
        Console.WriteLine($" Exeption catched: {exc.Message}");
    }
}

var statisticsFile = employeeFile.GetStatistics();
var statisticsMemory = employeeMemory.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Pracownik {employeeFile.Name} {employeeFile.Surname}");
Console.WriteLine($"Średnia ocena: {statisticsFile.Average:N2}");
Console.WriteLine($"Minimalna: {statisticsFile.Min}");
Console.WriteLine($"Maksymalna: {statisticsFile.Max}");
Console.WriteLine($"Średnia litera: {statisticsFile.AverageLetter}");

Console.WriteLine();
Console.WriteLine($"Pracownik {employeeMemory.Name} {employeeMemory.Surname}");
Console.WriteLine($"Średnia ocena: {statisticsMemory.Average:N2}");
Console.WriteLine($"Minimalna: {statisticsMemory.Min}");
Console.WriteLine($"Maksymalna: {statisticsMemory.Max}");
Console.WriteLine($"Średnia litera: {statisticsMemory.AverageLetter}");
