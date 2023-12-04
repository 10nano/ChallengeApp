/*
 * Zadanie zrobione bez podpowiedzi - było pouczające.
 * Zaraz idę zobaczyć podpowiedź...
*/

const int NumberOfAllallDigitss = 10;

ulong number = 4565634515375;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
int[] allDigits = new int[NumberOfAllallDigitss];

foreach (int digit in allDigits)
{
    allDigits[digit] = 0; // Zerowania wystąpień każdej cyfry.
}

foreach (char letter in letters)
{
    // Bezpośrednia konwersja znaku cyfry typu char na cyfrę typu int daje 
    // reprezentacje liczbwą danej cyfry w ASCII, dlatego po odjęciu wartości
    // ASCII zera otrzymuję właściwą wartość cyfry typu int np.: '7' -> 7
    int i = letter - '0';

    ++allDigits[i]; // Zliczanie wystąpień każdej cyfry.
}

Console.WriteLine($"Wyniki dla liczby {numberInString}\n");

for (int i = 0; i < NumberOfAllallDigitss; i++)
{
    Console.WriteLine($"Cyfra {i} występuje {allDigits[i]} krotnie");
}
