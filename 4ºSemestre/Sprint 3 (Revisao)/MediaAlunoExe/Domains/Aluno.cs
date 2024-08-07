using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaAlunoExe
{
    public enum StatusAluno
    {
        Aprovado,
        Reprovado,
        Recuperacao,
        EmAnalise
    }
    public class Aluno()
    {
        public Guid IdAluno { get; set; } = Guid.NewGuid();
        public List<float> Notas { get; set; } = [];

        public StatusAluno StatusAluno { get; private set; } = StatusAluno.EmAnalise;



        public void Aprovar()
        {
            StatusAluno = StatusAluno.Aprovado;
        }
        public void Reprovar()
        {
            StatusAluno = StatusAluno.Reprovado;
        }
        public void Recuperacao()
        {
            StatusAluno = StatusAluno.Recuperacao;
        }

    }
}