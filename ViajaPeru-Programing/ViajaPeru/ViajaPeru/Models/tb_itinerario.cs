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
    
    public partial class tb_itinerario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_itinerario()
        {
            this.tb_comprobante = new HashSet<tb_comprobante>();
        }
    
        public int id_itinerario { get; set; }
        public System.DateTime fecsalida_itinerario { get; set; }
        public System.DateTime fecllegada_itinerario { get; set; }
        public string lugardestino_itinerario { get; set; }
        public string lugarllegada_itinerario { get; set; }
        public decimal precio_itinerario { get; set; }
        public int estado_itinerario { get; set; }
        public Nullable<int> id_mediotrans { get; set; }
        public int id_paquete { get; set; }
        public int id_usuario { get; set; }
        public int id_trabajador { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_comprobante> tb_comprobante { get; set; }
        public virtual tb_mediotrans tb_mediotrans { get; set; }
        public virtual tb_paquetes tb_paquetes { get; set; }
        public virtual tb_trabajador tb_trabajador { get; set; }
        public virtual tb_usuario tb_usuario { get; set; }
    }
}