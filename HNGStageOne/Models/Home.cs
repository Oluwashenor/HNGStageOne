using System.Net;
using static System.Net.WebRequestMethods;

namespace HNGStageOne.Models
{
	public class Home
	{
		public string? Slack_name { get; set; }
		public string? Current_day { get; set; }
		public string Utc_time { get; set; }
		public string? Track { get; set; }
		public string? Github_file_url { get; set; } = "https://github.com/Oluwashenor/HNGStageOne/blob/master/HNGStageOne/Controllers/HomeController.cs";
		public string? Github_repo_url { get; set; } = "https://github.com/Oluwashenor/HNGStageOne";
        public HttpStatusCode Status_code { get; set; }
    }
}
