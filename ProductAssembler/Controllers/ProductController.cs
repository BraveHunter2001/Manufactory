using Microsoft.AspNetCore.Mvc;
using ProductAssembler.DTO;
using ProductAssembler.Entities;
using ProductAssembler.Services;

namespace ProductAssembler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(IAssembleService assembleService) : ControllerBase
    {
        [HttpGet("{type}")]
        public ActionResult Produce(string type)
        {
            var recipe = new Recipe()
            {
                ProductType = ProductType.Ring, MaterialTypes =
                [
                    MaterialType.Gold, MaterialType.Gold, MaterialType.Diamond
                ]
            };


            return Ok(assembleService.Assemble(recipe));
        }
    }
}