using Microsoft.AspNetCore.Mvc;

[ApiController]

public class CarSalesController : ControllerBase
{
    [HttpPost("/carsales")]
    public IActionResult CreateCarSales(CreateCarSalesRequest request)
    {
        return Ok(request);
    }

        [HttpGet("/carsales/{id:guid}")]
    public IActionResult GetCarSales(Guid id)
    {
        return Ok(id);
    }

        [HttpPut("/carsales/{id:guid}")]
    public IActionResult UpdateCarSales(Guid id, UpdateCarSalesRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("/carsales/{id:guid}")]
    public IActionResult DeleteCarSales(Guid id)
    {
        return Ok(id);
    }
}