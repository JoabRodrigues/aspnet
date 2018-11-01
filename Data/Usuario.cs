using System;
using System.ComponentModel.DataAnnotations;

namespace FirstProject.Data
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required(ErrorMessage="Nome é obrigatório!")]
        public string Nome { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="Favor colocar um e-mail válido.")]
        public string Email { get; set; }

        [RegularExpression(@"\d\d\d\d\d\d\d\d\d-\d\d", ErrorMessage = "Formato do CPF inválido!")]
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string Senha { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public int Tipo { get;set; }
    }
}
