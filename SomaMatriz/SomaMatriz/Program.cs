int[,] matriz = new int[3,3];
int soma = 0;
Console.WriteLine("Com o conjunto (0,1,2) na origem e no destino digite " +
                  "os valores para os campos e será realizada a soma da diagonal principal");
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write($"Digite uma valor para a posição {i},{j}: ");
        matriz[i,j] = int.Parse(Console.ReadLine());
    }
    
}

for (int i = 0; i < matriz.GetLength(0); i++)
{
      soma += matriz[i, i];
   
}

Console.WriteLine($"Total da soma da diagona principal: {soma}");
    
    