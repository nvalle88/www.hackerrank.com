using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSwaps2
{
    class Program
    {
        static void Main(string[] args)
        {

            Buscar();
        }


        private static void Buscar()
        {
            Console.WriteLine("Entre el array ejemplo: 1 2 3 5 4 6");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            var arraySalida = new int[] { };
            int cantidad = 0;
            minimumSwaps(arr, out arraySalida, out cantidad);

            Console.WriteLine(String.Join(",", arraySalida));
            Console.WriteLine("Pasos: " + cantidad.ToString());
            Console.WriteLine("Enter para realizar de Nuevo");
            Console.ReadLine();
            Buscar();

        }

        private static void minimumSwaps(int[] arr ,out int[] arraySalida,out int cantidad)
        {
            /* Declaramos otras variables que
	        * nos serviran para iterar. */
            
            var arrOrdenado = arr.OrderBy(f=>f).ToArray();
            var arrAux = new int[arr.Count()];
            var posicionMayor = 0;
            var posicionMenor = 0;
            var iguales = false;
            var pasos = 0;
            for (int i = 0; i < arrOrdenado.Length; i++)
            {
                var elementoMenor = arrOrdenado[i];
                var elementoMayor = arrOrdenado[arrOrdenado.Count()-1 - i];

                 posicionMenor = i;
                 posicionMayor = arrOrdenado.Count() - 1 - i;
                
                arrAux[posicionMayor] = elementoMayor;
                arrAux[posicionMenor] = elementoMenor;
                pasos++;

                for (int m = 0; m < arrAux.Count(); m++)
                {
                    if (arrOrdenado[m]!=arrAux[m])
                    {
                        iguales = false;
                        break;
                    }
                    iguales = true;
                }
                if (iguales)
                {
                    break;
                }
            }
            
            cantidad = pasos;
            arraySalida = arrAux;
           
        }
    }
}
