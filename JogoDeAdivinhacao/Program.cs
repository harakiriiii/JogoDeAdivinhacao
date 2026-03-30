// (usingsystem: biblioteca padrão)
// (using.System.Cryptograph: biblioteca padrão do sistema relacionada a criptografia)

using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;

// O comando RandomNumberGenerator pega um número aleatório do tipo inteiro (GetInt32) dentre 1 e 21 e joga esse valor na váriavel número aleatorio.

while (true == true)
{
    //Console.Clear();

    Console.WriteLine("-----------------------------------");
    Console.WriteLine("JogoDeAdivinhação");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Escolha o nível de dificuldade");
    Console.WriteLine("-----------------------------------");

    Console.WriteLine("1 - Fácil (10 tentativas)");
    Console.WriteLine("2 - Médio (5 tentativas)");
    Console.WriteLine("3 - Difícil (3 tentativas)");
    Console.WriteLine("-----------------------------------");

    Console.Write("Digite sua escolha: ");
    string? dificuldade = Console.ReadLine();

    int tentativasmaximas;

    int numeromaximo = 0;

    switch (dificuldade)
    {
        case "1":
            tentativasmaximas = 10; numeromaximo = 20;
            break;

        case "2":
            tentativasmaximas = 5; numeromaximo = 50;
            break;

        case "3":
            tentativasmaximas = 3; numeromaximo = 100;
            break;

        default:

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Por favor, selecione uma dificuldade válida");
            Console.Write("Digite um ENTER para continuar");
            Console.ReadLine();
            continue;
    }




    // if (dificuldade == "1") { tentativas = 10; numeromaximo = 20; }

    // else if (dificuldade == "2") { tentativas = 5; numeromaximo = 50; }

    // else if (dificuldade == "3") {tentativas = 3; numeromaximo = 100; }

    //hardcoded != dinâmico
    int numeroaleatorio = RandomNumberGenerator.GetInt32(1, numeromaximo + 1);

    for (int tentativas = 1; tentativas <= tentativasmaximas; tentativas++)
    {
        Console.Clear();
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Tentativa {tentativas}; {tentativasmaximas}");
        Console.WriteLine("----------------------------");

        Console.Write($"Digite um numero entre 1 e {numeromaximo}: ");
        string? chute = Console.ReadLine();

        int numerodigitado = Convert.ToInt32(chute);

        if (numerodigitado == numeroaleatorio)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Parabéns, você acertou!");
            Console.WriteLine("----------------------------");
            break;
        }
        else if (numerodigitado > numeroaleatorio)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("O número digitado foi maior que o número secreto");
            Console.WriteLine("----------------------------");
        }
        else
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("O número digitado foi menor que o número secreto");
            Console.WriteLine("----------------------------");
        }
        Console.WriteLine("Digite ENTER para continuar");
        Console.ReadLine();

        if (tentativas == tentativasmaximas)
        {
            Console.WriteLine($"Você usou todas as suas tentativas! O número era {numeroaleatorio}");
            Console.WriteLine("--------------------------------");
            break;
        }

    }




    Console.Write("Deseja continuar? (s/n: ");
    string? opcaoContinuar = Console.ReadLine(); //(?) nullable

    if (opcaoContinuar?.ToUpper() != "S")
    {
        break;
    }
}


