// Ustawianie danych
var name = "Ewa";
var age = 13;
// 'W' = Woman, 'M' = Man
var sex = 'M';

// weryfikacja i wyswietlanie
if (sex == 'W' && age < 30)
{
    Console.WriteLine("Hi woman under thirty.");
}
else if (name == "Ewa" && age == 33 && sex == 'W')
{
    Console.WriteLine($"Hi {name}, you are {age} old.");
}
else if (sex == 'M' && age < 18)
{
    Console.WriteLine("Hi adolescent man.");
}
else
{
    Console.WriteLine("Hello unknown!");
}

