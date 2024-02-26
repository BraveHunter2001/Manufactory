using System.Collections.Generic;
using ProductAssembler.DTO;

namespace ProductAssembler.Entities;

public class Recipe
{
    public int Id { get; set; }

    public ProductType ProductType { get; set; }

    public List<MaterialType> MaterialTypes { get; set; }
}