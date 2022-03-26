using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
Olá, bem vindo ao programa Elevador!

Para começar, preciso de algumas informações, vamos lá? (S/N)
");
            string inicio = Console.ReadLine().ToUpper();
            bool sair = false;
            int andares, capacidade = 0;
            Elevador elevador = new Elevador();

            switch (inicio)
            {
                case "S":
                    sair = false;
                    Console.Clear();
                    Console.WriteLine("Informe a quantidade total de andares do prédio: ");
                    try
                    {
                        andares = int.Parse(Console.ReadLine()); // Leitura da quantidade de andares, parametrização inicial do sistema.
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor incorreto ou incompatível. Inicie o programa novamente.");
                        sair = true;
                        break;
                    }

                    Console.WriteLine("Informe a capacidade de pessoas dentro do elevador: ");
                    try
                    {
                        capacidade = int.Parse(Console.ReadLine()); // Leitura da capacidade de pessoas dentro do elevador, parametrização inicial do sistema.
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor incorreto ou incompatível. Inicie o programa novamente.");
                        sair = true;
                        break;
                    }

                    if (!elevador.inicializar(andares, capacidade)) // Inicialização do sistema, se falhar não avança com o programa.
                    {
                        sair = true;
                        break;
                    }
                    break;

                default:
                    Console.WriteLine("Que pena... Volte outra hora.");
                    sair = true;
                    break;
            }

            int opcao = 0;
            while (!sair)
            {
                Console.Clear();

                // Estado atual do elevador
                if (elevador.getAndarAtual() == 0)
                {
                    Console.WriteLine($"Andar Atual...............: Térreo\nPessoas Dentro do Elevador: {elevador.getCapacidadeAtual()}\n");
                }
                else
                {
                    Console.WriteLine($"Andar Atual...............: {elevador.getAndarAtual()}º Pavimento\nPessoas Dentro do Elevador: {elevador.getCapacidadeAtual()}\n");
                }

                // Menu principal de opções
                Console.WriteLine(@"
1 - Subir 1 Andar
2 - Descer 1 Andar
3 - Adicionar 1 Pessoa
4 - Retirar 1 Pessoa
0 - Sair

Informe a opção desejada (Enter repete a última ação):
");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception ex) { }

                switch (opcao)
                {
                    case 1: // sobe 1 andar
                        elevador.subir();
                        break;
                    case 2: // desce 1 andar
                        elevador.descer();
                        break;
                    case 3: // adiciona 1 pessoa dentro do elevador
                        elevador.entrar();
                        break;
                    case 4: // retira 1 pessoa de dentro do elevador
                        elevador.sair();
                        break;
                    case 0: // encerra o programa
                        sair = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
