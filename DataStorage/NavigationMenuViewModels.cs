using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Enums;
using torrentLauncher.Models.NavigationPanel;
using torrentLauncher.Routing;
using torrentLauncher.ViewModels.NavigationPanel;

namespace torrentLauncher.DataStorage
{
    public static class NavigationMenuViewModels
    {
        public static List<NavigationMenuGroupViewModel> Groups { get; set; }

        static NavigationMenuViewModels()
        {
            var game = new NavigationMenuItemModel("Games", PackIconKind.GamepadVariant, NavigationButtons.Games);
            var emulators = new NavigationMenuItemModel("Emulators", PackIconKind.SpaceInvaders, NavigationButtons.Emulators);

            var gameGroup = new NavigationMenuGroupModel("Play", null, new List<NavigationMenuItemViewModel> {
                new NavigationMenuItemViewModel(game),
                new NavigationMenuItemViewModel(emulators)
            });

            var film = new NavigationMenuItemModel("Films", PackIconKind.Filmstrip, NavigationButtons.Films);
            var serials = new NavigationMenuItemModel("Serials", PackIconKind.Film, NavigationButtons.Serials);

            var moviesGroup = new NavigationMenuGroupModel("Movies", null, new List<NavigationMenuItemViewModel> {
                new NavigationMenuItemViewModel(film),
                new NavigationMenuItemViewModel(serials),
            });

            var book = new NavigationMenuItemModel("Book", PackIconKind.BookOpen, NavigationButtons.Book);
            var comics = new NavigationMenuItemModel("Comics", PackIconKind.CityVariant, NavigationButtons.Comics);

            var readGroup = new NavigationMenuGroupModel("Read", null, new List<NavigationMenuItemViewModel> {
                new NavigationMenuItemViewModel(book),
                new NavigationMenuItemViewModel(comics),
            });

            Groups = new List<NavigationMenuGroupViewModel> {
                new NavigationMenuGroupViewModel(gameGroup),
                new NavigationMenuGroupViewModel(moviesGroup),
                new NavigationMenuGroupViewModel(readGroup)
            };
        }
    }
}
