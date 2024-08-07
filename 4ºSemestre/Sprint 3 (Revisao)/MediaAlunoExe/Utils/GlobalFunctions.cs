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
    }
}