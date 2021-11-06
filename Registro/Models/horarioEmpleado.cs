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

    public partial class horarioEmpleado
    {
        public int idHorarioEmpleado { get; set; }

        [Required(ErrorMessage = "El campo empleado es obligatorio.")]
        public Nullable<int> idEmpleado { get; set; }
        [Required(ErrorMessage = "El campo tipo horario es obligatorio.")]
        public Nullable<int> idHorario { get; set; }

        [Required(ErrorMessage = "El campo numero de mes es obligatorio.")]
        [Range(1, 12, ErrorMessage = "Ingrese un mes valido")]
        public string mes { get; set; }

        [Required(ErrorMessage = "El campo año es obligatorio.")]
        [Range(1900, 2050, ErrorMessage = "Ingrese un año valido")]
        public string ano { get; set; }

        [Required(ErrorMessage = "El campo semana del mes es obligatorio.")]
        [Range(1, 4, ErrorMessage = "Ingrese un numero de semana del mes valido")]
        public string semanaMes { get; set; }

        [Required(ErrorMessage = "El campo horas extras trabajadas es obligatorio.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Ingrese una cantiad de horas extras valida")]
        public int horaExtraTrabajadas { get; set; }
        public virtual empleado empleado { get; set; }
        public virtual horario horario { get; set; }
    }
}
