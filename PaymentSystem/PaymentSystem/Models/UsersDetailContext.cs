using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace PaymentSystem.Models
{
    public class UsersDetailContext : IdentityDbContext<UserDetails>
    {
        public UsersDetailContext(DbContextOptions<UsersDetailContext> options) : base(options)
        { }
    }
}
