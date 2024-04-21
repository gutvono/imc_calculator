float height = 0, weight = 0, imc = 0;
int sex = 0, restart = 0;

do
{
    Console.Clear();

    do
    {
        Console.WriteLine("ESTE SOFTWARE IRÁ CALCULAR SEU IMC");
        Console.WriteLine("Qual seu sexo?");
        Console.WriteLine("1 - MASULINO");
        Console.WriteLine("2 - FEMININO");
        sex = int.Parse(Console.ReadLine());
        if (sex < 1 || sex > 2)
        {
            Console.WriteLine("Favor digitar o número correto para informar o sexo.");
        }
        Console.WriteLine();
    } while (sex < 1 || sex > 2);

    Console.Write("Informe sua altura:");
    height = float.Parse(Console.ReadLine());
    if (height > 10)
    {
        height = height / 100;
    }

    Console.WriteLine("Informe seu peso:");
    weight = float.Parse(Console.ReadLine());

    imc = weight / (height * height);

    if (sex == 1)
    {
        if (imc < 20)
        {
            Console.WriteLine($"Seu IMC é {imc} e está ABAIXO DO NORMAL.");
        }
        else if (imc >= 20 && imc <= 24.9)
        {
            Console.WriteLine($"Seu IMC é {imc} e está NORMAL.");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine($"Seu IMC é {imc} e está com OBESIDADE LEVE.");
        }
        else if (imc >= 30 && imc <= 39.9)
        {
            Console.WriteLine($"Seu IMC é {imc} e está com OBESIDADE MODERADA.");
        }
        else
        {
            Console.WriteLine($"Seu IMC é {imc} e está com OBESIDADE MÓRBIDA.");
        }
    }
    else
    {
        if (imc < 19)
        {
            Console.WriteLine($"Seu IMC é {imc} e está ABAIXO DO NORMAL.");
        }
        else if (imc >= 19 && imc <= 23.9)
        {
            Console.WriteLine($"Seu IMC é {imc} e está NORMAL.");
        }
        else if (imc >= 24 && imc <= 28.9)
        {
            Console.WriteLine($"Seu IMC é {imc} e está com OBESIDADE LEVE.");
        }
        else if (imc >= 29 && imc <= 38.9)
        {
            Console.WriteLine($"Seu IMC é {imc} e está com OBESIDADE MODERADA.");
        }
        else
        {
            Console.WriteLine($"Seu IMC é {imc} e está com OBESIDADE MÓRBIDA.");
        }
    }

    Console.WriteLine("Gostaria de calcular seu IMC novamente?");
    Console.WriteLine("1 - SIM");
    Console.WriteLine("2 - NÃO");
    restart = int.Parse(Console.ReadLine());
} while (restart == 1);