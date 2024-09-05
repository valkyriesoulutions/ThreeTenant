using System.ComponentModel.DataAnnotations;

namespace ThreeTenant.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}