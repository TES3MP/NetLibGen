using System.Runtime.CompilerServices;

namespace TES3MPSharp
{
    public static partial class TES3MP
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void MakePublic(object callback, string name);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern object CallPublic(string name, params object[] args);
    }
}
