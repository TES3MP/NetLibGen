using System;
using System.Runtime.CompilerServices;
﻿using System.Runtime.InteropServices;


namespace TES3MPSharp
{
    public static partial class TES3MP
    {
        public static int CreateTimer(object callback, int msec)
        {
            return CreateTimerEx(callback, msec, "");
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern int CreateTimerEx(object callback, int msec, string types, params object[] args);


        [DllImport("__Internal", CharSet = CharSet.Ansi)]
        public static extern void StartTimer(int timerId);

        [DllImport("__Internal", CharSet = CharSet.Ansi)]
        public static extern void StopTimer(int timerId);

        [DllImport("__Internal", CharSet = CharSet.Ansi)]
        public static extern void RestartTimer(int timerId, int msec);

        [DllImport("__Internal", CharSet = CharSet.Ansi)]
        public static extern void FreeTimer(int timerId);

        [DllImport("__Internal", CharSet = CharSet.Ansi)]
        public static extern bool IsTimerElapsed(int timerId);
    }
}
