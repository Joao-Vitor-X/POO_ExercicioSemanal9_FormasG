using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class Retangulo : Forma {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo(double baseRet, double altura, string descricao = "Retângulo")
            : base(descricao)
        {
            Base = baseRet;
            Altura = altura;
        }

        public override double Area()
        {
            return Base * Altura;
        }

        public override double Perimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
