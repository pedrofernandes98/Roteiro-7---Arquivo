using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6_lista7
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            int cont = 0;
            FileStream arq = new FileStream("entrada.txt", FileMode.Create);
            StreamWriter escreve = new StreamWriter(arq);

            escreve.WriteLine(1.2);
            escreve.WriteLine(2.4);
            escreve.WriteLine(3.2);
            escreve.WriteLine(4.5);
            escreve.WriteLine(5);
            escreve.WriteLine(6);
            escreve.WriteLine(7);
            escreve.WriteLine(8.2);
            escreve.WriteLine(9);

            escreve.Close();
            Console.WriteLine("Dados carregados com sucesso no arquivo");

            FileStream arq2 = new FileStream("entrada.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq2);

            double[] vet = new double[9];
            double[,] mat = new double[3, 3];
            
            for(int i = 0; i < 9; i++)
            {
                vet[i] = double.Parse(ler.ReadLine());
            }

            Console.WriteLine("Digite um número para multiplicar os elementos da matriz:");
            num = double.Parse(Console.ReadLine());

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    mat[i, j] = (vet[cont] * num);
                    ++cont;
                }
            }

            FileStream arq3 = new FileStream("saida.txt", FileMode.Create);
            StreamWriter escreve2 = new StreamWriter(arq3);

            

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    escreve2.Write(mat[i, j] + " | ");
                }
                escreve2.WriteLine(" \n");
            }

            escreve2.Close();
            Console.WriteLine("A matriz resultante foi escrita com sucesso no arquivo texto");
            Console.ReadKey();

        }
    }
}
