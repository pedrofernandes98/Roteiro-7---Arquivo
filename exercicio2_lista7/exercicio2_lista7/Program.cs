using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_lista7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream arq = new FileStream("teste2.txt", FileMode.Create);//Utilização da instância da classe FileStream para que seja criado um arquivo de nome "teste.txt"
            StreamWriter escreve = new StreamWriter(arq);//Nova instância de nome 'escreve', atribuída por meio da subclasse 'StreamWriter' que permitirá ao programa escrever no arquivo instânciado pelo nome 'arq'.
            string frase, tudo;//Declaração das variáveis 'frase' e 'tudo' do tipo string
            int i = 0, contA = 0, contO = 0;//Declaração de variáveis do tipo int 'i', 'contA', 'contO'
            Console.Write("Digite uma frase:");//Comando de saída que solicita ao usuário para digitar uma frase
            frase = Console.ReadLine();//Comando de entrada que lê o que foi digitado pelo usuário e armazena na variável 'frase'
            escreve.WriteLine(frase);//Comando que se utiliza da instância 'escreve' para escrever no arquivo texto instância por arq o que foi digitado pelo usuário
            escreve.Close();//Comando que fecha o arquivo texto a fim de armazenar todas as informações que foram escritas nel
            FileStream arq1 = new FileStream("teste2.txt", FileMode.Open);//Nova instância da classe File Stream, agora com nome 'arq1' e que tem como objetivo abrir o arquivo texto.
            StreamReader ler = new StreamReader(arq1);//Outra instância da subclasse StreamReader utilizada para ler os dados do arquivo texto instânciado por 'arq1'
            tudo = ler.ReadToEnd();//Comando que lê todo o conteúdo do arquivo texto e armazeva na variável 'tudo'
            Console.WriteLine("Tudo que foi escrito no arquivo: " + tudo);//Comando de saída que mostra todo o texto que foi lido no arquivo
            for (i = 0; i < tudo.Length; i++)//Estrutura de repetição que irá variar o número total de caracteres existentes no arquivo texto lido, tal fato é possível por meio do comando 'Lenght' presente
            {
                if (tudo[i] == 'a')//Estrutura condicional que verifica se o caractere lido no arquivo texto é a letra 'a', caso seja verdadeira a condição o programa irá executar o incremento, caso seja falsa ele irá seguir logo depois do fechamento de chaves
                {
                    contA++;//Incremento de contA
                }
                if (tudo[i] == 'o')//Estrutura condicional que verifica se o caractere lido no arquivo texto é a letra 'o', caso seja verdadeira a condição o programa irá executar o incremento, caso seja falsa ele irá seguir logo depois do fechamento de chaves
                {
                    contO++;//Incremento de contO
                }
            }
            Console.WriteLine("A quantidade de letra a é:" + contA);//COmando de saída que irá mostrar a quantidade todal de letra 'a' do arquivo texto
            Console.WriteLine("A quantidade de letra o é:" + contO);//COmando de saída que irá mostrar a quantidade todal de letra 'o' do arquivo texto
            Console.ReadKey();//Comando que congela a tela para vizualização dos dados
        }
    }
}
