using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EPC.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
