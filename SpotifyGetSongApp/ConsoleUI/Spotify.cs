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
                        if (!string.IsNullOrEmpty(p.MainWindowTitle) && p.MainWindowTitle.Contains("-"))
                        {
                            return p.MainWindowTitle;
                        }
                    }
                }

                return string.Empty;
            }
        }
    }
}