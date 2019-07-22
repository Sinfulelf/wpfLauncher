using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Routing;

namespace torrentLauncher.Models.TitlelBar
{
    public class ControlPopUpRowItemModel
    {
        public string Title { get; set; }

        public PackIconKind Kind { get; set; }

        public TitleBarButtons Button { get; set; }

        public RoutingEnum Route { get; set; }

        public ControlPopUpRowItemModel(string title, PackIconKind kind, TitleBarButtons button, RoutingEnum route  = RoutingEnum.None)
        {
            Title = title;
            Kind = kind;
            Button = button;
            Route = route;
        }
    }
}
