using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_lista7
{
    class Program
    {
        static void Main(string[] args)
        {
            //O código a seguir tem como função, criar um documento de texto, escrever 5 nomes e endereços neste documento, armazenando esses dados no mesmo e por fim o programa recupera e lê todos esses dados do documento de texto e imprime na tela para o usuário, tudo isso é minunciosamente explicado em cada linha do código abaixo:
            FileStream arq = new FileStream("teste.txt", FileMode.Create);//Nesta linha usa-se uma instância de FileStream que é uma subclasse da classe principal Stream. Esta classe, auxilia na criação, leitura, escrita e fechamento de arquivos. Neste caso, foi utilizado uma instância de nome 'arq' que irá indicar qual é o arquivo, que no caso será criado com o nome 'teste.txt'
            StreamWriter escreve = new StreamWriter(arq);//Nova instância de nome 'escrever', atribuída por meio da subclasse 'StreamWriter' que permitirá ao programa escrever no arquivo instânciado pelo nome 'arq'.
            string nome, linha, endereco;//cria-se 3 variáveis do tipo string que serão utilizadas na execução do algoritmo
            for (int i = 0; i < 5; i++)//estrutura de repetição que irá repetir do 0 ao 4. Mais especificamente para esse programa, tal estrutura está sendo utilizada para solicitar ao usuário 5 nomes e endereços e armazenálos no arquivo de texto instanciado nas linhas acima.
            {
                Console.Write("Digite seu nome:");//Comando de saída que solicita ao usuário o nome
                nome = Console.ReadLine();//Comando de entrada que lê o nome digitado pelo usuário e armazena na variável 'nome'
                Console.Write("Digite seu endereço:");//Comando de saída que solicita ao usuário o endereço
                endereco = Console.ReadLine();//Comando de entrada que lê o que o usuário digita e armazena na variável 'endereco'
                escreve.WriteLine("Nome: " + nome + " , " + "Endereço: " + endereco + " , ");//Comando que permite ao programa escrever diretamente no documento de texto criado e instânciado nas linhas acima
            }

            escreve.Close();//Comando que fecha o documento de texto inicialmente criado e aberto, para tal utiliza-se o método close()
            FileStream arq1 = new FileStream("teste.txt", FileMode.Open);//Novo comando FileStream como o FileMode Open, que permite abrir o arquivo 'teste.txt' já previamente criado
            StreamReader ler = new StreamReader(arq1);//Comando que cria a instância 'ler' que permite ler as strings que estão no arquivo
            string[] resultado;//Criação de um array com nome 'resultado' do tipo string
            do//Inicío da estrutura de repetição do-while
            {
                linha = ler.ReadLine();//COmando que lê uma linha do arquivo referenciado e armazena na variável linha
                if (linha != null)//estrutura condicional que analisa se a variável linha está vazia(O que indica que encerrou-se os textos do do arquivo), caso o variável na seja nula os comando em meio ao if será executados, caso contrário os comandos não serão executados e o programa irá prosseguir logo após o fim do if
                {
                    resultado = linha.Split(',');//Comando que quebra toda a string linha por meio do caractere de separação que no caso é o ',' e armazena cada parte da string seja armazenada em uma posição do array, de forma que o cada posição recebe é dividido pelo caractere ','
                    Console.WriteLine(resultado[0]);//Comando que imprime o valor do array resultado[0] na tela, no caso será mostrado o nome que estava armazenado no arquivo
                    Console.WriteLine(resultado[1]);//Comando que imprime na tela o valor do array resultado[1], no qual estará armazenado o valor do endereço armazenado no arquivo
                }
            } while (linha != null);//Final da estrutura de repetição do-while que repete enquanto a variável linha não for nula
            Console.ReadKey();//Comando que "congela" a tela permitindo a leitura do que foi impresso na tela pelo programa para o usuário
        }
    }
}
