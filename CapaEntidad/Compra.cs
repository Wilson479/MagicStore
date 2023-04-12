using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
  public  class Compra
    {
        public int Id_Compra { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Factura { get; set; }
        public string  Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Total { get; set; }
    }
}
