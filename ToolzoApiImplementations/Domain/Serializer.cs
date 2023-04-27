using Newtonsoft.Json;

namespace ToolzoApiImplementations.Domain;
public static class Serializer
{
    public static string Serialize(object data, bool intended = false)
    {
        return JsonConvert.SerializeObject(data, intended ? Formatting.Indented : Formatting.None);
    }

    public static T? Deserialize<T>(string data)
    {
        return JsonConvert.DeserializeObject<T>(data);
    }
}