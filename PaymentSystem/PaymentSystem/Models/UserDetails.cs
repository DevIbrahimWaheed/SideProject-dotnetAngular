using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PaymentSystem.Models
{
    public class UserDetails : IdentityUser
    {
        [Required] public string FullName { get; set; }
    }
}
