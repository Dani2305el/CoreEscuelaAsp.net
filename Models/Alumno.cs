using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace platzi_asp_net_core.Models
{
    public class Alumno : ObjetoEscuelaBase
    {
        [Required(ErrorMessage="El nombre del alumno es requerido")]
        [MinLength(3,ErrorMessage="La longitud mínima del nombre es 3")]
        public override string Nombre { get; set; }
        public string CursoId { get; set; }
        public Curso Curso { get; set; }
        public List<Evaluación> Evaluaciones { get; set; }
    }
}