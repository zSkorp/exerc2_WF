using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2WF
{
    internal class Aresta
    {
        private double aresta;


        public Aresta(double aresta)
        {
            this.aresta = aresta;
        }

        public Aresta()
        {
            this.aresta = 0;
        }

        public void setAresta(double aresta)
        {
            this.aresta = aresta;
        }

        public double getAresta()
        {
            return this.aresta = aresta;
        }


        public double CalcularArea()

        {
            return aresta * aresta;
        }
    }
}
