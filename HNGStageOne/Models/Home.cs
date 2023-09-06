using System.Net;

namespace HNGStageOne.Models
{
	public class Home
	{
		public string? Slack_name { get; set; }
		public string? Current_day { get; set; }
		public DateTime Utc_time { get; set; }
		public string? Track { get; set; }
        public string? GitHubFileUrl { get; set; }
        public string? GitHubRepoUrl { get; set; }
        public HttpStatusCode Status_code { get; set; }
    }
}
