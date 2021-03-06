
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] Binding for glGetDriverControlsQCOM.
		/// </summary>
		/// <param name="num">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="driverControls">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
		public static void GetDriverControlsQCOM([Out] Int32[] num, [Out] UInt32[] driverControls)
		{
			unsafe {
				fixed (Int32* p_num = num)
				fixed (UInt32* p_driverControls = driverControls)
				{
					Debug.Assert(Delegates.pglGetDriverControlsQCOM != null, "pglGetDriverControlsQCOM not implemented");
					Delegates.pglGetDriverControlsQCOM(p_num, (Int32)driverControls.Length, p_driverControls);
					LogCommand("glGetDriverControlsQCOM", null, num, driverControls.Length, driverControls					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetDriverControlStringQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="driverControlString">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
		public static void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [Out] Int32[] length, [Out] StringBuilder driverControlString)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglGetDriverControlStringQCOM != null, "pglGetDriverControlStringQCOM not implemented");
					Delegates.pglGetDriverControlStringQCOM(driverControl, bufSize, p_length, driverControlString);
					LogCommand("glGetDriverControlStringQCOM", null, driverControl, bufSize, length, driverControlString					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glEnableDriverControlQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
		public static void EnableDriverControlQCOM(UInt32 driverControl)
		{
			Debug.Assert(Delegates.pglEnableDriverControlQCOM != null, "pglEnableDriverControlQCOM not implemented");
			Delegates.pglEnableDriverControlQCOM(driverControl);
			LogCommand("glEnableDriverControlQCOM", null, driverControl			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glDisableDriverControlQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
		public static void DisableDriverControlQCOM(UInt32 driverControl)
		{
			Debug.Assert(Delegates.pglDisableDriverControlQCOM != null, "pglDisableDriverControlQCOM not implemented");
			Delegates.pglDisableDriverControlQCOM(driverControl);
			LogCommand("glDisableDriverControlQCOM", null, driverControl			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetDriverControlsQCOM", ExactSpelling = true)]
			internal extern static unsafe void glGetDriverControlsQCOM(Int32* num, Int32 size, UInt32* driverControls);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetDriverControlStringQCOM", ExactSpelling = true)]
			internal extern static unsafe void glGetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, Int32* length, String driverControlString);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glEnableDriverControlQCOM", ExactSpelling = true)]
			internal extern static void glEnableDriverControlQCOM(UInt32 driverControl);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDisableDriverControlQCOM", ExactSpelling = true)]
			internal extern static void glDisableDriverControlQCOM(UInt32 driverControl);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetDriverControlsQCOM(Int32* num, Int32 size, UInt32* driverControls);

			[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glGetDriverControlsQCOM pglGetDriverControlsQCOM;

			[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, Int32* length, [Out] StringBuilder driverControlString);

			[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glGetDriverControlStringQCOM pglGetDriverControlStringQCOM;

			[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glEnableDriverControlQCOM(UInt32 driverControl);

			[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glEnableDriverControlQCOM pglEnableDriverControlQCOM;

			[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glDisableDriverControlQCOM(UInt32 driverControl);

			[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glDisableDriverControlQCOM pglDisableDriverControlQCOM;

		}
	}

}
