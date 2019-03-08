using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7_lista7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream arq = new FileStream("temperatura.txt", FileMode.Create);
            StreamWriter escrever = new StreamWriter(arq);
            double soma=0, media, maior=0, menor=0;
            int cont_a = 0, cont_b = 0;


            double temperatura;

            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine("Digite a temperatura em °C: ");
                temperatura = double.Parse(Console.ReadLine());

                escrever.WriteLine(temperatura);

            }

            escrever.Close();

            FileStream arq2 = new FileStream("temperatura.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq2);
            double[] vet = new double[7];

            for(int i = 0; i < 7; i++)
            {
                vet[i] = double.Parse(ler.ReadLine());
                soma += vet[i];
            }

            media = soma / 7.0;
            

            for (int i = 0; i < 7; i++)
            {
                
                if(vet[i] > media)
                {
                    ++cont_a;
                }
            }

            for (int i = 0; i < 7; i++)
            {
                
                if (vet[i] < 16.0)
                {
                    ++cont_b;
                }
            }

            for (int i = 0; i < 7; i++)
            {
                //temp_lida = double.Parse(ler.ReadLine());

                if (i == 0)
                {
                    menor = vet[i];
                    maior = vet[i];
                }
                else
                {
                    if(vet[i] > maior)
                    {
                        maior = vet[i];
                    }

                    if (vet[i] < menor)
                    {
                        menor = vet[i];
                    }



                }
            }

            Console.WriteLine("Número de dias que a temperatura esteve acima da média :" + cont_a);
            Console.WriteLine("Número de dias que a temperatura ficou abaixo de 16 graus :" + cont_b);
            Console.WriteLine("Maior Temperatura Armazenada :" + maior);
            Console.WriteLine("Menor Temperatura Armazenada: " + menor);
            //ler.Close();

            
            

            Console.ReadKey();

        }
    }
}
