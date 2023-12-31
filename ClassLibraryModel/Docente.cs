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
    
    public partial class Docente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Docente()
        {
            this.Asistencia = new HashSet<Asistencia>();
            this.Materia = new HashSet<Materia>();
        }
    
        public int idDocente { get; set; }
        public string nombreDocente { get; set; }
        public int idSeccion { get; set; }
        public int idMateria { get; set; }
        public int idUsuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asistencia> Asistencia { get; set; }
        public virtual Seccion Seccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materia> Materia { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
