using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Triangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }


        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }


        public Coordenada coordenada1 { get; set; }
        public Coordenada coordenada2 { get; set; }
        public Coordenada coordenada3 { get; set; }



        double CalcularDistancia()
        {
            
            return 0;

        }
        void CalcularLados()
        {
            LadoA = CalcularDistancia();
        }
        void CalcularSemiperimetro()
        {
            
        }


        public int CalcularArea()
        {
            return (Base * Altura) / 2;
        }

    }
}
