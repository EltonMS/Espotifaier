using System;
using System.Collections.Generic;
using System.Threading;

namespace Espotifaier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagemDeBoasVindas = "Bem vindo ao Espotifaier";
            List<string> listaDasBandas = new List<string> { "Harmonia do Samba", "Parangolé", "Raghatonny"};

            void ExibirLogo()
            {
                Console.WriteLine(@"
                   
            ███████╗░██████╗██████╗░░█████╗░████████╗██╗███████╗░█████╗░██╗███████╗██████╗░
            ██╔════╝██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝██╔══██╗██║██╔════╝██╔══██╗
            █████╗░░╚█████╗░██████╔╝██║░░██║░░░██║░░░██║█████╗░░███████║██║█████╗░░██████╔╝
            ██╔══╝░░░╚═══██╗██╔═══╝░██║░░██║░░░██║░░░██║██╔══╝░░██╔══██║██║██╔══╝░░██╔══██╗
            ███████╗██████╔╝██║░░░░░╚█████╔╝░░░██║░░░██║██║░░░░░██║░░██║██║███████╗██║░░██║
            ╚══════╝╚═════╝░╚═╝░░░░░░╚════╝░░░░╚═╝░░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚═╝╚══════╝╚═╝░░╚═╝     
            ");
                Console.WriteLine(mensagemDeBoasVindas);
            }


            void ExibirOpcoesDoMenu() 
            {
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para registrar uma banda");
                Console.WriteLine("Digite 2 para mostrar todas as bandas");
                Console.WriteLine("Digite 3 para avaliar uma banda");
                Console.WriteLine("Digite 4 para exibir a média de uma banda");
                Console.WriteLine("Digite -1 para sair");

                Console.Write("\nDigite a sua opção: ");
                string opcaoEscolhida = Console.ReadLine()!;
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                switch (opcaoEscolhidaNumerica) 
                {
                    case 1: RegistrarBanda();
                        break;
                    case 2: ExibirBandas();
                        break;
                    case 3:Console.WriteLine("Opção 3");
                        break;
                    case 4: Console.WriteLine("Opção 4");
                        break;
                    case -1:Console.WriteLine("Tchau :)");
                        break;
                    default : Console.WriteLine("Opção Inválida");
                        break;
                }


            }

            void RegistrarBanda() 
            {
                Console.Clear();
                Console.WriteLine("**********************\n");
                Console.WriteLine("Registro de bandas:\n ");
                Console.WriteLine("**********************\n");
                Console.Write("Digite o nome da banda: ");
                string nomeDaBanda = Console.ReadLine()!;
                listaDasBandas.Add(nomeDaBanda);
                Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            void ExibirBandas() 
            {
                Console.Clear();
                Console.WriteLine("**********************************\n");
                Console.WriteLine(" Bandas cadastradas no Espotifaier\n ");
                Console.WriteLine("**********************************\n");
                //for (int i = 0; i < listaDasBandas.Count; i++) 
                //{
                //Console.WriteLine($"\nBanda: {listaDasBandas[i]}");

                //}
                foreach (string banda in listaDasBandas) 
                {
                    Console.WriteLine($"\nBanda: {banda}");
                }
                Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal: ");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            void ExibirTituloDaOpcao(string titulo)
            {
                int quantidadeDeLetras = titulo.Length;
                string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, asteriscos);
            }
            ExibirOpcoesDoMenu();
        }
    }
}
