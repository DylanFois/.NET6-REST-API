//namespace CarSales.Services.CarSalesListings;

public interface ICarSalesListingService
{
    void CreateCarSalesListing(CarSalesListing carSalesListing);

    CarSalesListing GetCarSalesListing(Guid id);
}