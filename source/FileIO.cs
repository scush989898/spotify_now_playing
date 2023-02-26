using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source
{
    public class FileIO
    {
        private static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"infoSong","music_playing.txt");

        public static void CheckFile()
        {
            if (!File.Exists(path))
            {
                CreateFile();
            }
            if (File.Exists(path))
            {
                ReadFile();
            }
        }

        public static void CreateFile()
        {
            using (StreamWriter sw = File.CreateText(path))
            {

                string SongName = GetSong.Get();
                sw.WriteLine(SongName);
            }
        }

        public static void ReadFile()
        {
            using (StreamWriter sw = File.CreateText(path))
            {

                string SongName = GetSong.Get()+ ".  ";
                sw.WriteLine(SongName);
            }
        }
    }
}
