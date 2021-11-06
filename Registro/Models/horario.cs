//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class horario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public horario()
        {
            this.horarioEmpleado = new HashSet<horarioEmpleado>();
        }
    
        public int idHorario { get; set; }

        [Required(ErrorMessage = "El campo tipo de horario es obligatorio.")]
        [RegularExpression(@"^[áéíóúña-zA-Z\s]+$", ErrorMessage = "Ingrese un tipo de horario valido")]
        public string tipo { get; set; }

        [Required(ErrorMessage = "El campo cantidad de horas es obligatorio.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Ingrese una cantidad de horas valida")]
        public int cantidad { get; set; }

        [Required(ErrorMessage = "El campo costo hora normal es obligatorio.")]
        [RegularExpression(@"^[0-9.]+$", ErrorMessage = "Ingrese un costo hora normal valido")]
        public double costoHoraNormal { get; set; }

        [Required(ErrorMessage = "El campo costo hora extra es obligatorio.")]
        [RegularExpression(@"^[0-9.]+$", ErrorMessage = "Ingrese un costo de hora extra valido")]
        public double costoHoraExtra { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horarioEmpleado> horarioEmpleado { get; set; }
    }
}
