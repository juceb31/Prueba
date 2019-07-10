using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_DTO
{
    public class BOLETA_DTO
    {
           public string num_boleta { get; set; }
            public System.DateTime fecha { get; set; }
            public string cod_empl { get; set; }
            public string cod_cli { get; set; }
            public string num_ordenpedido { get; set; }
            public int subtotal { get; set; }
            public Nullable<int> descuento { get; set; }
            public int total { get; set; }

        //    public virtual OrdenPedido OrdenPedido { get; set; }
        
    }
}
