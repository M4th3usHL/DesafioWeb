using System.ComponentModel.DataAnnotations;
namespace DesafioWeb.Models{
    public class funcionarios
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string None_Completo { get; set; }

        [Required, StringLength(50)]
        public string Posicao { get; set; }

        public DateTime? Aniversario { get; set; }

        [StringLength(20)]
        public string Telefone { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public decimal? Salario { get; set; }

        public ICollection<Cursos> Cursos { get; set; }
        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<Documentos> Documentos { get; set; }
        }
}