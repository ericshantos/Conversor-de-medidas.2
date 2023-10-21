using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor.Model
{
    public class Temperatura
    {
        public virtual double Celsius(double valorDeEntrada)
        {
            return 0;
        }

        public virtual double Kelvin(double valorDeEntrada)
        {
            return 0;
        }

        public virtual double Fahrenhait(double valorDeEntrada)
        {
            return 0;
        }


    }

    public class Celsius : Temperatura
    {
        public override double Kelvin(double valorDeEntrada)
        {
            return valorDeEntrada + 273.15;
        }

        public override double Fahrenhait(double valorDeEntrada)
        {
            return (valorDeEntrada * 1.8) + 32;
        }
    }

    public class Fahrenhait : Temperatura
    {
        public override double Celsius(double valorDeEntrada)
        {
            return (valorDeEntrada - 32) * 5 / 9;
        }

        public override double Kelvin(double valorDeEntrada)
        {
            return (valorDeEntrada - 32) * 5 / 9 + 273.15;
        }
    }

    public class Kelvin : Temperatura
    {
        public override double Celsius(double valorDeEntrada)
        {
            return valorDeEntrada - 273.15;
        }

        public override double Fahrenhait(double valorDeEntrada)
        {
            return (valorDeEntrada - 273.15) * 9 / 5 + 32;
        }
    }
}
