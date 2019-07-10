using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_DTO
{
    class USUARIO_DTO
    {
        public string cod_usu { get; set; }
        public string cod_emp { get; set; }
        public string nivel_usu { get; set; }
        public string nom_usu { get; set; }
        public string password { get; set; }
        public string activo { get; set; }

        //public virtual Empleado Empleado { get; set; }
    }
}
