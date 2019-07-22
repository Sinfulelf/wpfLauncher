using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using torrentLauncher.ViewModels.NavigationPanel;

namespace torrentLauncher.Models.NavigationPanel
{
    public class NavigationMenuGroupModel
    {
        public NavigationMenuGroupModel(string header, PackIconKind? kind,
                                        List<NavigationMenuItemViewModel> items)
        {
            Header = header;
            Kind = kind;
            Items = items;
        }

        public NavigationMenuGroupModel(string header, PackIconKind? kind,
                                        UserControl screen)
        {
            Header = header;
            Kind = kind;
            Screen = screen;
        }

        public string Header { get; private set; }
        public Nullable<PackIconKind> Kind { get; private set; }
        public List<NavigationMenuItemViewModel> Items { get; private set; }
        public UserControl Screen { get; private set; }
    }
}
