﻿namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

            void ExibirLogo()
            {
                Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
                    ");
                Console.WriteLine(mensagemDeBoasVindas);
            }

            void ExibirOpcoesDoMenu()
            {
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para registrar uma banda");
                Console.WriteLine("Digite 2 para mostrar todas as bandas");
                Console.WriteLine("Digite 3 para avaliar uma banda");
                Console.WriteLine("Digite 4 para exibir a média de avaliação das bandas");
                Console.WriteLine("Digite -1 para sair");

                Console.Write("\nDigite a sua opção: ");
                string opcaoEscolhida = Console.ReadLine()!;
                int opcaoEscolhidaNumerica = Convert.ToInt32(opcaoEscolhida);

                switch (opcaoEscolhidaNumerica)
                {
                    case 1: RegistrarBandas();
                        break;
                    case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                        break;
                    case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                        break;
                    case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                        break;
                    case -1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                        break;
                    default: Console.WriteLine("Opção inválida");
                        break;
                }
            }

            void RegistrarBandas()
            {
                Console.Clear();
                Console.WriteLine("Registro de bandas");
                Console.Write("Digite o nome da banda que deseja registrar: ");
                string nomeDaBanda = Console.ReadLine()!;
                Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            ExibirOpcoesDoMenu();
        }
    }
}
