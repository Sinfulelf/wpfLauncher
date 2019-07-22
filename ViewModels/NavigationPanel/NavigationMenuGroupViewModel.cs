using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
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

        private ICommand _clickNavigationMenuButtonCommand;
        public ICommand ClickNavigationMenuButtonCommand {
            get => _clickNavigationMenuButtonCommand;
            set
            {
                _clickNavigationMenuButtonCommand = value;
            }
        }
    }
}
