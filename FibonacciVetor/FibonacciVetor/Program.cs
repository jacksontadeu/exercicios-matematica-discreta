int i = 0;
Console.Write("Digite a quantidade de teste: ");
int T = int.Parse(Console.ReadLine());

long[] vetor = new long[61];
vetor[0] = 0;
vetor[1] = 1;
for (i = 2; i < 61; i++)
{
    vetor[i] = vetor[i - 1] + vetor[i - 2];
}

for (i = 0; i < T; i++)
{
    Console.Write("Digite a posição: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine($"Fib({x}) = {vetor[x]}");
}

