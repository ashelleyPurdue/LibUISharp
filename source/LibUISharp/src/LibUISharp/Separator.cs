﻿using LibUISharp.Internal;
using LibUISharp.SafeHandles;
using System;

// uiSeparator
namespace LibUISharp
{
    public class Separator : Control
    {
        public Separator(Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.Horizontal:
                    Handle = new SafeControlHandle(LibuiLibrary.uiNewHorizontalSeparator());
                    break;
                case Orientation.Vertical:
                    Handle = new SafeControlHandle(LibuiLibrary.uiNewVerticalSeparator());
                    break;
                default:
                    throw new ArgumentOutOfRangeException("orientation");
            }
            Orientation = orientation;
        }

        public Orientation Orientation { get; }
    }
}