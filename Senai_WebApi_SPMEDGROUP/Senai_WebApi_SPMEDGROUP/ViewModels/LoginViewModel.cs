using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Senai_WebApi_SPMEDGROUP.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "A senha deve ter entre 3 e 50 caracteres")]
        public string Senha { get; set; }
    }
}
