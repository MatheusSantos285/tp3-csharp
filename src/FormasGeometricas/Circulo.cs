namespace FormasGeometricas
{
    public class Circulo
    {
        private double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double GetRaio()
        {
            return Raio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
