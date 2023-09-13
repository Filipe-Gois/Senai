using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_inlock_codefirst.Interfaces;
using webapi_inlock_codefirst.Repositories;

namespace webapi_inlock_codefirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EstudioController : ControllerBase
    {
        private IEstudio _estudioRepository { get; set; }
        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }
    }
}
