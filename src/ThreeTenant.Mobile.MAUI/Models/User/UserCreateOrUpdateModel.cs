using Abp.AutoMapper;
using ThreeTenant.Authorization.Users.Dto;

namespace ThreeTenant.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput
    {

    }
}
