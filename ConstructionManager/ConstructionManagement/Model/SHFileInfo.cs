﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Model
{
    [StructLayout(LayoutKind.Sequential)]
    public class SHFILEINFO
    {
        public IntPtr hIcon;
        public IntPtr iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst =260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst =80)]
        public string szTypeName;
    }
}
