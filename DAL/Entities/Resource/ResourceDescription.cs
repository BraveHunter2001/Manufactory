using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Resource;

public class ResourceDescription
{
    public int Id { get; set; }
    public string Name => $"{MaterialType}-{FormType}";

    [Column(TypeName = "text")]
    public MaterialType MaterialType { get; set; }

    [Column(TypeName = "text")]
    public FormType FormType { get; set; }
}

public enum MaterialType
{
    None,
    Gold
}

public enum FormType
{
    None,
    Ore,
    Bar
}