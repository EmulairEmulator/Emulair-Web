public static class ConfigurationExtensions
{
    public static T GetConfiguration<T>(this IConfiguration config, string sectionName = null)
        where T : class, new()

    {
        var result = new T();
        if (sectionName != null)
        {

            config.GetSection(sectionName).Bind(result);

        }
        else
        {
            config.Bind(result);
        }
        return result;
    }
}