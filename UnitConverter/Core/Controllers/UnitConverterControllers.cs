using Microsoft.AspNetCore.Mvc;
using UnitConverter.Domain;

namespace UnitConverter.Core.Controllers

{
    [Route(template: "Converter")]

    public class UnitConverterController : ControllerBase
    {
        [HttpGet(template: "Units")]

        public async Task<IActionResult> UnitConverter(UnitConverterEntities unitConverterEntity)
        {
            var validator = new UnitConverterEntitiesValidator();
            var validatorResult = await validator.ValidateAsync(unitConverterEntity);
            if (!validatorResult.IsValid)
                return BadRequest(validatorResult.Errors);
            var unitConverter = new Application.UnitConverter();
            var converted = unitConverter.Converter(unitConverterEntity);
            return Ok(converted);
        }
        
        
    }
}