using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionProject.Configurations 
    {
    public class UserWithRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

    private const string managerUserId = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7";
    private const string managerRoleId = "2301D884-221A-4E7D-B509-0113DCC043E1";
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(new IdentityUserRole<string>
        {
            RoleId = managerRoleId,
            UserId = managerUserId
        });
    }
}
}
