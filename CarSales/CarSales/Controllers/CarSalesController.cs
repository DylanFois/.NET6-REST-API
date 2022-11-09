using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("carsales")]

public class CarSalesController : ControllerBase
{
    private readonly ICarSalesListingService _carsalesService;

    public CarSalesController(ICarSalesListingService carSalesListingService){
        _carsalesService = carSalesListingService;
    }

    [HttpPost]
    public IActionResult CreateCarSales(CreateCarSalesRequest request)
    {
        var carSalesListing = new CarSalesListing(
            Guid.NewGuid(),
            request.make,
            request.model,
            request.year,
            request.color,
            request.kilometres,
            request.saleprice,
            request.listDatetime,
            DateTime.UtcNow,
            request.options
        );

        // TODO: save carsales listing to database
        _carsalesService.CreateCarSalesListing(carSalesListing);

        var response = new CarSalesResponse(
            carSalesListing.ID,
            carSalesListing.make,
            carSalesListing.model,
            carSalesListing.year,
            carSalesListing.color,
            carSalesListing.kilometres,
            carSalesListing.saleprice,
            carSalesListing.listDateTime,
            carSalesListing.lastModifiedDateTime,
            carSalesListing.options
        );

        return CreatedAtAction(
            actionName: nameof(GetCarSales),
            routeValues: new {id = carSalesListing.ID}, 
            value: response
            );
    }

        [HttpGet("{id:guid}")]
    public IActionResult GetCarSales(Guid id)
    {
        CarSalesListing carSalesListing = _carsalesService.GetCarSalesListing(id);

        var response = new CarSalesResponse(
            carSalesListing.ID,
            carSalesListing.make,
            carSalesListing.model,
            carSalesListing.year,
            carSalesListing.color,
            carSalesListing.kilometres,
            carSalesListing.saleprice,
            carSalesListing.listDateTime,
            carSalesListing.lastModifiedDateTime,
            carSalesListing.options
        );

        return Ok(response);
    }

        [HttpPut("{id:guid}")]
    public IActionResult UpdateCarSales(Guid id, UpdateCarSalesRequest request)
    {
        var listing = new CarSalesListing(id, 
        request.make, 
        request.model, 
        request.year, 
        request.color, 
        request.kilometres, 
        request.saleprice, 
        request.listDatetime, 
        DateTime.UtcNow, 
        request.options);

        _carsalesService.UpdateListing(listing);

        // TODO: return 201 if a new listing is created
        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteCarSales(Guid id)
    {
        _carsalesService.DeleteListing(id);
        return NoContent();
    }
}