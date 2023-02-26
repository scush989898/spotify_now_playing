using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source
{
    public class GetSong
    {
        public static string Song = "Waiting for some music on Spotify...";
        public static string Get()
        {
            Process[] processes = Process.GetProcessesByName("spotify");
            foreach (Process process in processes)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    Song = process.MainWindowTitle;
                }
            }

            return Song;

        }

    }
}
