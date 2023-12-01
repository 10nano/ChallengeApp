// Ustawianie danych
var name = "Ewa";
var age = 33;
// 'W' = Woman, 'M' = Man
var sex = 'W';

// weryfikacja i wyswietlanie
if (sex == 'W' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33 && sex == 'W')
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Ktoś nieznany");
}

