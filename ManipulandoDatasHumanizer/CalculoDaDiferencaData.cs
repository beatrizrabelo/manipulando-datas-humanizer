using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoDatasHumanizer
{
    class CalculoDaDiferencaData
    {
        private DateTime _dataDate;

        public CalculoDaDiferencaData(int ano, int mes, int dia)
        {

            ConversorData(ano, mes, dia);

            TimeSpan diferenca = DateTime.Now - _dataDate;

            string mensagem = "Aproximadamente: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
        }

        public DateTime ConversorData(int ano, int mes, int dia)
        {
            string dataString = 
                  Convert.ToString(ano) + "-" 
                + Convert.ToString(mes) + "-" 
                + Convert.ToString(dia);

            DateTime dataDate = DateTime.Parse(dataString);

            _dataDate = dataDate;

            return dataDate;
        }

    }
}
