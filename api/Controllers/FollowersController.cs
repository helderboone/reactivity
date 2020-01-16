using Application.Followers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/profiles")]
    public class FollowersController : BaseController
    {
        [HttpPost("{username}/follow")]
        public async Task<ActionResult<Unit>> Follow(string username)
        {
            return await Mediator.Send(new Add.Command { Username = username });
        }

        [HttpDelete("{username}/follow")]
        public async Task<ActionResult<Unit>> UnFollow(string username)
        {
            return await Mediator.Send(new Delete.Command { Username = username });
        }
    }
}
