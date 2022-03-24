List<double> dezAnos = new List<double>();
List<double> vinteAnos = new List<double>();
List<double> trintaAnos = new List<double>();
List<double> trintaMaisAnos = new List<double>();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o seu peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());
    if(idade >= 1 && idade <= 10)
    {
        dezAnos.Add(peso);
    }
    else if(idade >= 11 && idade <= 20)
    {
        vinteAnos.Add(peso);
    }
    else if (idade >= 21 && idade <= 30)
    {
        trintaAnos.Add(peso);
    }
    else if(idade > 31)
    {
        trintaMaisAnos.Add(peso);
    }
}
double resultadoDez = dezAnos.Sum();
resultadoDez = resultadoDez/dezAnos.Count();
double resultadoVinte = vinteAnos.Sum();
resultadoVinte = resultadoVinte /vinteAnos.Count();
double resultadoTrinta = trintaAnos.Sum();
resultadoTrinta = resultadoTrinta /trintaAnos.Count();
double resultadoTrintaMais = trintaMaisAnos.Sum();
resultadoTrintaMais = resultadoTrintaMais /trintaMaisAnos.Count();
Console.WriteLine($"Média peso 1 a 10: {resultadoDez}");
Console.WriteLine($"Média peso 11 a 20: {resultadoVinte}");
Console.WriteLine($"Média peso 21 a 30: {resultadoTrinta}");
Console.WriteLine($"Média peso maiores de 31 anos: {resultadoTrintaMais}");