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

    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            this.horarioEmpleado = new HashSet<horarioEmpleado>();
        }
    
        public int idEmpleado { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [RegularExpression(@"^[áéíóúña-zA-Z\s]+$" ,ErrorMessage = "Ingrese un nombre valido")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El campo N° de documento es obligatorio.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Ingrese un numero de documento valido")]
        public string documento { get; set; }

        [Required(ErrorMessage = "El campo fecha de nacimiento es obligatorio.")]
        [RegularExpression(@"^([0-2][0-9])\/(0[123456789]|10|11|12)\/[0-9]{4}$", ErrorMessage = "Ingrese un fecha de nacimiento valida (DD/MM/AÑO)")]
        public string fechaNacimiento { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "El campo correo es obligatorio.")]
        public string correo { get; set; }

        [Required(ErrorMessage = "El campo area de trabajo es obligatorio.")]
        [RegularExpression(@"^[áéíóúña-zA-Z\s]+$", ErrorMessage = "Ingrese un area de trabajo valido")]
        public string areaTrabajo { get; set; }

        [Required(ErrorMessage = "El campo sueldo es obligatorio.")]
        [RegularExpression(@"^[0-9.]+$", ErrorMessage = "Ingrese un sueldo valido")]
        public double sueldo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horarioEmpleado> horarioEmpleado { get; set; }
    }
    public class pago
    {
        public int horaExtraTrabajadas { get; set; }
        public float costoHoraNormal { get; set; }
        public float costoHoraExtra { get; set; }
        public int cantidad { get; set; }

        public float Total1
        {
            get { return costoHoraNormal * cantidad; }
        }

        public float Total2
        {
            get { return costoHoraExtra * horaExtraTrabajadas; }
        }
        public float Total
        {
            get { return Total1 + Total2; }
        }
    }

}
