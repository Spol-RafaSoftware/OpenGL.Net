
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Value of GLX_DEVICE_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_capture")]
		public const int DEVICE_ID_NV = 0x20CD;

		/// <summary>
		/// [GLX] Value of GLX_UNIQUE_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_capture")]
		public const int UNIQUE_ID_NV = 0x20CE;

		/// <summary>
		/// [GLX] Value of GLX_NUM_VIDEO_CAPTURE_SLOTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_capture")]
		public const int NUM_VIDEO_CAPTURE_SLOTS_NV = 0x20CF;

		/// <summary>
		/// [GLX] Binding for glXBindVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_capture")]
		public static int BindVideoCaptureDeviceNV(IntPtr dpy, UInt32 video_capture_slot, IntPtr device)
		{
			int retValue;

			Debug.Assert(Delegates.pglXBindVideoCaptureDeviceNV != null, "pglXBindVideoCaptureDeviceNV not implemented");
			retValue = Delegates.pglXBindVideoCaptureDeviceNV(dpy, video_capture_slot, device);
			LogCommand("glXBindVideoCaptureDeviceNV", retValue, dpy, video_capture_slot, device			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXEnumerateVideoCaptureDevicesNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="nelements">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_capture")]
		public static IntPtr EnumerateVideoCaptureDevicesNV(IntPtr dpy, int screen, int[] nelements)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_nelements = nelements)
				{
					Debug.Assert(Delegates.pglXEnumerateVideoCaptureDevicesNV != null, "pglXEnumerateVideoCaptureDevicesNV not implemented");
					retValue = Delegates.pglXEnumerateVideoCaptureDevicesNV(dpy, screen, p_nelements);
					LogCommand("glXEnumerateVideoCaptureDevicesNV", retValue, dpy, screen, nelements					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXLockVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_capture")]
		public static void LockVideoCaptureDeviceNV(IntPtr dpy, IntPtr device)
		{
			Debug.Assert(Delegates.pglXLockVideoCaptureDeviceNV != null, "pglXLockVideoCaptureDeviceNV not implemented");
			Delegates.pglXLockVideoCaptureDeviceNV(dpy, device);
			LogCommand("glXLockVideoCaptureDeviceNV", null, dpy, device			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLX] Binding for glXQueryVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_capture")]
		public static int QueryVideoCaptureDeviceNV(IntPtr dpy, IntPtr device, int attribute, int[] value)
		{
			int retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pglXQueryVideoCaptureDeviceNV != null, "pglXQueryVideoCaptureDeviceNV not implemented");
					retValue = Delegates.pglXQueryVideoCaptureDeviceNV(dpy, device, attribute, p_value);
					LogCommand("glXQueryVideoCaptureDeviceNV", retValue, dpy, device, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXReleaseVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_capture")]
		public static void ReleaseVideoCaptureDeviceNV(IntPtr dpy, IntPtr device)
		{
			Debug.Assert(Delegates.pglXReleaseVideoCaptureDeviceNV != null, "pglXReleaseVideoCaptureDeviceNV not implemented");
			Delegates.pglXReleaseVideoCaptureDeviceNV(dpy, device);
			LogCommand("glXReleaseVideoCaptureDeviceNV", null, dpy, device			);
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXBindVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXBindVideoCaptureDeviceNV(IntPtr dpy, UInt32 video_capture_slot, IntPtr device);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXEnumerateVideoCaptureDevicesNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXEnumerateVideoCaptureDevicesNV(IntPtr dpy, int screen, int* nelements);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXLockVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe void glXLockVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXQueryVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXQueryVideoCaptureDeviceNV(IntPtr dpy, IntPtr device, int attribute, int* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXReleaseVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe void glXReleaseVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_NV_video_capture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int glXBindVideoCaptureDeviceNV(IntPtr dpy, UInt32 video_capture_slot, IntPtr device);

			[RequiredByFeature("GLX_NV_video_capture")]
			internal static glXBindVideoCaptureDeviceNV pglXBindVideoCaptureDeviceNV;

			[RequiredByFeature("GLX_NV_video_capture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glXEnumerateVideoCaptureDevicesNV(IntPtr dpy, int screen, int* nelements);

			[RequiredByFeature("GLX_NV_video_capture")]
			internal static glXEnumerateVideoCaptureDevicesNV pglXEnumerateVideoCaptureDevicesNV;

			[RequiredByFeature("GLX_NV_video_capture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glXLockVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);

			[RequiredByFeature("GLX_NV_video_capture")]
			internal static glXLockVideoCaptureDeviceNV pglXLockVideoCaptureDeviceNV;

			[RequiredByFeature("GLX_NV_video_capture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int glXQueryVideoCaptureDeviceNV(IntPtr dpy, IntPtr device, int attribute, int* value);

			[RequiredByFeature("GLX_NV_video_capture")]
			internal static glXQueryVideoCaptureDeviceNV pglXQueryVideoCaptureDeviceNV;

			[RequiredByFeature("GLX_NV_video_capture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glXReleaseVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);

			[RequiredByFeature("GLX_NV_video_capture")]
			internal static glXReleaseVideoCaptureDeviceNV pglXReleaseVideoCaptureDeviceNV;

		}
	}

}
