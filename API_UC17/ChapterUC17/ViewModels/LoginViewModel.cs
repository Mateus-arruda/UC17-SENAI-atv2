using System.ComponentModel.DataAnnotations;

namespace ChapterUC17.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o Email do usuário")]
        public  string? email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário")]
        public string? senha { get; set; }

    }
}