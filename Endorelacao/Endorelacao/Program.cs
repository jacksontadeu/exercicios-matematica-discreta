
using System.Threading.Channels;

//Declaração das variáveis
int[,] matriz = new int[3,3];
int simetrica = 0;
char opcao ='s';
int destino = 0;
int origem = 0;

Console.WriteLine("Seja A = {0,1,2} o conjunto digite abaixo as relações");
//Dar entrada nas endorelações de origem e destino
while (opcao.Equals('s'))
{
    Console.Write("Digite a origem: ");
    origem = int.Parse(Console.ReadLine());
    Console.Write("Digite o destino: ");
    destino = int.Parse(Console.ReadLine());
    Console.Write("Deseja continuar (s/n)");
    opcao = char.Parse(Console.ReadLine());

//Adiciona valor lógico verdadeiro na relaçõa acima definida
    for (int i = 0; i < matriz.Length; i++)
    {
        for (int j = 0; j < matriz.Length; j++)
        {
            matriz[origem, destino] = 1;
        }
    }
}
// Imprime a matriz para verificação
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i,j] + "  ");
    }
    Console.WriteLine();
}
//Realiza a verificação dos campos para definir se é Simétrica
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        if (matriz[i, j] == 1 && matriz[j, i] == 1)
            simetrica++;
        else if (matriz[i, j] == 0 || matriz[j, i] == 0)
            simetrica--;
    }
}
//Faz a verificação da variável se é simétrica
if (simetrica > 0)
    Console.WriteLine("Essa matriz é SIMETRICA");
    