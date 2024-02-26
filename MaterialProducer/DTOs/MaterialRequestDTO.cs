using MaterialProducer.Entities;

namespace MaterialProducer.DTOs;

public class MaterialRequestDTO
{
    public MaterialType Type { get; set; }
    public int Mass { get; set; }
}