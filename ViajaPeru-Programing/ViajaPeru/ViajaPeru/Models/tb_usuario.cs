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
    
    public partial class tb_usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_usuario()
        {
            this.tb_itinerario = new HashSet<tb_itinerario>();
        }
    
        public int id_cliente { get; set; }
        public string nom_cliente { get; set; }
        public string apepat_cliente { get; set; }
        public string apemat_cliente { get; set; }
        public int sexo_cliente { get; set; }
        public string dni_cliente { get; set; }
        public string correo_cliente { get; set; }
        public string direccion_cliente { get; set; }
        public string nrotarjeta_cliente { get; set; }
        public int estado_cliente { get; set; }
        public System.DateTime fecnac_cliente { get; set; }
        public string usuario_cliente { get; set; }
        public string contra_cliente { get; set; }
        public Nullable<int> id_tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_itinerario> tb_itinerario { get; set; }
        public virtual tb_tipo_usuario tb_tipo_usuario { get; set; }
    }
}
