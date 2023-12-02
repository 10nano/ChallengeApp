// Ustawianie danych
var name = "Ewa";
var age = 33;
var isWoman = true;

// weryfikacja i wyswietlanie
if (isWoman && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33 && isWoman)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (!isWoman && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Ktoś nieznany");
}

