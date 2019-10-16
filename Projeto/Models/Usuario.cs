using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
    }
}