using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using torrentLauncher.Routing;
using torrentLauncher.ViewControls.RootDialog;
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

        public async Task ClickHandlerAsync(TitleBarButtons button)
        {
            Action closingCallBack = null;

            switch (button)
            {
                case TitleBarButtons.MyTwitter:
                    {
                        myTwitterClick();
                    }
                    break;
                case TitleBarButtons.LogOut:
                    {
                        //LogOut Command
                    }
                    break;
                case TitleBarButtons.Settings:
                    {
                        closingCallBack = RoutingManager.ClearSettingDialogContent;
                    }
                    goto default;
                default:
                    {
                        await DialogHost.Show(new RootDialogWrapper(button), "RootDialog",
                           new DialogClosingEventHandler((object sender, DialogClosingEventArgs args) =>
                           {
                               if (closingCallBack != null)
                                   closingCallBack();
                           })).ConfigureAwait(true);

                    }
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
