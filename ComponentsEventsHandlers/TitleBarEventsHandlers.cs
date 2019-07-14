using System;
using System.Collections.Generic;
using System.Text;

using Process = System.Diagnostics.Process;

namespace torrentLauncher.ComponentsEventsHandlers
{
    public class TitleBarEventsHandlers
    {
        private static TitleBarEventsHandlers instance;
        private TitleBarEventsHandlers() { }
        public static TitleBarEventsHandlers Instance
        {
            get
            {
                if (instance == null)
                    instance = new TitleBarEventsHandlers();
                return instance;
            }
        }

        public void ClickHandler(TitleBarButtons button)
        {
            switch (button)
            {
                case TitleBarButtons.MyTwitter:
                    myTwitterClick();
                    break;
            }
        }

        private void myTwitterClick()
        {
            Process myProcess = new Process();

            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = @"https://twitter.com/Sinfulelf";
                myProcess.Start();
            }
            catch { }
        }
    }
}
