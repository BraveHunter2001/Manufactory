using System.Collections.Generic;
using ProductAssembler.DTO;

namespace ProductAssembler.Entities;

public class Product
{
    public int Id { get; set; }
    public ProductType Type { get; set; }
    public List<Material> Materials { get; set; }
    public int Mass { get; set; }
    public Quality Quality { get; set; }
}

public enum ProductType
{
    Ring
}