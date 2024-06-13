using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Adınız")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Soyadınız")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Cep Telefonu Numaranız")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "E-mail Adresiniz")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Şifreniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Şifreyi Onaylayın")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Kullanım Şartlarını Kabul Ediyorum")]
        public bool TermsAccepted { get; set; }

        [Display(Name = "Ticari Posta Gönderimini Kabul Ediyorum")]
        public bool CommercialEmailsAccepted { get; set; }
    }
}


