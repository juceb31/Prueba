//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FP_DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdenPedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenPedido()
        {
            this.Boletas = new HashSet<Boleta>();
        }
    
        public string num_ordenPedido { get; set; }
        public System.DateTime fecha { get; set; }
        public string cod_cli { get; set; }
        public string nom_cli { get; set; }
        public string cod_emp { get; set; }
        public string cod_tipoPago { get; set; }
        public Nullable<int> total { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleta> Boletas { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Cliente Cliente1 { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Empleado Empleado1 { get; set; }
    }
}
