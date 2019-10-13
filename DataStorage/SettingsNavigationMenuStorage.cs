using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Enums;
using torrentLauncher.Models.Settings;

namespace torrentLauncher.DataStorage
{
    public static class SettingsNavigationMenuStorage
    {
        public static List<SettingNavigationItem> MunuItems { get; set; }

        static SettingsNavigationMenuStorage()
        {
            MunuItems = new List<SettingNavigationItem>() {
                new SettingNavigationItem(SettingNavigationItems.Window),
                new SettingNavigationItem(SettingNavigationItems.Download),
                new SettingNavigationItem(SettingNavigationItems.Folders),
                new SettingNavigationItem(SettingNavigationItems.Films),
                new SettingNavigationItem(SettingNavigationItems.Emulators),
                new SettingNavigationItem(SettingNavigationItems.Games),
                new SettingNavigationItem(SettingNavigationItems.Book)
            };
        }
    }
}
