using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MiniApp1.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        public IActionResult GetStock()
        {
            var userName = HttpContext.User.Identity.Name;

            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

            //StockId StockQuantity Category UserId/UserName
            return Ok($"Stock İşlemleri => UserName: {userName}- UserId: {userId}");

        }
    }
}
