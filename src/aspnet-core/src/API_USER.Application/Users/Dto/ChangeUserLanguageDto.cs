using System.ComponentModel.DataAnnotations;

namespace API_USER.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}