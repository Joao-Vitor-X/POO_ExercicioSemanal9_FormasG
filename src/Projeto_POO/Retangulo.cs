using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class Retangulo : Forma {
        private double Base;
        private double Altura;

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
