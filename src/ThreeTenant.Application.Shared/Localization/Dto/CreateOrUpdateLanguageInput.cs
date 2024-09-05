using System.ComponentModel.DataAnnotations;

namespace ThreeTenant.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}