using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class CalcularIVA
    {
        public static decimal CalcularIva(decimal productPrice)
        {
            decimal iva = productPrice * 0.21m;

            return productPrice + iva;
        }
    }
}
