using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FIlmesLeoesDeJuda.API.ViewModels
{
    public class UsuarioVM
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        public string Nome { get; set; }
        [EmailAddress(ErrorMessage = "Email no formato incorreto")]
        public string Email { get; set; }
        [MinLength(6,ErrorMessage ="A senha deve ter um mínimo de 6 caracteres")]
        public string Senha { get; set; }
    }


}
