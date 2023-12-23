using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");

employee.AddScore(0);
employee.AddScore("50");
employee.AddScore(3);
employee.AddScore((double)7);
employee.AddScore((long)9);
employee.AddScore((float)5);

var statistics1 = employee.GetStatisticsWithForeach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithDoWhile();

Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");

