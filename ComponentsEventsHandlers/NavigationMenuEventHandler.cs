using System;
using System.Collections.Generic;
using System.Text;
using torrentLauncher.Enums;
using torrentLauncher.Routing;

namespace torrentLauncher.ComponentsEventsHandlers
{
    public class NavigationMenuEventHandler
    {
        private static NavigationMenuEventHandler instance;
        private NavigationMenuEventHandler() { }
        public static NavigationMenuEventHandler Instance
        {
            get
            {
                if (instance == null)
                    instance = new NavigationMenuEventHandler();
                return instance;
            }
        }

        public void ClickHandler(NavigationButtons button)
        {
            var t = button;
            /*switch (button)
            {
                
            }*/
        }
    }
}
