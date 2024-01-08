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
                        return p.MainWindowTitle;
                    }
                }

                return string.Empty;
            }
        }
    }
}