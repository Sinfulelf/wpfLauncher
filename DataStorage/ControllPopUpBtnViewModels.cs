﻿using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Models.TitlelBar;
using torrentLauncher.ViewModels.TitlelBar;

namespace torrentLauncher.DataStorage
{
    public static class ControllPopUpBtnViewModels
    {
        public static List<ControlPopUpRowItemViewModel> Buttons { get; set; }

        static ControllPopUpBtnViewModels()
        {
            Buttons = new List<ControlPopUpRowItemViewModel>() {
                new ControlPopUpRowItemViewModel(new ControlPopUpRowItemModel("View Account", PackIconKind.AccountSettings, TitleBarButtons.ViewAccount)),
                new ControlPopUpRowItemViewModel(new ControlPopUpRowItemModel("Settings", PackIconKind.SettingsOutline, TitleBarButtons.Settings)),
                new ControlPopUpRowItemViewModel(new ControlPopUpRowItemModel("My Twitter", PackIconKind.Twitter, TitleBarButtons.MyTwitter)),
                new ControlPopUpRowItemViewModel(new ControlPopUpRowItemModel("LogOut", PackIconKind.Logout, TitleBarButtons.LogOut))
            };
        }
    }
}
