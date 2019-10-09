using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using torrentLauncher.StateStorage;

namespace torrentLauncher.ViewModels.RootDialog
{
    class RootDialogWrapperViewModel : BasicNotifyPropertyChanged
    {
        private TitleBarButtons buttonCaller { get; set; }

        public RootDialogWrapperViewModel(TitleBarButtons _buttonCaller)
        {
            buttonCaller = _buttonCaller;
        }
    }
}
