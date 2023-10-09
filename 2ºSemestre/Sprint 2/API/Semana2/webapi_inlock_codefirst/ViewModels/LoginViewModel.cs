using System.ComponentModel.DataAnnotations;
using webapi_inlock_codefirst.Domains;
using webapi_inlock_codefirst.Utils;

namespace webapi_inlock_codefirst.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória!")]

        public string Senha { get; set; }

    }
}
