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
    
    public partial class tb_movilidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_movilidad()
        {
            this.tb_paquetes = new HashSet<tb_paquetes>();
        }
    
        public int id_movilidad { get; set; }
        public string nomchofer_movilidad { get; set; }
        public string numplaca_movilidad { get; set; }
        public string direccionchofer_movilidad { get; set; }
        public decimal precio_movilidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_paquetes> tb_paquetes { get; set; }
    }
}