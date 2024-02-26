using MaterialProducer.DTOs;
using MaterialProducer.Services;
using Microsoft.AspNetCore.Mvc;

namespace MaterialProducer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController(IMaterialProducer materialProducer) : ControllerBase
    {
        [HttpGet("diamond")]
        public IActionResult GetDiamond()
        {
            var material = materialProducer.Produce(new RawMaterialDto { Type = RawMaterialType.Diamond, Mass = 1 });
            return Ok(material);
        }

        [HttpGet("produceUnit")]
        public IActionResult GetMaterialUnit([FromBody] MaterialRequestDTO materialRequest)
        {
            var material = materialProducer.Produce(materialRequest);
            return Ok(material);
        }
    }
}