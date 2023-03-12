using Microsoft.AspNetCore.Identity;

namespace Chat_BlazorApp.Entities.UserEntity
{
    public class User : IdentityUser
    {
        public string PublicName { get; set; }
    }
}
