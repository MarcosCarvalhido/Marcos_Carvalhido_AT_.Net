using System.ComponentModel.DataAnnotations;

namespace InfnetMVC.Data
{
    public class Aluno
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Nome deve ter entre 4 e 50 caracteries.")]
        public string Name { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Display(Name = "Data De Nascimento")]
        [DataType(DataType.Date)]
        public string Nascimento { get; set; }
    }
}
