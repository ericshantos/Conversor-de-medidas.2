using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor.Model
{
    public class ValoresPadrao
    {
        public double valorIsirido;
        public double ValorInsirido
        {
            get { return valorIsirido; }
            set { valorIsirido = value; }
        }

        public double resultado;
        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
    }
}
