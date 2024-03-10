namespace DAL.Entities.Resource;

public class Resource
{
    public int ResourceDescriptionId { get; set; }
    public ResourceDescription ResourceDescription { get; set; }
    public decimal Mass { get; set; }
}