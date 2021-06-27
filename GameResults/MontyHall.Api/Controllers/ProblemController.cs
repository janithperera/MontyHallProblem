using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MontyHall.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MontyHall.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProblemController : ControllerBase
  {
	/// <summary>
	/// The monty hall problem
	/// </summary>
	private readonly IMontyHallProblem montyHallProblem;

	/// <summary>
	/// Initializes a new instance of the <see cref="ProblemController"/> class.
	/// </summary>
	/// <param name="montyHallProblem">The monty hall problem.</param>
	public ProblemController(IMontyHallProblem montyHallProblem)
	{
	  this.montyHallProblem = montyHallProblem;
	}

	/// <summary>
	/// Solves the problem.
	/// </summary>
	/// <param name="tries">The tries.</param>
	/// <returns></returns>
	[HttpGet]
	public ActionResult SolveProblem([FromQuery]int tries)
	{
	  var result = montyHallProblem.CalculateProbability(tries);
	  return Ok(result);
	}
  }
}
