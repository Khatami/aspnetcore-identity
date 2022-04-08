using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practice.Areas.Movie.Pages
{
	[Authorize(Policy = "MyPolicy", Roles = "Administrator")]
	public class IndexModel : PageModel
	{
		public void OnGet()
		{
		}
	}
}
