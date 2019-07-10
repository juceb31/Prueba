using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_DTO
{
    class PROVEEDOR_DTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Proveedor()
        //{
        //    this.Productoes = new HashSet<Producto>();
        //}

        public string cod_prov { get; set; }
        public string nom_prov { get; set; }
        public string dir_prov { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string id_distrito { get; set; }

        //public virtual Distrito Distrito { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Producto> Productoes { get; set; }
    }
}
