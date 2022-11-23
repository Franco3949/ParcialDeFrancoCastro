using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOEntidades.Ortoedros
{
    public class Ortoedros
    {
        public int aristasA { get; set; }
        public int aristaB { get; set; }
        public int aristaC { get; set; }
        public ColorRelleno colorRelleno { get; set; }

        public int GetArea() 
        {
            return 2 * (aristasA * aristaB + aristaB * aristaC + aristaC * aristasA);
        }

        public int GetVolumen()
        {
            return aristasA * aristaB * aristaC;
        }

        public bool Validar()
        {
            return (aristasA != aristaB) || (aristasA != aristaC) || (aristaB != aristaC);
        }
    }
}
