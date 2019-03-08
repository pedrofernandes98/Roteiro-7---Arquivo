using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5_lista7
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream arq = new FileStream("Cadastro.txt", FileMode.Append);
            //StreamWriter escreve = new StreamWriter(arq);
            string[] mostrar;

            string nome, end, tel, cpf, linha, pesquisa;
            //string[] inf;
            int op;
            //int comp;

            do
            {
                FileStream arq10 = new FileStream("Cadastro.txt", FileMode.Append);
                StreamWriter escreve10 = new StreamWriter(arq10);
                Console.WriteLine("Menu de Opções");
                Console.WriteLine("1- Cadastrar Cliente\n2- Pesquisar Cliente\n3- Sair");
                op = int.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1:
                       
                        Console.WriteLine("Digite o nome do cliente:");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o endereço do cliente:");
                        end = Console.ReadLine();
                        Console.WriteLine("Digite o telefone do cliente:");
                        tel = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente:");
                        cpf = Console.ReadLine();

                        //escreve.WriteLine("Nome: " + nome + " | " + "Endereço: " + end + " | " + "Telefone: " + tel + " | " + "CPF:" + cpf + " | ");
                        escreve10.WriteLine(nome + "," + end + "," + tel + "," + cpf + ",");
                        escreve10.Close();
                        break;
                    case 2:
                        escreve10.Close();
                        FileStream arq2 = new FileStream("Cadastro.txt", FileMode.Open);
                        StreamReader ler = new StreamReader(arq2);

                        Console.WriteLine("Digite o nome do cliente que deseja-se pesquisar:");
                        pesquisa = Console.ReadLine();
                        
                        do
                        {
                            linha = ler.ReadLine();
                            mostrar = linha.Split(',');
                            if (linha == mostrar[0])
                            {
                                mostrar = linha.Split(',');
                                Console.WriteLine(mostrar[0]);
                                Console.WriteLine(mostrar[1]);
                                Console.WriteLine(mostrar[2]);
                                Console.WriteLine(mostrar[3]);
                            }
                        } while (linha != null);



                        break;
                    case 3:
                        Console.WriteLine("Programa encerrado");
                    break;
                    default:
                        Console.WriteLine("Opção inválida");
                    break;





                }
                
            } while (op != 3);

            //escreve.Close();

            Console.ReadKey();


        }
    }
}
