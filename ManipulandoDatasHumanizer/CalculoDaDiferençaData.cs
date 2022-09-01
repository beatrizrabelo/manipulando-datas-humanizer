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

            string mensagem = "data: " + dataStringX;

            Console.WriteLine(mensagem);
        }
    }
}
