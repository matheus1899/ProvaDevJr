using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaDevJr
{
    class Tarefa3
    {
        static void Main(string[] args)
        {
            List<int> conjunto = new List<int>() { 2, 7, 11, 15 };

            int soma1 = 9;
            int soma2 = 22;
            mostrarPosicoesDaSoma(conjunto, soma1);
            mostrarPosicoesDaSoma(conjunto, soma2);
            Console.ReadKey();
        }
        static void mostrarPosicoesDaSoma(List<int> lista, int soma)
        {
            int position1 = 0;
            int position2 = 0;
            bool position = false;
            
            //Bolha
            for(int i= 0; i<lista.Count; i++)
            {
                for (int j = 0; j<lista.Count; j++)
                {
                    if(j == i)
                    {
                        continue;
                    }
                    if (lista[i]+lista[j] == soma)
                    {
                        position = true;
                        position1 = i;
                        position2 = j;
                        break;
                    }
                }
                if (position)
                {
                    break;
                }
            }
            if (position1 == position2)
            {
                return;
            }
            Console.WriteLine("Soma: " + soma + " = " +lista[position1]+" + "+lista[position2]);
        }
    }
}
