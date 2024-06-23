using Launcher;
using System.Net;

namespace WPFS4Launcher
{
    internal class Constants
    {
        public static bool KRClient = false;

        public static MainWindow LoginWindow;
        public static IPEndPoint ConnectEndPoint = new IPEndPoint(IPAddress.Parse("156.67.219.144"), 28001);
    }
}
