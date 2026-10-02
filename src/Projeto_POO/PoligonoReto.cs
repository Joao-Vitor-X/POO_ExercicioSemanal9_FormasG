using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class PoligonoReto : Forma {
        private double LarguraTotal;
        private double AlturaTotal;

        public PoligonoReto(double larguraTotal, double alturaTotal, string descricao = "Polígono Reto") : base(descricao)
        {
            LarguraTotal = larguraTotal;
            AlturaTotal = alturaTotal;
        }

        public override double Area()
        {
            return LarguraTotal * AlturaTotal;
        }

        public override double Perimetro()
        {
            return 2 * (LarguraTotal + AlturaTotal);
        }
    }
}
