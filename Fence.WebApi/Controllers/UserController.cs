using Fence.Business;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Fence.WebApi.Controllers
{
    public class UserController : ApiController
    {
        private readonly IDisplayService _displayService;

        public UserController(IDisplayService displayService)
        {
            _displayService = displayService;
        }

        [HttpGet]
        public async Task<HttpResponseMessage> GetUsersAndMessagesList()
        {
            var users = await _displayService.GetUsersWithMessages();
            return Request.CreateResponse(HttpStatusCode.Accepted, users);
        }
    }
}
