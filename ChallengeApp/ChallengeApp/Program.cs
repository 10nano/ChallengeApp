using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");

employee.AddScore(1);
employee.AddScore(0);
employee.AddScore(3);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");