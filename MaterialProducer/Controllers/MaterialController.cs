using MaterialProducer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaterialProducer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController(IRawMaterialConsumer rawMaterialConsumer) : ControllerBase
    {

        [HttpGet("diamond")]
        public IActionResult GetDiamond() 
        {
            return Ok(rawMaterialConsumer.ConsumeRawMaterial(DTOs.RawMaterialType.Diamond, 1));
        }

    }
}
