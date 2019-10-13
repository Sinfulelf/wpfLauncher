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

        public GeneralRoutingEnum Route { get; set; }

        public ControlPopUpRowItemModel(string title, PackIconKind kind, TitleBarButtons button, GeneralRoutingEnum route  = GeneralRoutingEnum.None)
        {
            Title = title;
            Kind = kind;
            Button = button;
            Route = route;
        }
    }
}
