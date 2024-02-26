namespace ProductAssembler.DTO;

public class Material
{
    public MaterialType Type { get; set; }
    public int Mass { get; set; }
    public Quality Quality { get; set; }
}

public class MaterialRequestDTO
{
    public MaterialType Type { get; set; }
    public int Mass { get; set; }
}

public enum MaterialType
{
    Diamond,
    Gold
}

public enum Quality
{
    None,
    Bad,
    Normal,
    High
}