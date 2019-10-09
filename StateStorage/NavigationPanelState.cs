using System;
using System.Collections.Generic;
using System.Text;
using static torrentLauncher.StateStorage.MainWindowState;

namespace torrentLauncher.StateStorage
{
    class NavigationPanelState
    {
        public StateChangedHandler StateChanged;

        #region Constructor
        private static NavigationPanelState instance;

        private NavigationPanelState()
        { }

        public static NavigationPanelState Instance
        {
            get
            {
                if (instance == null)
                    instance = new NavigationPanelState();
                return instance;
            }
        }
        #endregion

        private bool isOpened;
        public Boolean IsOpened
        {
            get => isOpened;
            set
            {
                if (!isOpened.Equals(value))
                {
                    isOpened = value;
                    if (StateChanged != null)
                        StateChanged(ChangedStateFields.NavigationPanel, value);
                }
            }
        }
    }
}
