﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using torrentLauncher.Helpers;

namespace torrentLauncher.StateStorage
{
    class MainWindowState
    {
        #region Constructor
        private static MainWindowState instance;
        private static NavigationPanelState navigationPanel;

        private MainWindowState()
        {
            navigationPanel = NavigationPanelState.Instance;
            
        }

        public static MainWindowState Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainWindowState();
                return instance;
            }
        }
        #endregion

        public delegate void StateChangedHandler(ChangedStateFields filed, object value=null);

        public event StateChangedHandler StateChanged;

        public void ChangeState(ChangedStateFields filed, object value)
        {
            SetObeserversStateChanged();
            switch (filed)
            {
                case ChangedStateFields.NavigationPanel:
                    {
                        navigationPanel.IsOpened = (bool)value;
                    }
                    break;
                case ChangedStateFields.WindowSize:
                    {
                        var size = value as Point?;

                        WindowSize = size.Value;
                        CurrentWindowSize = ResizeHelper.GetSizeType(size.Value.Y);
                    }
                    break;
            }
        }

        #region Fields
        private WindowSizeType currentWindowSize;
        public WindowSizeType CurrentWindowSize
        {
            get => currentWindowSize;
            set
            {
                if (!currentWindowSize.Equals(value))
                {
                    if (value <= WindowSizeType.Medium && 
                        value < currentWindowSize)
                    {
                        navigationPanel.IsOpened = false;
                    }
                    currentWindowSize = value;
                }
            }
        }

        private Point windowSize;
        public Point WindowSize
        {
            get => windowSize;
            set
            {
                windowSize = value;
            }
        }

        #endregion

        private void SetObeserversStateChanged()
        {
            if (navigationPanel.StateChanged == null)
                navigationPanel.StateChanged += StateChanged;
        }
    }
}
