//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdministradorCursos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFactura
    {
        public int idDetalleFactura { get; set; }
        public int descuento { get; set; }
        public int idCurso { get; set; }
        public decimal total { get; set; }
        public Nullable<int> codFactura { get; set; }
    
        public virtual Curso Curso { get; set; }
    }
}
