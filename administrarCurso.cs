using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorCursos
{
    public class administrarCurso
    {
        public int idCurso { get; set; }
        public string descripcion { get; set; }

        public string toString()
        {
            return idCurso + descripcion;
        }


    }
}
