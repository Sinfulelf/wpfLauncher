using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using torrentLauncher.Enums;

namespace torrentLauncher.Routing
{
    public class RoutingManager
    {
        public static void SwitchPage(Frame contentFrame, NavigationButtons navigation)
        {
            string uri = null;
            switch (navigation)
            {
                case NavigationButtons.Home:
                    {
                        uri = "Pages/HomePage.xaml";
                    }
                    break;
                case NavigationButtons.Games:
                    {
                        uri = "Pages/GamePage.xaml";
                    }
                    break;
                case NavigationButtons.Emulators:
                    {
                        uri = "Pages/EmulatrorsPage.xaml";
                    }
                    break;
                case NavigationButtons.Films:
                    {
                        uri = "Pages/FilmsPage.xaml";
                    }
                    break;
                case NavigationButtons.Serials:
                    {
                        uri = "Pages/SerialsPage.xaml";
                    }
                    break;
                case NavigationButtons.Book:
                    {
                        uri = "Pages/BookPage.xaml";
                    }
                    break;
                case NavigationButtons.Comics:
                    {
                        uri = "Pages/ComicsPage.xaml";
                    }
                    break;
            }
            if (uri != null)
                contentFrame.NavigationService.Navigate(new Uri(uri, UriKind.Relative));
        }
    }
}
