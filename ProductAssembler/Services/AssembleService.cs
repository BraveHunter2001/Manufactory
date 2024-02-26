using ProductAssembler.Consumers;
using ProductAssembler.Entities;
using System;
using System.Linq;

namespace ProductAssembler.Services;

public interface IAssembleService
{
    Product Assemble(Recipe recipe);
}

public class AssembleService(IMaterialConsumer materialConsumer) : IAssembleService
{
    public Product Assemble(Recipe recipe)
    {
        var materials = recipe.MaterialTypes.ConvertAll(type => materialConsumer.Consume(type, new Random().Next(1, 100)));

        if (materials.Any(m => m is null)) return null;

        var quality = materials
            .GroupBy(m => m.Quality)
            .MaxBy(g => g.Count()).Key;

        var totalMass = materials.Sum(m => m.Mass);
        return new() { Type = recipe.ProductType, Materials = materials, Quality = quality, Mass = totalMass };
    }
}