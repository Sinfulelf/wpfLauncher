using System;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Enums;

namespace torrentLauncher.Models.Settings
{
    public class SettingNavigationItem
    {
        public string Title { get; set; }
        public SettingNavigationItems Item { get; set; }
    }
}
