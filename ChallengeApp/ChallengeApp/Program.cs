using ChallengeApp;

Console.WriteLine("Witamy w Programie ABC do oceny pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

// var employee = new EmployeeInMemeory("Adam", "Kowalski");
var employee = new EmployeeInFile("Adam", "Kowalski");
employee.AddScore(0.5f);
employee.AddScore(5f);
employee.AddScore("55");
employee.AddScore('A');

//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę: ");
//    var input = Console.ReadLine();
//    if (input == "")
//    {
//        break;
//    }
//    try
//    {
//        employee.AddScore(input);
//    }
//    catch (Exception exc)
//    {
//        Console.WriteLine($" Exeption catched: {exc.Message}");
//    }
//}

var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Pracownik {employee.Name} {employee.Surname}");
Console.WriteLine($"Średnia ocena: {statistics.Average:N2}");
Console.WriteLine($"Minimalna: {statistics.Min}");
Console.WriteLine($"Maksymalna: {statistics.Max}");
Console.WriteLine($"Średnia litera: {statistics.AverageLetter}");
