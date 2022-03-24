int op = 0;
while(op != 3)
{
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - IMC");
    Console.WriteLine("3 - Sair");
    Console.WriteLine("Digite a opção desejada: ");
    op = Convert.ToInt32(Console.ReadLine());
    if(op == 1)
    {
        double n1, n2, result;
        Console.WriteLine("Digite o primeiro número: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        if (n1 < 0)
        {
            Console.WriteLine("Número negativo não é permitido");
        }
        Console.WriteLine("Digite o segundo número: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        if (n2 < 0)
        {
            Console.WriteLine("Número negativo não é permitido");
        }
        result = n1 + n2;
        Console.WriteLine("O resultado da soma é: "+result);
    }else if(op == 2)
    {
        double peso, altura, imc;

        Console.WriteLine("Digite a sua altura usando a virgula. Ex: 1,69 ");
        altura = Convert.ToDouble(Console.ReadLine());
        if(altura < 0)
        {
            Console.WriteLine("Altura inválida!");
        }
        Console.WriteLine("Digite o seu peso: ");
        peso = Convert.ToDouble(Console.ReadLine());
        if (peso < 0)
        {
            Console.WriteLine("Peso inválida!");
        }
        imc = peso/(altura*altura);
        Console.WriteLine("IMC: "+imc);
        if (imc < 18.5)
        {
            Console.WriteLine("Peso abaixo do normal");
        }else if (imc >18.5 && imc < 25)
        {
            Console.WriteLine("Peso normal");
        }else if (imc > 25 && imc < 30)
        {
            Console.WriteLine("Sobre o peso");
        }else if(imc > 30 && imc < 35)
        {
            Console.WriteLine("Grau de obesidade 1");
        }
        else
        {
            Console.WriteLine("Grau de obesidade 2");
        }

    }
}