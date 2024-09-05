using System.ComponentModel.DataAnnotations;

namespace ThreeTenant.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
