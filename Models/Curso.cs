using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace platzi_asp_net_core.Models
{
    public class Curso : ObjetoEscuelaBase
    {
        [Required(ErrorMessage="El nombre del curso es requerido")]
        [MinLength(3,ErrorMessage="La longitud mínima del nombre 3")]
        public override string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        [Display(Prompt="Dirección de correspondencia",Name="Address")]
        [Required(ErrorMessage="La dirección del curso es requerida")]
        [MinLength(10,ErrorMessage="La longitud mínima de la dirección es 10")]
        public string Dirección { get; set; }
        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }
    }
}