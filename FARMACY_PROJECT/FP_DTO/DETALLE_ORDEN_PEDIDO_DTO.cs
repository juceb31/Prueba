using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_DTO
{
    class DETALLE_ORDEN_PEDIDO_DTO
    {
        public string num_ordenp { get; set; }
        public string cod_pro { get; set; }
        public string nom_pro { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<decimal> precio_venta { get; set; }
        public Nullable<decimal> importe { get; set; }

        //public virtual Producto Producto { get; set; }
    }
}
