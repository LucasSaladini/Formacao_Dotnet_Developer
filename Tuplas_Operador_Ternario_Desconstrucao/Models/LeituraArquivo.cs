using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas_Operador_Ternario_Desconstrucao.Models
{
    public class LeituraArquivo
    {
        public (bool Success, string[] Lines, int LinesQuantity) LerArquivo(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                return (true, lines, lines.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}