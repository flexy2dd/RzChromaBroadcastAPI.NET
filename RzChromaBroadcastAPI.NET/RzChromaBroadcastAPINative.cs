using System;
using System.Runtime.InteropServices;

namespace Razer.Chroma.Broadcast
{
    internal class RzChromaBroadcastAPINative
    {
        [DllImport("RzChromaBroadcastAPI.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern RzResult Init(uint a, uint b, uint c, uint d);

        [DllImport("RzChromaBroadcastAPI.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern RzResult UnInit();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int RegisterEventNotificationCallback(int message, IntPtr data);

        [DllImport("RzChromaBroadcastAPI.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern RzResult RegisterEventNotification(RegisterEventNotificationCallback callback);

        [DllImport("RzChromaBroadcastAPI.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern RzResult UnRegisterEventNotification();
    }
}
