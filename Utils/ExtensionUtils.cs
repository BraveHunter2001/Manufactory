using Newtonsoft.Json;

namespace Utils;

public static class ExtensionUtils
{
    public static string Serialize(this object @object) => JsonConvert.SerializeObject(@object);
    public static T Deserialize<T>(this string json) => JsonConvert.DeserializeObject<T>(json);
}