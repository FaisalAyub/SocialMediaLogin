using System.ComponentModel.DataAnnotations;

namespace BoilerPlaitApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}