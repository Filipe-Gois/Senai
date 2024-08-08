using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaAlunoExe.Utils
{
    public static class GlobalFunctions
    {
        public static float CalcularMedia(List<float> notas)
        {
            float media = 0;
            foreach (float nota in notas)
            {
                media += nota;
            }

            return media / notas.Count;
        }

        public static void AlterarStatusAluno(Aluno aluno)
        {
            float alunoMedia = CalcularMedia(aluno.Notas);
            switch (alunoMedia)
            {
                case >= 6:
                    aluno.Aprovar();
                break;
                case >= 4:
                    aluno.Recuperacao();
                break;
                
                default:
                    aluno.Reprovar();
                break;
            }
        }
    }
}