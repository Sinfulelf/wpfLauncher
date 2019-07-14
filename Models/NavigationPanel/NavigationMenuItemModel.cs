using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;

namespace torrentLauncher.Models.NavigationPanel
{
    public class NavigationMenuItemModel
    {
        public NavigationMenuItemModel(string title, PackIconKind kind)
        {
            Title = title;
            Kind = kind;
        }

        public string Title { get; set; }

        public PackIconKind Kind { get; set; }
    }
}
