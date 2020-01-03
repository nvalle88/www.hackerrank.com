using System;
class Solution
{

    static void Main(String[] args)
    {

        string[] lecturaPantallaInicial = Console.ReadLine().Split(' ');
        uint[] parametrosInicialies = Array.ConvertAll(lecturaPantallaInicial, UInt32.Parse);
        uint n = parametrosInicialies[0];
        uint m = parametrosInicialies[1];

        long[] valorLista = new long[n + 1];

        for (int i = 0; i < m; i++)
        {
            string[] lectura = Console.ReadLine().Split(' ');
            uint a = UInt32.Parse(lectura[0]);
            uint b = UInt32.Parse(lectura[1]);
            long k = long.Parse(lectura[2]);

            valorLista[a] += k;
            if (b + 1 <= n) valorLista[b + 1] -= k;
        }

        long auxMaximo = 0;
        long resultado = 0;
        for (int i = 1; i <= n; i++)
        {
            auxMaximo += valorLista[i];
            if (auxMaximo > resultado) resultado = auxMaximo;
        }

        Console.WriteLine(resultado.ToString());
    }
}