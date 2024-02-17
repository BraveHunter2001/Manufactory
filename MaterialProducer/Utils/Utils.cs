namespace MaterialProducer.Utils;

public static class Utils
{
    private static Random _random = new ();

    public static T RandomEnumValue<T>()
    {
        var values = Enum.GetValues (typeof (T));   
        return (T)values.GetValue(_random.Next (values.Length));
    }
}
