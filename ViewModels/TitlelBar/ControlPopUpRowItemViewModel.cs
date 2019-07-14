using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;
using torrentLauncher.Models.TitlelBar;

namespace torrentLauncher.ViewModels.TitlelBar
{
    public class ControlPopUpRowItemViewModel : BasicNotifyPropertyChanged
    {
        public ControlPopUpRowItemModel ItemModel { get; protected set; }

        public ControlPopUpRowItemViewModel(ControlPopUpRowItemModel model)
        {
            ItemModel = model;
        }
    }
}
