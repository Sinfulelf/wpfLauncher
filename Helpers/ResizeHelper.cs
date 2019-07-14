using System;
using System.Collections.Generic;
using System.Text;

namespace torrentLauncher.Helpers
{
    public static class ResizeHelper
    {
        public static WindowSizeType GetSizeType(double width)
        {
            switch (width)
            {
                case var w when (w < 576):
                    return WindowSizeType.ExtraSmall;
                case var w when (w >= 576 && w < 768):
                    return WindowSizeType.Small;
                case var w when (w >= 768 && w < 992):
                    return WindowSizeType.Medium;
                case var w when (w >= 992 && w < 1200):
                    return WindowSizeType.Large;
                case var w when (w >= 1200):
                    return WindowSizeType.ExtraLarge;
                default:
                    return WindowSizeType.None;
            }
        }
    }
}
