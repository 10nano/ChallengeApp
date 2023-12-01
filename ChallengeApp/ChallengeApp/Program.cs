// Ustawianie danych
var name = "Ewa";
var age = 36;
// 'W' = Woman, 'M' = Man
var sex = 'M';
var noOutput = true;

// weryfikacja i wyswietlanie
if (sex == 'W' && age < 30)
{
    Console.WriteLine("Hi woman under thirty");
    noOutput = false;
}
if (name == "Ewa" && age == 33)
{
    // chciałem sprawdzić jak to działa
    Console.WriteLine($"Hi {name}, you are {age} old");
    noOutput = false;
}
if (sex == 'M' && age < 18)
{
    Console.WriteLine("Hi adolescent man");
    noOutput = false;
}
if (noOutput)
{
    Console.WriteLine("Hello unknown!");
}

