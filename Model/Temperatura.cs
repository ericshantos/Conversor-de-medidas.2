using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_medidas.Model
{
    public class Temperatura
    {
        public double resultado;
        public double retorno;
        
        public double Retorno
        {
            get{return retorno;} 
            set{retorno = value;}
        }

        public virtual double Celsius(double valorDeEntrada) {return 0;}

        public virtual double Kelvin(double valorDeEntrada) {return 0;}

        public virtual double Fahrenheit(double valorDeEntrada) {return 0;}
    }

    public class Celsius : Temperatura
    {
        public override double Kelvin(double valorDeEntrada)
        {
            resultado = valorDeEntrada - 273.15;
            return resultado;
        }
    }
}
