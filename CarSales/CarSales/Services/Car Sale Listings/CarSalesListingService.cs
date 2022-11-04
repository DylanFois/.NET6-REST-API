public class CarSalesListingService : ICarSalesListingService{
    
    private static readonly Dictionary<Guid, CarSalesListing> _carSalesListing = new();
    public void CreateCarSalesListing(CarSalesListing carSalesListing){

        _carSalesListing.Add(carSalesListing.ID, carSalesListing);
    }

    public CarSalesListing GetCarSalesListing(Guid id){
        return _carSalesListing[id];
    }
}