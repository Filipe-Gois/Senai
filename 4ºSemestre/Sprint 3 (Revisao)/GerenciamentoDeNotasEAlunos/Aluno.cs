using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeNotasEAlunos
{
    public enum Status
    {
        Aprovado,
        Reprovado,
        EmAnalise
    }

    public class Aluno
    {
        public List<double> Notas { get; private set; } = [];

        public Status StatusAluno { get; private set; } = Status.EmAnalise;

        public void Aprovar()
        {
            StatusAluno = Status.Aprovado;
        }

        public void Reprovar()
        {
            StatusAluno = Status.Reprovado;
        }
    }
}
