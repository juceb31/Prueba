using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_DTO
{
    class CATEGORIA_DTO
    {
        //public Categoria()
        //{
        //    this.Productoes = new HashSet<Producto>();
        //}

        public string cod_cate { get; set; }
        public string nom_des { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Producto> Productoes { get; set; }
    }
}
