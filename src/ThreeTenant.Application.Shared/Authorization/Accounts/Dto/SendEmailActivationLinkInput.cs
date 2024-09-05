using System.ComponentModel.DataAnnotations;

namespace ThreeTenant.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}