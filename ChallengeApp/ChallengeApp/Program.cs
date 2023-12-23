using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");

employee.AddScore("Adam");
employee.AddScore("5000");
employee.AddScore(3);
employee.AddScore((double)7);
employee.AddScore((long)9);
employee.AddScore((long)9000);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
