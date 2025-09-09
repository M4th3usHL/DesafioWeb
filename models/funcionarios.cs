using System.ComponentModel.DataAnnotations;
namespace DesafioWeb.Models{
        public class funcionarios{
            public intt Id {get; set;}
            [Required, StringLength(100)]
            public string Nome_completo {get; set;}
        }
}