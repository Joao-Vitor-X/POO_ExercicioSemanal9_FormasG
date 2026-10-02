using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class TrianguloRetangulo : Forma {
        private double CatetoA;
        private double CatetoB;
        private double Hipotenusa => Math.Sqrt(Math.Pow(CatetoA, 2) + Math.Pow(CatetoB, 2));

        public TrianguloRetangulo(double catetoA, double catetoB) : base("Triângulo Retângulo")
        {
            CatetoA = catetoA;
            CatetoB = catetoB;
        }

        public override double Area()
        {
            return (CatetoA * CatetoB) / 2.0;
        }

        public override double Perimetro()
        {
            return CatetoA + CatetoB + Hipotenusa;
        }
    }
}
