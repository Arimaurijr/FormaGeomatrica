using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeomatrica
{
    internal class FormaGeomatricas
    {
        public int ladoA { get; set; }
        public int ladoB { get; set;}

        public FormaGeomatricas()
        {

        }
        public  double CalcularArea()
        {
            return ladoA * ladoB;
        }

        public override string ToString()
        {
            return this.ladoB + " " + this.ladoA; 
        }
    }
}
