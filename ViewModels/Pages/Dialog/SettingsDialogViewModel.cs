using System;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Commands;

namespace torrentLauncher.ViewModels.Pages.Dialog
{
    public class SettingsDialogViewModel: BasicNotifyPropertyChanged
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
    }
}
