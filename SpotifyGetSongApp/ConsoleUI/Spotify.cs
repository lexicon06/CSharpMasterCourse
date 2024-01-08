using System;
using System.Diagnostics;

namespace ConsoleUI
{
    class Spotify
    {
        public String Song
        {
            get
            {
                Process[] ps = Process.GetProcessesByName("Spotify");

                foreach (Process p in ps)
                {
                    if (!p.MainWindowTitle.Equals("") && p.MainWindowTitle.Contains("-"))
                    {
                        // string fullSong = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.MainWindowTitle);
                        string fullSong = p.MainWindowTitle;
                        return fullSong;
                    }
                }

                return string.Empty;
            }
        }
    }
}