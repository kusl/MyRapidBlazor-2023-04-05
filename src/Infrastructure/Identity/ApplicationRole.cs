using Microsoft.AspNetCore.Identity;
using MyRapidBlazor.WebUI.Shared.Authorization;

namespace MyRapidBlazor.Infrastructure.Identity;

public class ApplicationRole : IdentityRole
{
    public Permissions Permissions { get; set; }
}
