using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using torrentLauncher.Commands;
using torrentLauncher.ComponentsEventsHandlers;
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
                navigateionPanelState = value;
                OnPropertyChanged("NavigateionPanelState");
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
                      var width = (mainWindow as Window).ActualWidth;
                      mainWindowState.ChangeState(ChangedStateFields.WindowSize, ResizeHelper.GetSizeType(width));
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
                      if (buttonObj is RoutingEnum)
                      {
                          navigationMenuEventHandler.ClickHandler((RoutingEnum)buttonObj);
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
                  (clickTitleBarButton = new GeneralCommand(buttonObj =>
                  {
                      if (buttonObj is TitleBarButtons)
                      {
                          titleBarEventsHandlers.ClickHandler((TitleBarButtons)buttonObj);
                      }
                  }));
            }
        }
    }
}
