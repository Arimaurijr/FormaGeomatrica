using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeomatrica
{
    internal class Triangulo : FormaGeomatricas
    {
        public double CalcularArea()
        {
            return base.CalcularArea() / 2;
        }
    }
}
