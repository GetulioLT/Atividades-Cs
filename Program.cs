/*
    Avaliação Lógica de Programação em C#
    Avaliação 4: Vetores, Matriz, Lista e Dicionario.
    Questão: Leia um vetor de 10 posições. Conte e 
    escrever quantos valores pares e impares ele possui.
 */
using System;
using System.Collections.Generic;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*================ Váriaveis ================*/

            Random num = new Random();
            int[] a = new int[10];
            int par = 0;
            int impar = 0;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            for (int i = 0; i < 10; i++)
            {
                a[i] = num.Next(0, 100);
            }

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            foreach (int b in a)
            {
                if (b % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }

            /*===========================================*/

            /*============= Saída de Dados ==============*/

            Console.WriteLine($"A soma dos numeros pares é: {par}, e dos numeros impares é: {impar}");

            /*===========================================*/

            Console.ReadLine();
        }
    }
}