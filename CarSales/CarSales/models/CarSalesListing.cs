public class CarSalesListing
{
    public Guid ID {get;}
    public string make {get;}
    public string model {get;}
    public int year {get;}
    public string color {get;}
    public int kilometres {get;}
    public int saleprice {get;}
    public DateTime listDateTime {get;}
    public DateTime lastModifiedDateTime {get;}
    public List<string> options {get;}

    public CarSalesListing(Guid id, string make, string model, int year, string color, int kilometres, int saleprice, DateTime listDateTime, DateTime lastModifiedDateTime, List<string> options)
    {
        ID = id;
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
        this.kilometres = kilometres;
        this.saleprice = saleprice;
        this.listDateTime = listDateTime;
        this.lastModifiedDateTime = lastModifiedDateTime;
        this.options = options;
    }

}