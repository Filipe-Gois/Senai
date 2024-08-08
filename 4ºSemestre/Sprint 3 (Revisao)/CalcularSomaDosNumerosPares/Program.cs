int numeroFinal = 100;
int numeroAtual = 0;

int total = 0;

while (numeroAtual <= numeroFinal)
{
    if (numeroAtual % 2 == 0)
    {
        total += numeroAtual;
    }

    numeroAtual++;
}

Console.WriteLine($"Soma total: {total}");
