/// 1. Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek
/// oraz punkty pracownika w postaci liczb całkowitych
/// 
/// 2. Stwórz trzech pracowników i każdemu przydziel po 5 ocen z zakresu
/// od 1 do 10
/// 
/// 3. Napisz program, który wyszuka pracownika z najwyższą liczbą ocen
/// a następnie wyświetli jego dane oraz wynik.
/// 

using ChallengeApp;

var user1 = new Employee("Adam", "Kowalski", 44);
var user2 = new Employee("Zuzia", "Nowak", 23);
var user3 = new Employee("Damian", "Zientarski", 33);

user1.AddScore(5);
user2.AddScore(6);
user3.AddScore(7);
user1.AddScore(8);
user2.AddScore(9);
user3.AddScore(10);
user1.AddScore(1);
user2.AddScore(2);
user3.AddScore(3);
user1.AddScore(4);
user2.AddScore(5);
user3.AddScore(6);
user1.AddScore(7);
user2.AddScore(8);
user3.AddScore(9);

Employee bestEmployee;

if (user1.Result > user2.Result && user1.Result > user3.Result)
{
    bestEmployee = user1;
}
else if (user2.Result > user3.Result)
{
    bestEmployee = user2;
}
else
{
    bestEmployee = user3;
}

Console.WriteLine($"W tym miesiącu z wynikiem {bestEmployee.Result} najlepszym pracownikiem został:");
Console.WriteLine($"{bestEmployee.Name} {bestEmployee.Surname} lat {bestEmployee.Age}");