namespace DistributedTravelingSalesman.Domain;

public class ParcelEntity : BaseEntity
{
    public ParcelStatus Status { get; protected internal set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public void Deliver()
    {
        Status = ParcelStatus.Delivered;
    }
}

public enum ParcelStatus
{
    New,
    Delivered
}