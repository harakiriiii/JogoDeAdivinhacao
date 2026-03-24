// (usingsystem: biblioteca padrão)
// (using.System.Cryptograph: biblioteca padrão do sistema relacionada a criptografia)

using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;

// O comando RandomNumberGenerator pega um número aleatório do tipo inteiro (GetInt32) dentre 1 e 21 e joga esse valor na váriavel número aleatorio.

int numeroaleatorio = RandomNumberGenerator.GetInt32(1, 21);

bool deveContinuar = true;
while (deveContinuar == true)
{
    Console.Clear();

    Console.WriteLine("----------------------------");
    Console.WriteLine("JogoDeAdivinhação");
    Console.WriteLine("----------------------------");

    Console.Write("Digite um numero entre 1 e 20: ");
    string? chute = Console.ReadLine();

    int numerodigitado = Convert.ToInt32(chute);

    if (numerodigitado == numeroaleatorio)
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Parabéns, você acertou!");
        Console.WriteLine("----------------------------");
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

    Console.Write("Deseja continuar? (s/n: ");
    string? opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar != "s")
    {
        deveContinuar = false;
    }

    Console.ReadLine();
}


