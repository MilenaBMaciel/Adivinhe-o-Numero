
int InicializaJogo()
{
    Random aleatorio = new Random();
    int numeroSecreto = aleatorio.Next(1, 101);

    Console.WriteLine($"Bem-vindo! Tente adivinhar o número secreto {numeroSecreto}\n");   
    
    return numeroSecreto;
}

void Jogo(int numeroSecreto)
{
    while(true)
    {
        Console.WriteLine("Digite um número entre 1 e 100: ");
        int chute = int.Parse(Console.ReadLine());

        if (chute == numeroSecreto)
        {
            Console.WriteLine("Parabéns! Você acertou o número!\n");
            break;
        }
        else if (chute < numeroSecreto)
        {
            Console.WriteLine($"O número é maior que {chute}\n");
        }
        else
        {
            Console.WriteLine($"O número é menor que {chute}\n");
        }
    }
}

string opcao;
do
{
    Jogo(InicializaJogo());

    Console.WriteLine("Deseja jogar novamente? s ou n");
    opcao = Console.ReadLine();

} while (opcao == "s" || opcao == "S");
Console.WriteLine("\nAté breve!\n");


