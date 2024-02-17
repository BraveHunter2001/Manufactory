using Microsoft.AspNetCore.Mvc;
using RawMaterialProducer.Models;
using RawMaterialProducer.Services;

namespace RawMaterialProducer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RawMaterialController(IRawMaterialProducer rawMaterialProducer) : ControllerBase
    {
        [HttpGet("produceUnit")]
        public IActionResult GetUnit(RawMaterialUnitModel unitModel)
        {
            if (unitModel is null) return BadRequest();

            var result = rawMaterialProducer.ProduceUnit(unitModel.RawMaterialType, unitModel.Mass);
            return Ok(result);
        }
    }
}