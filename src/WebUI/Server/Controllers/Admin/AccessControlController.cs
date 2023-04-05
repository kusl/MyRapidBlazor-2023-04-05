using Microsoft.AspNetCore.Mvc;
using MyRapidBlazor.Application.AccessControl.Commands;
using MyRapidBlazor.Application.AccessControl.Queries;
using MyRapidBlazor.WebUI.Shared.AccessControl;
using MyRapidBlazor.WebUI.Shared.Authorization;

namespace MyRapidBlazor.WebUI.Server.Controllers.Admin;

[Route("api/Admin/[controller]")]
public class AccessControlController : ApiControllerBase
{
    [HttpGet]
    [Authorize(Permissions.ViewAccessControl)]
    public async Task<ActionResult<AccessControlVm>> GetConfiguration()
    {
        return await Mediator.Send(new GetAccessControlQuery());
    }

    [HttpPut]
    [Authorize(Permissions.ConfigureAccessControl)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> UpdateConfiguration(RoleDto updatedRole)
    {
        await Mediator.Send(new UpdateAccessControlCommand(updatedRole.Id, updatedRole.Permissions));

        return NoContent();
    }
}
