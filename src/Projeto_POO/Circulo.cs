using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class Circulo : Forma {
        public double Raio { get; set; }

        public Circulo(double raio) : base("Círculo")
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}
