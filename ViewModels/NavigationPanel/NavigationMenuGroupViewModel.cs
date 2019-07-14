using System;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Models.NavigationPanel;

namespace torrentLauncher.ViewModels.NavigationPanel
{
    public class NavigationMenuGroupViewModel
    {
        public NavigationMenuGroupViewModel(NavigationMenuGroupModel model)
        {
            ItemModel = model;
        }

        public NavigationMenuGroupModel ItemModel { get; protected set; }
    }
}
