using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("carsales")]

public class CarSalesController : ControllerBase
{
    [HttpPost()]
    public IActionResult CreateCarSales(CreateCarSalesRequest request)
    {
        return Ok(request);
    }

        [HttpGet("{id:guid}")]
    public IActionResult GetCarSales(Guid id)
    {
        return Ok(id);
    }

        [HttpPut("{id:guid}")]
    public IActionResult UpdateCarSales(Guid id, UpdateCarSalesRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteCarSales(Guid id)
    {
        return Ok(id);
    }
}