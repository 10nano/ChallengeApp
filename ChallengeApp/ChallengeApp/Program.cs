using ChallengeApp;

var emp1 = new Employee("Adam", "Kowalski", 44);
var emp2 = new Employee("Zuzia", "Nowak", 23);
var emp3 = new Employee("Damian", "Zientarski", 33);
var emp4 = new Employee("Gerard", "Hohenzollern", 88);

emp1.AddScore(5);
emp2.AddScore(7);
emp3.AddScore(7);
emp4.AddScore(8);

emp1.AddScore(8);
emp2.AddScore(9);
emp3.AddScore(10);
emp4.AddScore(8);

emp1.AddScore(1);
emp2.AddScore(2);
emp3.AddScore(3);
emp4.AddScore(8);

emp1.AddScore(4);
emp2.AddScore(5);
emp3.AddScore(6);
emp4.AddScore(8);

emp1.AddScore(7);
emp2.AddScore(8);
emp3.AddScore(9);
emp4.AddScore(8);

List<Employee> employees = new List<Employee>()
{
    emp1, emp2, emp3, emp4
};

var stat1 = emp1.GetStatistics();
var stat2 = emp2.GetStatistics();

Console.WriteLine($"Average: {stat1.Average:N2}");
Console.WriteLine($"Min: {stat1.Min}");
Console.WriteLine($"Max: {stat1.Max}");

Console.WriteLine($"Average: {stat2.Average:N2}");
Console.WriteLine($"Min: {stat2.Min}");
Console.WriteLine($"Max: {stat2.Max}");

