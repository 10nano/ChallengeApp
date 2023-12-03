const int allDigitsCount = 10;

ulong number = 4566457566;

string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

int[] digits = new int[allDigitsCount];

foreach (var item in digits)
{
    digits[item] = 0;
}

Console.WriteLine($"Wyniki dla liczby {number}\n");

foreach (var item in letters)
{
    // konwersja znaku cyfry na cyfrę
    int i = item - '0';

    digits[i]++;

}

for (int i = 0; i < allDigitsCount; i++)
{
    Console.WriteLine($"Cyfra {i} występuje {digits[i]} krotnie");
}