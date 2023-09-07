using HNGStageOne.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HNGStageOne.Controllers
{
	[ApiController]
	public class HomeController : ControllerBase
	{
		[AllowAnonymous]
		[HttpGet("api")]
		public IActionResult Index(string slack_name, string track)
		{
			DateTime now = DateTime.Now.ToUniversalTime();
			var model = new Home
			{
				Slack_name = slack_name,
				Track = track,
				Status_code = System.Net.HttpStatusCode.OK,
				Current_day = now.DayOfWeek.ToString(),
				Utc_time = now.ToString("yyyy-MM-ddTHH:mm:ssZ"),
			};
			return Ok(model);
		}
	}
}
