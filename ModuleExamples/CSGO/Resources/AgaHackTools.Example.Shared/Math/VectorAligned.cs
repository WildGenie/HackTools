﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AgaHackTools.Example.Shared.Math
{

    [StructLayout(LayoutKind.Sequential)]
    public struct VectorAligned 
    {
        #region VARIABLES

        public float X;
        public float Y;
        public float Z;
        public float W;

        #endregion
    }
}
