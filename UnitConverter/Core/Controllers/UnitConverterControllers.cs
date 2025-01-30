using Microsoft.AspNetCore.Mvc;
using UnitConverter.Domain;

namespace UnitConverter.Core.Controllers;

public class UnitConverterControllers
{
    [Route(template: "Converter")]

    public class UnitConverterController : ControllerBase
    {
        [HttpGet(template: "Units")]

        public async Task<IActionResult> UnitConverter(UnitConverterEntities unitConverterEntity)
        {
            
        }
        
        
    }
}