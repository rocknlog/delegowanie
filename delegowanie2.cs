using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Obliczanie długości odcinka w układzie kartezjańskim dwuwymiarowym");

        Console.Write("Podaj współrzędną x punktu początkowego: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Podaj współrzędną y punktu początkowego: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Podaj współrzędną x punktu końcowego: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Podaj współrzędną y punktu końcowego: ");
        double y2 = double.Parse(Console.ReadLine());

        double dlugosc = ObliczDlugoscOdcinka(x1, y1, x2, y2);

        Console.WriteLine("Długość odcinka: " + dlugosc);
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double dlugosc = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return dlugosc;
    }
}
