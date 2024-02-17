namespace MaterialProducer.Entities;

public class Material
{
    public int Id { get; set; }

    public MaterialType Type { get; set; }
    public Quality Quality { get; set; }
    public int Mass { get; set; }
}

public enum MaterialType
{
    Diamond
}

public enum Quality
{
    Bad,
    Normal,
    High
}