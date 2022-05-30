using System.ComponentModel.DataAnnotations;

namespace BACK.PORTFOLIO.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}