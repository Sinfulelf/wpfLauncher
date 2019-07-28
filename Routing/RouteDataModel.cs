using System;
using System.Collections.Generic;
using System.Text;

namespace torrentLauncher.Routing
{
    class RouteDataModel
    {
        public Type ControlType { get; set; }
        public Dictionary<string, object> RouteDataValues { get; set; }
    }
}
