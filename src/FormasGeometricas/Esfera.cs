using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    public class Esfera
    {
        private double Raio { get; set; }

        public Esfera(double raio)
        {
            Raio = raio;
        }

        public double GetRaio()
        {
            return Raio;
        }
        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Raio, 3);
        }
    }
}
