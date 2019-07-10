using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_DTO
{
    class EMPLEADO_DTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Empleado()
        //{
        //    this.OrdenPedidoes = new HashSet<OrdenPedido>();
        //    this.Usuarios = new HashSet<Usuario>();
        //    this.OrdenPedidoes1 = new HashSet<OrdenPedido>();
        //}

        public string cod_emp { get; set; }
        public string nom_emp { get; set; }
        public string dir_emp { get; set; }
        public string cod_dis { get; set; }
        public string cargo { get; set; }
        public string edad { get; set; }
        public int tel { get; set; }
        public Nullable<int> cel { get; set; }
        public System.DateTime ingreso { get; set; }
        public string clave { get; set; }

        //public virtual Distrito Distrito { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrdenPedido> OrdenPedidoes { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Usuario> Usuarios { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrdenPedido> OrdenPedidoes1 { get; set; }
    }
}
