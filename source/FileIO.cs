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
        static string path = "C:\\Users\\anton\\Desktop\\Projetos\\music_playing.txt";
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

                Process[] localByName = Process.GetProcessesByName("spotify");
                foreach (Process process in localByName)
                {
                    if (!String.IsNullOrEmpty(process.MainWindowTitle))
                    {
                        sw.WriteLine(process.MainWindowTitle);
                    }
                }
            }
        }

        public static void ReadFile()
        {
            using (StreamWriter sw = File.CreateText(path))
            {

                Process[] localByName = Process.GetProcessesByName("spotify");
                foreach (Process process in localByName)
                {
                    if (!String.IsNullOrEmpty(process.MainWindowTitle))
                    {
                        sw.WriteLine(process.MainWindowTitle);
                    }
                }
            }
        }
    }
}
