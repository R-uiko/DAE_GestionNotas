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
    
    public partial class Asistencia
    {
        public int idAsistencia { get; set; }
        public int idAlumno { get; set; }
        public int idDocente { get; set; }
        public Nullable<System.DateTime> periodoAsistencia { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        public virtual Docente Docente { get; set; }
    }
}
