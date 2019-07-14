using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Models.NavigationPanel;
using torrentLauncher.ViewModels.NavigationPanel;

namespace torrentLauncher.DataStorage
{
    public static class NavigationMenuViewModels
    {
        public static List<NavigationMenuGroupViewModel> Groups { get; set; }

        static NavigationMenuViewModels()
        {
            var game = new NavigationMenuItemModel("Games", PackIconKind.GamepadVariant);
            var emulators = new NavigationMenuItemModel("Emulators", PackIconKind.SpaceInvaders);

            var gameGroup = new NavigationMenuGroupModel("Play", null, new List<NavigationMenuItemViewModel> {
                new NavigationMenuItemViewModel(game),
                new NavigationMenuItemViewModel(emulators)
            });

            var film = new NavigationMenuItemModel("Films", PackIconKind.Filmstrip);
            var serials = new NavigationMenuItemModel("Serials", PackIconKind.Film);

            var moviesGroup = new NavigationMenuGroupModel("Movies", null, new List<NavigationMenuItemViewModel> {
                new NavigationMenuItemViewModel(film),
                new NavigationMenuItemViewModel(serials),
            });

            Groups = new List<NavigationMenuGroupViewModel> {
                new NavigationMenuGroupViewModel(gameGroup),
                new NavigationMenuGroupViewModel(moviesGroup)
            };
        }
    }
}
