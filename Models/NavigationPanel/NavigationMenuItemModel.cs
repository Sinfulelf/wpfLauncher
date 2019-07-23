using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Enums;
using torrentLauncher.Routing;

namespace torrentLauncher.Models.NavigationPanel
{
    public class NavigationMenuItemModel
    {
        public NavigationMenuItemModel(string title, PackIconKind kind, NavigationButtons button)
        {
            Title = title;
            Kind = kind;
            Button = button;
        }

        public string Title { get; private set; }

        public PackIconKind Kind { get; private set; }

        public NavigationButtons Button { get; private set; }
    }
}
