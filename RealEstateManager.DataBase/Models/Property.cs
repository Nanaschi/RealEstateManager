namespace RealEstateManager.DataBase.Models;

public class Property
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Family { get; set; }
    public decimal Value { get; set; }
}