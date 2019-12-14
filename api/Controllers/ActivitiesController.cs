using System.Collections.Generic;
using System.Threading.Tasks;
using application.Activities;
using domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ActivitiesController : ControllerBase
  {
    private readonly IMediator _mediator;

    public ActivitiesController(IMediator mediator)
    {
      _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<Activity>>> List()
    {
      return await _mediator.Send(new List.Query());
    }
  }
}