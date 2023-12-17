/// 1. Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek
/// oraz punkty pracownika w postaci liczb całkowitych
/// 
/// 2. Stwórz trzech pracowników i każdemu przydziel po 5 ocen z zakresu
/// od 1 do 10
/// 
/// 3. Napisz program, który wyszuka pracownika z najwyższą liczbą ocen
/// a następnie wyświetli jego dane oraz wynik.
/// 
/// Wersja ze wskazówką - lista pracowników - można łatwo dodawać kolejnych pracowników.

using ChallengeApp;

var emp1 = new Employee("Adam", "Kowalski", 44);
var emp2 = new Employee("Zuzia", "Nowak", 23);
var emp3 = new Employee("Damian", "Zientarski", 33);
var emp4 = new Employee("Gerard", "Hohenzollern", 88);

emp1.AddScore(5);
emp2.AddScore(6);
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

int bestResult = -1;    
Employee bestEmployee = null;

foreach (var employee in employees)
{
    if (employee.Result > bestResult)
    {
        bestEmployee = employee;    
    }
    
}

Console.WriteLine($"W tym miesiącu z wynikiem {bestEmployee.Result} najlepszym pracownikiem został:");
Console.WriteLine($"{bestEmployee.Name} {bestEmployee.Surname} lat {bestEmployee.Age}");