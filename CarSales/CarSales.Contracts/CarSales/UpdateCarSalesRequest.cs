public record UpdateCarSalesRequest(
    string make,
    string model,
    int year,
    string color,
    int kilometres,
    int saleprice,
    DateTime listDatetime,
    List<string> options
);