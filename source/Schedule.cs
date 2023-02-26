using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace source
{
    internal class Schedule
    {
        public static void StartTimer()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            if (currentCulture.TwoLetterISOLanguageName == "pt")
            {
                Console.WriteLine("Escutando sua música atual");
            }
            else
            {
                Console.WriteLine("Listening your actual song");
            }
            TimerCallback callback = new TimerCallback(Tick);

            Timer stateTimer = new Timer(callback, null, 0, 1000);

            for (; ; )
            {
                Thread.Sleep(100);
            }
        }

        public static void Tick(Object stateInfo)
        { 
            FileIO.CheckFile();
        }

    }
}
