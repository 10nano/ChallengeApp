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

var user1 = new Employee("Adam", "Kowalski");
var user2 = new Employee("Zuzia", "Nowak");
var user3 = new Employee("Damian", "Zientara");

user1.AddScore(2);
user1.AddScore(5);
int result = user1.Result;
Console.WriteLine(result);
