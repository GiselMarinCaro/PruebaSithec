using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service
{
    public class Operaciones
    {
        public int Suma(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public int Multiplicacion(int n1, int n2, int n3)
        {
            return n1 * n2 * n3;
        }
    }
}
