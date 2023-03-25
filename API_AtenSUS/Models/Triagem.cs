using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_AtenSUS.Models
{
    [Table("Triagens")]
    public class Triagem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DataHora { get; set; }
        [Required]       
        public int Nivel { get; set; }
        [Required]

        public TipoDeEspecialidade Tipo{ get; set; }

        public ICollection<Paciente> Pacientes { get; set; }   
    }

    public enum TipoDeEspecialidade
    {
        Clinico_Geral,
        Ortopedista,
        Pediatra,
        Cirurgiao
    }
}
