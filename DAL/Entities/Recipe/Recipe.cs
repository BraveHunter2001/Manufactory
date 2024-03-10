using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Utils;

namespace DAL.Entities.Recipe;

public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string RecipeBodyJson { get; set; }

    [NotMapped]
    public RecipeBody RecipeBody => RecipeBodyJson.Deserialize<RecipeBody>();
}

public class RecipeBody
{
    [JsonConverter(typeof(StringEnumConverter))]
    public ProduceType ProduceType { get; set; }
    public List<Resource.Resource> InputResource { get; set; }
    public List<Resource.Resource> OutputResource { get; set; }
}

public enum ProduceType
{
    None,
    Melting
}