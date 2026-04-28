using System.Xml;

int[] nota = new int[5];
/*nota[0] = 10;
 nota[1] = 7;
 nota[2] = 8;
 nota[3] = 6;
 nota[4] = 4;
 nota[5] = 3;
 nota[6] = 4;*/

/*Gera uma coleção de inteiros aleatorios*/
Random rnd = new Random();
for (int i = 0; i < nota.Length; i++)
{
    int num = rnd.Next(0, 11); //Soretei um numero inteiro de 0 a 10
    nota[i] = num;
}
for (int i = 0; i < nota.Length; i++)
{
    Console.WriteLine("Indice " + 1 + ":"+nota[i]);
}
//Soma as notas e calcula a media 
int soma = 0;
for (int i = 0; i < nota.Length; i++)
{
    soma = soma + nota[i];
}

double media=soma/nota.Length;
Console.WriteLine("Nota media da prova: "+media);

//Para Maior Nota
int MaiorNota = nota [0]; // Começamos colocando a primeira nota como a maior

for (int i = 0;i < nota.Length; i++)
{
    // Se a nota atual for MAIOR que a que temos guardada
    if (nota[i] > MaiorNota)
    {
        //atualizamos a variável com a nova nota maior
        MaiorNota = nota[i];
    }
}

Console.WriteLine("A maior nota é: " + MaiorNota);
