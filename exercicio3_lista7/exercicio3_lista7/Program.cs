using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3_lista7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FileStream arq = new FileStream("exercicio3.txt", FileMode.Create);
            StreamWriter escreve = new StreamWriter(arq);
            string linha;
            int aux = 1;

            do
            {
                Console.WriteLine("Digite um texto para ser escrito no arquivo: (Aperte ENTER caso não deseje escrever)");
                linha = Console.ReadLine();
                if (linha != null)
                {
                    escreve.WriteLine(linha);
                }
                
                

            } while (linha != null);


            escreve.Close();*/
            string linha;
            int cont = 0;
            FileStream arq2 = new FileStream("exercicio3.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq2);

            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    Console.WriteLine(linha);
                    ++cont;
                }
            } while (linha != null);

            Console.WriteLine("O arquivo possui " + cont + " linhas");


            Console.ReadKey();




        }
    }
}
