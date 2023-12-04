/*
 * Zadanie zrobione bez podpowiedzi - było pouczające.
 * Zaraz idę zobaczyć podpowiedź...
*/

const int NumberOfAllDigits = 10;

ulong number = 45664157566; // Dana liczba.

string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

int[] digit = new int[NumberOfAllDigits];

foreach (int item in digit)
{
    digit[item] = 0; // Zerowania wystąpień każdej cyfry.
}

foreach (char item in letters)
{
    // Bezpośrednia konwersja znaku cyfry typu char na cyfrę typu int daje 
    // reprezentacje liczbwą danej cyfry w ASCII, dlatego po odjęciu wartości
    // ASCII zera otrzymuję właściwą wartość cyfry typu int np.: '7' -> 7
    int i = item - '0';

    ++digit[i]; // Zliczanie wystąpień każdej cyfry.
}

Console.WriteLine($"Wyniki dla liczby {number}\n");

for (int i = 0; i < NumberOfAllDigits; i++)
{
    Console.WriteLine($"Cyfra {i} występuje {digit[i]} krotnie");
}
