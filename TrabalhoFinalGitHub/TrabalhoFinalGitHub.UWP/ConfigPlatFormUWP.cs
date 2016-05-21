using SQLite.Net.Interop;
using TrabalhoFinalGitHub.Utilities;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(TrabalhoFinalGitHub.UWP.ConfigPlatformUWP))]

namespace TrabalhoFinalGitHub.UWP
{
    public class ConfigPlatformUWP : IConfigPlatform
    {

        private string pathDB;
        private ISQLitePlatform platFormDB;


        public string PathDB
        {
            get
            {
                if (string.IsNullOrEmpty(pathDB))
                {
                    pathDB = ApplicationData.Current.LocalFolder.Path;
                }
                return pathDB;
            }
        }


        public ISQLitePlatform PlatformDB
        {
            get
            {
                if (platFormDB == null)
                {
                    platFormDB = new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT();
                }
                return platFormDB;
            }
        }

    }
}
