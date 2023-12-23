using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");

employee.AddScore(0);
employee.AddScore("50");
employee.AddScore(3);
employee.AddScore((double)7);
employee.AddScore((long)9);
employee.AddScore((float)5);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

