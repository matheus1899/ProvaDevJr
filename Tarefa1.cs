using System;
using System.Collections.Generic;

namespace ProvaDevJr
{
    class Tarefa1
    {
        static void Main2(string[] args)
        {
            List<int> listaOriginal = new List<int>() { 7, 5, 3, 9, 6, 4, 1 };
            List<int> listaNova = new List<int>();
            for (int i = 0; i < listaOriginal.Count; i++)
            {
                if (listaOriginal[i] == 4)
                {
                    continue;
                }
                else if (listaOriginal[i] == 9)
                {
                    listaNova.Add(5);
                    continue;
                }
                else
                {
                    listaNova.Add(listaOriginal[i]);
                }
            }
            exibeLista(listaOriginal, "Original");
            exibeListaESomatoria(listaNova, "Nova    ");
            Console.ReadKey();
        }
        static void exibeLista(List<int> lista, string nomeLista)
        {
            int tamanho = lista.Count;

            Console.Write(nomeLista + ": ");
            for (int i = 0; i < tamanho; i++)
            {
                if (i == tamanho - 1)
                {
                    Console.WriteLine(lista[i]);
                }
                else
                {
                    Console.Write(lista[i] + ", ");
                }
            }
        }
        static void exibeListaESomatoria(List<int> lista, string nomeLista)
        {
            int tamanho = lista.Count;
            int soma = 0;
            Console.Write(nomeLista + ": ");
            for (int i = 0; i < tamanho; i++)
            {
                soma += lista[i];
                if (i == tamanho - 1)
                {
                    Console.WriteLine(lista[i]);
                }
                else
                {
                    Console.Write(lista[i] + ", ");
                }
            }
            Console.WriteLine("Somatoria: " + soma);
        }
    }
}
