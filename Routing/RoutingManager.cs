using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Controls;
using System.Windows.Navigation;
using torrentLauncher.Enums;
using torrentLauncher.Pages;
using torrentLauncher.ViewControls.NavigationPanel;
using torrentLauncher.ViewModels.Pages;

namespace torrentLauncher.Routing
{
    public static class RoutingManager
    {
        static bool LoadCompletedAdded;

        public static void SwitchPage(Frame contentFrame, NavigationButtons navigation)
        {
            var navigationService = contentFrame.NavigationService;
            if (!RoutingManager.LoadCompletedAdded)
            {
                navigationService.LoadCompleted += new LoadCompletedEventHandler(NavigationService_LoadCompleted);
                RoutingManager.LoadCompletedAdded = true;
            }

            string uri = null;
            object routeData = null;
            switch (navigation)
            {
                case NavigationButtons.Home:
                    {
                        uri = "Pages/HomePage.xaml";
                    }
                    break;
                case NavigationButtons.Download:
                    {
                        uri = "Pages/DownloadPage.xaml";
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
                case NavigationButtons.Tetris:
                case NavigationButtons.Sokoban:
                case NavigationButtons.Snake:
                    {
                        uri = "Pages/BrickGamesPage.xaml";
                        routeData = new RouteDataModel
                        {
                            ControlType = typeof(BrickGamesPage),
                            RouteDataValues = new Dictionary<string, object>()
                            {
                                { "SelectedNavigationButton", navigation  }
                            }
                        };
                    }
                    break;
            }
            if (uri != null)
            {              
                navigationService.Navigate(new Uri(uri, UriKind.Relative), routeData);
            }
        }

        private static void NavigationService_LoadCompleted(object sender, NavigationEventArgs e)
        {
            if (e.ExtraData != null)
            {
                var routeData = (e.ExtraData as RouteDataModel);
                var routeDataType = routeData.ControlType;
                dynamic targetControl = Convert.ChangeType(e.Content, routeDataType);

                foreach (var keyPair in routeData.RouteDataValues)
                {
                    PropertyInfo propertyInfo = targetControl.GetType().GetProperty(keyPair.Key);
                    propertyInfo.SetValue(targetControl, Convert.ChangeType(keyPair.Value, propertyInfo.PropertyType), null);
                }
            }
        }
    }
}
