Console.WriteLine("===================");
Console.WriteLine("EXERCICIO 1");
Console.WriteLine("===================");
int [] nota = new int[10];

for (int i = 0; i < nota.Length; i++)
{
    Console.WriteLine($"Digite a nota {i + 1}:");
    nota[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("===================");
Console.WriteLine("EXERCICIO 2");
Console.WriteLine("===================");
int soma = 0;
for (int i = 0; i < nota.Length; i++) ;
{
    int i = 0;
    soma += nota[i];
    Console.WriteLine($"A media das notas é: {soma}");

}
Console.WriteLine("===================");
Console.WriteLine("EXERCICIO 3");
Console.WriteLine("===================");
for (int i = 0; i < nota.Length; i++)
{
    if (nota[i] >= 7)
    {
        Console.WriteLine($"A nota {i + 1} é maior ou igual a 7: {nota[i]}");
    }
    //terminar o exercicio 3
}


Console.WriteLine("===================");
Console.WriteLine("EXERCICIO 8");
Console.WriteLine("===================");
int[] vetor = new int[6];
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Digite o valor {i + 1}:");
    vetor[i] = int.Parse(Console.ReadLine());
}
//terinar o exercicio 8


Console.WriteLine("===================");
Console.WriteLine("EXERCICIO 10");
Console.WriteLine("===================");



Console.WriteLine("===================");
Console.WriteLine("EXERCICIO 16");
Console.WriteLine("===================");
double[] temperaturas = new double[7];
for (int i = 0; i < temperaturas.Length; i++)
{
    Console.WriteLine($"Digite a temperatura do dia:");
    temperaturas[i] = double.Parse(Console.ReadLine());
}

double maiorTemperatura = temperaturas[0];
for (int i=1; i< temperaturas.Length; i++)
{
    if (temperaturas[i] > maiorTemperatura)
    {
        maiorTemperatura = temperaturas[i];
    }
}
Console.WriteLine($"A maior temperatura da semana é: {maiorTemperatura}");