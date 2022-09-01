using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoDatasHumanizer
{
    class CalculoDaDiferençaData
    {
        public CalculoDaDiferençaData(int anoX, int mesX, int diaX)
        {
            string dataStringX = Convert.ToString(anoX) + "-" + Convert.ToString(mesX) + "-" + Convert.ToString(diaX);

            DateTime dataDateX = DateTime.Parse(dataStringX);

            TimeSpan diferenca = DateTime.Now - dataDateX;

            string mensagem = "Diferenca: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
        }
    }
}
