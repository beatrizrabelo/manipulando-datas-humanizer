using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoDatasHumanizer
{
    class CalculoDaDiferençaData
    {
        public CalculoDaDiferençaData(int ano, int mes, int dia)
        {
            string dataString = Convert.ToString(ano) + "-" + Convert.ToString(mes) + "-" + Convert.ToString(dia);

            DateTime dataDateX = DateTime.Parse(dataString);

            string mensagem = "data: " + dataString;

            Console.WriteLine(mensagem);
        }
    }
}
