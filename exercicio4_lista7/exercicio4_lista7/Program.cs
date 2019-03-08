using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4_lista7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream arq = new FileStream("exercicio4.txt", FileMode.Create);
            StreamWriter escreve = new StreamWriter(arq);
            char letra;
            string linha;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite uma letra para ser escrita no arquivo:");
                letra = char.Parse(Console.ReadLine());

                escreve.WriteLine(letra);
            }

            escreve.Close();
            
            FileStream arq1 = new FileStream("exercicio4.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq1);
            string tudo;
            int contA=0, contE=0,contI=0, contO=0, contU=0;
            tudo = ler.ReadToEnd();
            

            
            for(int i = 0; i < tudo.Length; i++)
            {
                if (tudo[i] == 'a' || tudo[i] == 'A')
                {
                    ++contA;
                }

                if (tudo[i] == 'e' || tudo[i] == 'E')
                {
                    ++contE;
                }

                if (tudo[i] == 'i' || tudo[i] == 'I')
                {
                    ++contI;
                }

                if (tudo[i] == 'o' || tudo[i] == 'O')
                {
                    ++contO;
                }

                if (tudo[i] == 'u' || tudo[i] == 'U')
                {
                    ++contU;
                }




            }
            Console.WriteLine("Quantidade de letras 'a' no arquivo é: " + contA);
            Console.WriteLine("Quantidade de letras 'e' no arquivo é: " + contE);
            Console.WriteLine("Quantidade de letras 'i' no arquivo é: " + contI);
            Console.WriteLine("Quantidade de letras 'o' no arquivo é: " + contO);
            Console.WriteLine("Quantidade de letras 'u' no arquivo é: " + contU);

            Console.ReadKey();

        }
    }
}
