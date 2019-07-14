using System;
using System.Collections.Generic;
using System.Text;

namespace torrentLauncher
{
    public enum WindowSizeType
    {
        None = 0,
        ExtraSmall = 1, //<576px
        Small = 2,  // ≥576px && <768px
        Medium = 3, //≥768px && <992px
        Large = 4,  //≥992px && <1200px
        ExtraLarge = 5, //≥1200px
    }
}
