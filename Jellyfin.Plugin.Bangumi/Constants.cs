using System.Text.Json;

namespace Jellyfin.Plugin.Bangumi;

public static class Constants
{
    public const string ProviderName = "Bangumi";

    public const string PluginName = "Bangumi (Forked)";

    public const string PluginGuid = "1d88c399-c0bb-4cad-81a8-1df8783b79ba";

    public const string Language = "zh";

    public static readonly JsonSerializerOptions JsonSerializerOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
}
