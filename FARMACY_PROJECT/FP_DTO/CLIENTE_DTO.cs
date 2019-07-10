using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_DTO
{
    class CLIENTE_DTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Cliente()
        //{
        //    this.OrdenPedidoes = new HashSet<OrdenPedido>();
        //    this.OrdenPedidoes1 = new HashSet<OrdenPedido>();
        //}

        public string cod_cli { get; set; }
        public string nom_cli { get; set; }
        public string dir_cli { get; set; }
        public string cod_dis { get; set; }
        public string sexo { get; set; }
        public Nullable<int> DNI { get; set; }
        public Nullable<int> RUC { get; set; }
        public Nullable<int> Telefono { get; set; }
        public Nullable<int> Celular { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrdenPedido> OrdenPedidoes { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrdenPedido> OrdenPedidoes1 { get; set; }
        //public virtual Distrito Distrito { get; set; }
    }
}
