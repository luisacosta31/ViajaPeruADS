//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViajaPeru.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_trabajador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_trabajador()
        {
            this.tb_itinerario = new HashSet<tb_itinerario>();
        }
    
        public int id_trabajador { get; set; }
        public string nom_trabajador { get; set; }
        public string apepat_trabajador { get; set; }
        public string apemat_trabajador { get; set; }
        public int sexo_trabajador { get; set; }
        public string dni_trabajador { get; set; }
        public string correo_trabajador { get; set; }
        public System.DateTime fecnac_trabajador { get; set; }
        public System.DateTime feccom_trabajador { get; set; }
        public int estado_trabajador { get; set; }
        public string direccion_trabajador { get; set; }
        public string usuario_trabajador { get; set; }
        public string contra_trabajador { get; set; }
        public Nullable<int> id_tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_itinerario> tb_itinerario { get; set; }
        public virtual tb_tipo_usuario tb_tipo_usuario { get; set; }
    }
}