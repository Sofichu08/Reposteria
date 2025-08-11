using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria._02
{
    class Producto
    {
        public string nombre;
        public int cantidad;
        public string descrip;
        public override string ToString()
        {
            return $" {nombre} |\t {cantidad} | {descrip}";
        }
    }
}
