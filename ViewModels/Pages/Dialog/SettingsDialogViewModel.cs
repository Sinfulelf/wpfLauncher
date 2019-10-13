using System;
using System.Linq;
using torrentLauncher.Commands;
using torrentLauncher.Converters;
using torrentLauncher.DataStorage;
using torrentLauncher.Enums;

namespace torrentLauncher.ViewModels.Pages.Dialog
{
    public class SettingsDialogViewModel : BasicNotifyPropertyChanged
    {
        private GeneralCommand snackbarUndoCommand;

        private bool snackbarShow;
        public Boolean SnackbarShow
        {
            get => snackbarShow;
            set
            {
                if (snackbarShow != value)
                {
                    snackbarShow = value;

                    if (!snackbarShow)
                    {
                        snackbarUndoCommand = null;
                    }

                    OnPropertyChanged("SnackbarShow");
                }
            }
        }

        private string snackbarMessage;
        public String SnackbarMessage
        {
            get => snackbarMessage;
            set
            {
                if (snackbarMessage != value)
                {
                    snackbarMessage = value;
                    OnPropertyChanged("SnackbarMessage");
                }
            }
        }

        private SettingNavigationItems selectedSetting = SettingNavigationItems.Window;
        public SettingNavigationItems SelectedSetting {
            get => selectedSetting;
            set {
                if (selectedSetting != value)
                {
                    selectedSetting = value;
                    OnPropertyChanged("SelectedSetting");
                }
            }
        }

        private GeneralCommand clickNavigationSettingMenuButton;
        public GeneralCommand ClickNavigationSettingMenuButtonCommand
        {
            get
            {
                return clickNavigationSettingMenuButton ??
                  (clickNavigationSettingMenuButton = new GeneralCommand(buttonObj =>
                  {
                      if (buttonObj is SettingNavigationItems)
                      {
                          SelectedSetting = (SettingNavigationItems)buttonObj;
                      }
                  }));
            }
        }
    }
}
