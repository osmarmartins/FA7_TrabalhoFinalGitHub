using SQLite.Net.Interop;

namespace TrabalhoFinalGitHub.Utilities
{
    public interface IConfigPlatform
    {
        string PathDB { get; }
        ISQLitePlatform PlatformDB { get; }
    }
}
