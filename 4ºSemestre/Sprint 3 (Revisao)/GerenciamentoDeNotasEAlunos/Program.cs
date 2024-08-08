using GerenciamentoDeNotasEAlunos;

double CalcularMedia(List<double> notas)
{
    double total = 0;
    ;

    foreach (double nota in notas)
    {
        total += nota;
    }

    return Math.Round(total /= notas.Count, 2);
}

Aluno aluno1 = new() { Notas = { 8, 2, 9 } };

double mediaAluno1 = CalcularMedia(aluno1.Notas);

switch (mediaAluno1)
{
    case > 7:

        aluno1.Aprovar();
        break;

    default:
        aluno1.Reprovar();
        break;
}

Console.WriteLine($"Média do aluno: {mediaAluno1}. Status: {aluno1.StatusAluno}");
