using Microsoft.AspNetCore.Mvc;
using DailyQuotesApi.Models;

namespace DailyQuotesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        private static readonly List<Quote> Quotes = new()
        {
            new Quote { Id = 1, Text = "Talk is cheap. Show me the code.", Author = "Linus Torvalds" },
            new Quote { Id = 2, Text = "First, solve the problem. Then, write the code.", Author = "John Johnson" }
        };

        [HttpGet("random")]
        public IActionResult GetRandom()
        {
            var quote = Quotes[new Random().Next(Quotes.Count)];
            return Ok(quote);
        }
    }
}
