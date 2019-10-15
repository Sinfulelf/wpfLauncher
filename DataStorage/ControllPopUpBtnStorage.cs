using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Models.TitlelBar;
using torrentLauncher.ViewModels.TitlelBar;

namespace torrentLauncher.DataStorage
{
    public static class ControllPopUpBtnStorage
    {
        public static List<ControlPopUpRowItemViewModel> Buttons { get; set; }

        static ControllPopUpBtnStorage()
        {
            Buttons = new List<ControlPopUpRowItemViewModel>() {
                new ControlPopUpRowItemViewModel(new ControlPopUpRowItemModel("View Account", PackIconKind.AccountSettings, TitleBarButtons.ViewAccount, Routing.GeneralRoutingEnum.ViewAccount)),
                new ControlPopUpRowItemViewModel(new ControlPopUpRowItemModel("Settings", PackIconKind.SettingsOutline, TitleBarButtons.Settings)),
                new ControlPopUpRowItemViewModel(new ControlPopUpRowItemModel("Source Repository", PackIconKind.GithubCircle, TitleBarButtons.SourceRepository)),
                new ControlPopUpRowItemViewModel(new ControlPopUpRowItemModel("Info", PackIconKind.InformationVariant, TitleBarButtons.Info)),
                new ControlPopUpRowItemViewModel(new ControlPopUpRowItemModel("LogOut", PackIconKind.Logout, TitleBarButtons.LogOut, Routing.GeneralRoutingEnum.LogOut))
            };
        }
    }
}
