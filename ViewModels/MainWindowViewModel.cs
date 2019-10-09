using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using torrentLauncher.Commands;
using torrentLauncher.ComponentsEventsHandlers;
using torrentLauncher.Enums;
using torrentLauncher.Helpers;
using torrentLauncher.Routing;
using torrentLauncher.StateStorage;

namespace torrentLauncher.ViewModels
{
    class MainWindowViewModel : BasicNotifyPropertyChanged
    {
        private MainWindowState mainWindowState;
        private TitleBarEventsHandlers titleBarEventsHandlers;
        private NavigationMenuEventHandler navigationMenuEventHandler;
        private bool navigateionPanelState;
        private NavigationButtons selectedNavigationMenuItem = NavigationButtons.Home;

        #region Constructor
        private MainWindowViewModel() {
            mainWindowState = MainWindowState.Instance;
            titleBarEventsHandlers = TitleBarEventsHandlers.Instance;
            navigationMenuEventHandler = NavigationMenuEventHandler.Instance;

            mainWindowState.StateChanged += StateChanged;
        }
        private static MainWindowViewModel instance;        
        public static MainWindowViewModel Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainWindowViewModel();
                return instance;
            }
        }

        #endregion

        private void StateChanged(ChangedStateFields filed, object value)
        {
            switch (filed)
            {
                case ChangedStateFields.NavigationPanel:
                    {
                        NavigateionPanelState = (bool)value;
                    }
                    break;
            };
        }

        public Boolean NavigateionPanelState
        {
            get => navigateionPanelState;
            set
            {
                if (navigateionPanelState != value)
                {
                    navigateionPanelState = value;
                    OnPropertyChanged("NavigateionPanelState");
                }
            }
        }

        public NavigationButtons SelectedNavigationButton
        {
            get => selectedNavigationMenuItem;
            set
            {
                if (selectedNavigationMenuItem != value)
                {
                    selectedNavigationMenuItem = value;
                    OnPropertyChanged("SelectedNavigationButton");
                }
            }
        }

        private GeneralCommand toggleNavigationPanel;
        public GeneralCommand ToggleNavigationPanelCommand
        {
            get
            {
                return toggleNavigationPanel ??
                  (toggleNavigationPanel = new GeneralCommand(obj =>
                  {
                      mainWindowState.ChangeState(ChangedStateFields.NavigationPanel, obj ?? !NavigateionPanelState);
                  }));
            }
        }

        private GeneralCommand resizeMainWindow;
        public GeneralCommand ResizeMainWindowCommand
        {
            get
            {
                return resizeMainWindow ??
                  (resizeMainWindow = new GeneralCommand(mainWindow =>
                  {
                      var window = (mainWindow as Window);
                      var width = window.ActualWidth;
                      var height = window.ActualHeight;
                      mainWindowState.ChangeState(ChangedStateFields.WindowSize, new Point(height, width));
                  }));
            }
        }

        private GeneralCommand clickNavigationMenuButton;
        public GeneralCommand ClickNavigationMenuButtonCommand
        {
            get
            {
                return clickNavigationMenuButton ??
                  (clickNavigationMenuButton = new GeneralCommand(buttonObj =>
                  {
                      if (buttonObj is NavigationButtons)
                      {
                          navigationMenuEventHandler.ClickHandler((NavigationButtons)buttonObj);
                          SelectedNavigationButton = (NavigationButtons)buttonObj;
                      }
                  }));
            }
        }

        private GeneralCommand clickTitleBarButton;
        public GeneralCommand ClickTitleBarButtonCommand
        {
            get
            {
                return clickTitleBarButton ??
                  (clickTitleBarButton = new GeneralCommand(async buttonObj =>
                  {
                      if (buttonObj is TitleBarButtons)
                      {
                          await titleBarEventsHandlers.ClickHandlerAsync((TitleBarButtons)buttonObj);
                      }
                  }));
            }
        }
    }
}
