using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj czas w sekundach: ");
        int czas;

        while (!int.TryParse(Console.ReadLine(), out czas) || czas < 0)
        {
            Console.WriteLine("Niepoprawny czas. Podaj czas w sekundach: ");
        }

        string sformatowanyCzas = FormatujCzas(czas);
        Console.WriteLine("Sformatowany czas: " + sformatowanyCzas);
    }

    static string FormatujCzas(int czas)
    {
        int godziny = czas / 3600;
        int minuty = (czas % 3600) / 60;
        int sekundy = czas % 60;

        string sGodziny = godziny.ToString().PadLeft(2, '0');
        string sMinuty = minuty.ToString().PadLeft(2, '0');
        string sSekundy = sekundy.ToString().PadLeft(2, '0');

        string sformatowanyCzas = $"{sGodziny}:{sMinuty}:{sSekundy}";

        return sformatowanyCzas;
    }
}
