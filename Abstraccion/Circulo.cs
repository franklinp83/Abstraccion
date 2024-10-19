using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Circulo : Figura
    {
        public double Radio {get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(2, Radio);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
