//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibraryModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalle_Materia
    {
        public int idDetalle_materia { get; set; }
        public int idMateria { get; set; }
        public int idEvaluacion { get; set; }
        public int idSeccion { get; set; }
        public string catalogoMateria { get; set; }
    
        public virtual Materia Materia { get; set; }
        public virtual Evaluacion Evaluacion { get; set; }
        public virtual Seccion Seccion { get; set; }
    }
}
