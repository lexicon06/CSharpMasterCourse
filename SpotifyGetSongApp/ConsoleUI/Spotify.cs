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

                if (ps.Length > 0)
                {
                    foreach (Process p in ps)
                    {
                        string song = p.MainWindowTitle;

                        if (!string.IsNullOrEmpty(song) && song.Contains("-") && !song.Contains("SPOTIFY"))
                        {//added SPOTIFY just in case of adverts, could be
                            return song;
                        }
                    }
                }

                return string.Empty;
            }
        }
    }
}