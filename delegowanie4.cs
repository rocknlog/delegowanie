using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] tablica = {
            {1, 2, 3},
            {4, 5, 6},
            {1, 3, 2},
            {4, 2, 3},
            {1, 2, 4}
        };

        int[] najblizszeWiersze = ZnajdzNajblizszeWiersze(tablica);

        Console.WriteLine("Najbliższe wiersze: " + najblizszeWiersze[0] + ", " + najblizszeWiersze[1]);
    }

    static int[] ZnajdzNajblizszeWiersze(int[,] tablica)
    {
        int najmniejszaRoznica = int.MaxValue;
        int[] najblizszeWiersze = new int[2];

        int liczbaWierszy = tablica.GetLength(0);
        int liczbaKolumn = tablica.GetLength(1);

        for (int i = 0; i < liczbaWierszy; i++)
        {
            for (int j = i + 1; j < liczbaWierszy; j++)
            {
                int roznica = ObliczRoznice(tablica, i, j, liczbaKolumn);

                if (roznica < najmniejszaRoznica)
                {
                    najmniejszaRoznica = roznica;
                    najblizszeWiersze[0] = i;
                    najblizszeWiersze[1] = j;
                }
            }
        }

        return najblizszeWiersze;
    }

    static int ObliczRoznice(int[,] tablica, int i, int j, int liczbaKolumn)
    {
        int roznica = 0;

        for (int k = 0; k < liczbaKolumn; k++)
        {
            int aik = tablica[i, k];
            int ajk = tablica[j, k];
            roznica += (aik - ajk) * (aik - ajk);
        }

        return roznica;
    }
}
