//Algoritmo para fazer a interseção de dois conjuntos
HashSet<int> A = new HashSet<int>(); // Criando os conjuntos
HashSet<int> B = new HashSet<int>();
string resp;
//Pedindo os elementos para adiconar ao conjunto A
Console.WriteLine("Criando o primeiro conjunto");
do
{
    
    Console.Write("Digite um numero: ");
    int num = int.Parse(Console.ReadLine());
    A.Add(num);
    Console.Write("Deseja adicionar mais(s/n): ");
    resp = Console.ReadLine();
    
  
}while (resp != "n") ;
//Pedindo os elementos para adiconar ao conjunto B
Console.WriteLine("Criando o segundo conjunto");
do
{
    
    Console.Write("Digite um numero: ");
    int num = int.Parse(Console.ReadLine());
    B.Add(num);
    Console.Write("Deseja adicionar mais(s/n): ");
    resp = Console.ReadLine();
    
  
}while (resp != "n") ;
// Realizando a interseção entre os dois conjuntos
A.IntersectWith(B);

//Imprimindo resultado da interseção
Console.WriteLine("Interseção dos conjuntos");
Console.Write("Conjunto após a interseção: ");
foreach (var numero in A)
{
    Console.Write(numero + " ");
}

Console.ReadKey();
