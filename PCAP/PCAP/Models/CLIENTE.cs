//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCAP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            this.PEDIDO = new HashSet<PEDIDO>();
        }
        [Required]
        [Display(Name = "Código de cliente")]
        public int CODIGOCLIENTE { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string NOMBRECLIENTE { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string APELLIDOCLIENTE { get; set; }
        [Required]
        [Display(Name = "Correo")]
        [EmailAddress(ErrorMessage = "Direccion de correo electronico invalida")]
        [DataType(DataType.EmailAddress)]
        public string CORREOCLIENTE { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10)]
        [Display(Name = "Teléfono")]
        public string TELEFONOCLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEDIDO> PEDIDO { get; set; }
    }
}
