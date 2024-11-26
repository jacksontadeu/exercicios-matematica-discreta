using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    internal class Program
    {
        static string jogador1;
        static string jogador2;
        static string opcao;
        static char jog1 = 'X';
        static char jog2 = 'O';
        static int jogada = 0;
        static int i = 0;
        static int vitoriaJogador2 = 0;
        static int vitoriaJogador1 = 0;
        static int empates = 0;
        static int partidas = 0;
        static char[] campo = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };


        static int VerificarGanhador(char[] campo)
        {

            if (campo[0] == campo[1] && campo[1] == campo[2])
            {
                return 1;
            }
            else if (campo[3] == campo[4] && campo[4] == campo[5])
            {
                return 1;
            }
            else if (campo[6] == campo[7] && campo[7] == campo[8])
            {
                return 1;
            }
            else if (campo[0] == campo[3] && campo[3] == campo[6])
            {
                return 1;
            }
            else if (campo[1] == campo[4] && campo[4] == campo[7])
            {
                return 1;
            }
            else if (campo[2] == campo[5] && campo[5] == campo[8])
            {
                return 1;
            }
            else if (campo[0] == campo[4] && campo[4] == campo[8])
            {
                return 1;
            }
            else if (campo[2] == campo[4] && campo[4] == campo[6])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void CadastrarJogador()
        {
            Console.WriteLine("===== JOGO DA VELHA =====");
            Console.Write("Nome do Jogador 1: ");
            jogador1 = Console.ReadLine().ToUpper();

            Console.Write("Nome do Jogador 2: ");
            jogador2 = Console.ReadLine().ToUpper();
        }

        static void Main(string[] args)
        {
            CadastrarJogador();
            while(opcao != "N")
            {
                IniciarJogo();
                RealizarJogadas();                
                Console.Write("Deseja jogar outra partida (S / N): ");
                opcao = Console.ReadLine().ToUpper();
                
            }
            VerEstatistica();
        }
        static void RealizarJogadas()
        {
            for ( i = 0; i < campo.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"Digite a jogada {jogador1}: ");
                    jogada = int.Parse(Console.ReadLine());
                    VerificarJogada();                                        
                    VerTabuleiro(campo);
                    int vencedor = VerificarGanhador(campo);
                    if (vencedor == 1 && i % 2 == 0)
                    {
                        Console.WriteLine($"{jogador1} ganhou!!!");
                        vitoriaJogador1++;
                        break;
                    }
                    
                    else if (vencedor == 0 && i == 8)
                    {
                        Console.WriteLine("Deu empate!!!");
                        empates++;
                        break;
                    }
                }
                else
                {
                    Console.Write($"Digite a jogada {jogador2}: ");
                    jogada = int.Parse(Console.ReadLine());
                    VerificarJogada();                    
                    VerTabuleiro(campo);
                    int vencedor = VerificarGanhador(campo);
                    if (vencedor == 1 && i % 2 == 1)
                    {
                        Console.WriteLine($"{jogador2} ganhou!!!");
                        vitoriaJogador2 +=1;
                        break;
                    }
                    
                    else if (vencedor == 0 && i == 8)
                    {
                        Console.WriteLine("Deu empate!!!");
                        empates++;
                        break;
                    }
                }
                
            }
            Console.ReadKey();
        }

        static void VerTabuleiro(char[] campo)
        {
            Console.Clear();
            Console.WriteLine("===== JOGO DA VELHA =====");
            Console.WriteLine($"{jogador1} joga com {jog1}");
            Console.WriteLine($"{jogador2} joga com {jog2}");
            Console.WriteLine($"Partida {partidas}");
            Console.WriteLine("     |     |            ");
            Console.WriteLine($"  {campo[0]}  |  {campo[1]}  |  {campo[2]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |            ");
            Console.WriteLine($"  {campo[3]}  |  {campo[4]}  |  {campo[5]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |            ");
            Console.WriteLine($"  {campo[6]}  |  {campo[7]}  |  {campo[8]}  ");
            Console.WriteLine("     |     |            ");
        }
        static void VerificarJogada()
        {
            while (true)
            {
                if (campo[jogada - 1] == 'X' || campo[jogada - 1] == 'O')
                {
                    Console.WriteLine("Jogada inválida, tente novamente!!!");
                    Console.Write($"Digite a jogada {jogador1}: ");
                    jogada = int.Parse(Console.ReadLine());
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        campo[jogada - 1] = jog1;
                        break;
                    }
                    else
                    {
                        campo[jogada - 1] = jog2;
                        break;
                    }

                }
               
            }
        }
        static void IniciarJogo()
        {
            Console.Clear();
            campo = new []{ '1', '2', '3', '4', '5', '6', '7', '8', '9' } ;
            Console.WriteLine("===== JOGO DA VELHA =====");
            Console.WriteLine();
            partidas++;
            Console.WriteLine($"{jogador1} joga com {jog1}");
            Console.WriteLine($"{jogador2} joga com {jog2}");
            Console.WriteLine($"Partida {partidas}");
            Console.WriteLine();
            Console.WriteLine("     |     |            ");
            Console.WriteLine($"  {campo[0]}  |  {campo[1]}  |  {campo[2]}  ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine("     |     |            ");
            Console.WriteLine($"  {campo[3]}  |  {campo[4]}  |  {campo[5]}  ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine("     |     |            ");
            Console.WriteLine($"  {campo[6]}  |  {campo[7]}  |  {campo[8]}  ");
            Console.WriteLine("     |     |            ");
        }
        
        static void VerEstatistica()
        {
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine($"Total de partida(s): {partidas}");
            Console.WriteLine($"Vitória(s) de {jogador1}: {vitoriaJogador1}");
            Console.WriteLine($"Vitória(s) de {jogador2}: {vitoriaJogador2}");
            Console.WriteLine($"Total de empate(s): {empates}");
            Console.WriteLine("======================================");
            Console.ReadKey();
        }
        





    }
}


