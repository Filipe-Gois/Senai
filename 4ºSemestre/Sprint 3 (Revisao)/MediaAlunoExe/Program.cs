using MediaAlunoExe;
using MediaAlunoExe.Utils;

Aluno aluno1 = new() { Notas = [4, 3, 8], };

float CalcularMedia(List<float> notas)
        {
            float media = 0;
            foreach (float nota in notas)
            {
                media += nota;
            }

            return media / notas.Count;
        }

void AlterarStatusAluno(Aluno aluno)
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

AlterarStatusAluno(aluno1);


Console.WriteLine(aluno1.StatusAluno);
