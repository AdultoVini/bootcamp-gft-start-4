Console.WriteLine("Digite a quantidade que irá repetir a musica: ");
int vezes = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("1 Elefante incomoda muito gente...");
Console.Write(vezes + " Elefantes");
for (int i = 0; i < vezes; i++)
{
    Console.Write(" Incomodam");
}
Console.Write(" Muito mais");