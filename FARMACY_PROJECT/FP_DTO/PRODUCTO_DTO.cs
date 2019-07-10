using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_DTO
{
    class PRODUCTO_DTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Producto()
        //{
        //    this.DetalleOrdenPedidoes = new HashSet<DetalleOrdenPedido>();
        //}

        public string cod_pro { get; set; }
        public string nom_pro { get; set; }
        public decimal pre_venta { get; set; }
        public decimal pre_compra { get; set; }
        public System.DateTime fecha_venc { get; set; }
        public int stock { get; set; }
        public string cod_cate { get; set; }
        public string cod_prov { get; set; }
        public string cod_pres { get; set; }

        //public virtual Categoria Categoria { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<DetalleOrdenPedido> DetalleOrdenPedidoes { get; set; }
        //public virtual Presentacion Presentacion { get; set; }
        //public virtual Proveedor Proveedor { get; set; }
    }
}
