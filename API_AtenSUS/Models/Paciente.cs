using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_AtenSUS.Models
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set;}
        [Required]
        public string Endereco { get; set; }

        [Required]
        public int TriagemId { get; set; }

        public Paciente Triagem { get; set; }



    }
}
