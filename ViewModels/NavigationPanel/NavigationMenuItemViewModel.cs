using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Media;
using torrentLauncher.Commands;
using torrentLauncher.Models.NavigationPanel;
using torrentLauncher.ViewModels;

namespace torrentLauncher.ViewModels.NavigationPanel
{
    public class NavigationMenuItemViewModel : BasicNotifyPropertyChanged
    {
        private bool isHovered;
        private bool isSelected;

        private GeneralCommand hoverNavigationMenuItemCommand;
        private GeneralCommand unHoverNavigationMenuItemCommand;

        private GeneralCommand selectNavigationMenuItemCommand;
        private GeneralCommand unSelectNavigationMenuItemCommand;

        public NavigationMenuItemViewModel(NavigationMenuItemModel model)
        {
            ItemModel = model;
        }

        public NavigationMenuItemModel ItemModel { get; protected set; }

        public GeneralCommand HoverNavigationMenuItemCommand
        {
            get
            {
                return hoverNavigationMenuItemCommand ??
                  (hoverNavigationMenuItemCommand = new GeneralCommand(obj =>
                  {
                      IsHovered = true;
                  }));
            }
        }
        public GeneralCommand UnHoverNavigationMenuItemCommand
        {
            get
            {
                return unHoverNavigationMenuItemCommand ??
                  (unHoverNavigationMenuItemCommand = new GeneralCommand(obj =>
                  {
                      IsHovered = false;
                  }));
            }
        }

        public Boolean IsHovered
        {
            get => isHovered;
            set
            {
                isHovered = value;
                OnPropertyChanged("IsHovered");
            }
        }

        public Boolean IsSelected
        {
            get => isSelected;
            set
            {
                isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }
    }
}
