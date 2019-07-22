using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Routing;

namespace torrentLauncher.Models.NavigationPanel
{
    public class NavigationMenuItemModel
    {
        public NavigationMenuItemModel(string title, PackIconKind kind, RoutingEnum route)
        {
            Title = title;
            Kind = kind;
            Route = route;
        }

        public string Title { get; set; }

        public PackIconKind Kind { get; set; }

        public RoutingEnum Route { get; set; }
    }
}
