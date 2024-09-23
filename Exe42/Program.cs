using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 42: Quadrados na Faixa de Valores

            // Descrição:
            // Este exercício consiste em desenvolver um programa que apresente como resultado os quadrados dos números inteiros existentes na faixa de valores de 15 a 200.

            // Passo a Passo:

            // 1. Inicialização:
            //    - Inicialize uma variável para armazenar o resultado dos quadrados.
            double quad = 0;
            double Rquad;

            // 2. Laço de Iteração:
            //    - Inicie um laço de iteração que percorre os números inteiros de 15 a 200.
            //    - Para cada número inteiro na faixa especificada, calcule o seu quadrado e armazene o resultado.
            for (int i = 15; i < 201; i++)
            {
                quad = i;
                Console.WriteLine(quad);
            }

            Console.WriteLine("");
            Rquad = quad * quad;
            Console.WriteLine(Rquad);

            Console.ReadKey();
            // 3. Saída de Dados:
            //    - Apresente os quadrados dos números inteiros na faixa de valores de 15 a 200.

            // Exemplo em Pseudocódigo:
            // INICIALIZAÇÃO: resultado_quadrados = ""
            // PARA cada número de 15 a 200 FAÇA
            //     quadrado = número * número
            //     resultado_quadrados += quadrado + ", "
            // EXIBIR resultado_quadrados
        }
    }
}
