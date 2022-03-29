using System.ComponentModel.DataAnnotations;

namespace gy_PartyInvitation.Models
{
    public class Participant
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        [Display(Name = "Ad")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Lütfen yaşınızı giriniz")]
        [Display(Name = "Yaş")]
        [Range(18, 99, ErrorMessage = "18 yaşından büyük olmak zorundasınız")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
    
        [Display(Name = "Katılımcı")]
        public bool Participation { get; set; }



    }
}
