
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
		/// [GL] Value of GL_BUFFER_OBJECT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int BUFFER_OBJECT_APPLE = 0x85B3;

		/// <summary>
		/// [GL] Value of GL_RELEASED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int RELEASED_APPLE = 0x8A19;

		/// <summary>
		/// [GL] Value of GL_VOLATILE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int VOLATILE_APPLE = 0x8A1A;

		/// <summary>
		/// [GL] Value of GL_RETAINED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int RETAINED_APPLE = 0x8A1B;

		/// <summary>
		/// [GL] Value of GL_UNDEFINED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int UNDEFINED_APPLE = 0x8A1C;

		/// <summary>
		/// [GL] Value of GL_PURGEABLE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int PURGEABLE_APPLE = 0x8A1D;

		/// <summary>
		/// [GL] Binding for glObjectPurgeableAPPLE.
		/// </summary>
		/// <param name="objectType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="option">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public static Int32 ObjectPurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglObjectPurgeableAPPLE != null, "pglObjectPurgeableAPPLE not implemented");
			retValue = Delegates.pglObjectPurgeableAPPLE(objectType, name, option);
			LogCommand("glObjectPurgeableAPPLE", retValue, objectType, name, option			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] Binding for glObjectUnpurgeableAPPLE.
		/// </summary>
		/// <param name="objectType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="option">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public static Int32 ObjectUnpurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglObjectUnpurgeableAPPLE != null, "pglObjectUnpurgeableAPPLE not implemented");
			retValue = Delegates.pglObjectUnpurgeableAPPLE(objectType, name, option);
			LogCommand("glObjectUnpurgeableAPPLE", retValue, objectType, name, option			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] Binding for glGetObjectParameterivAPPLE.
		/// </summary>
		/// <param name="objectType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public static void GetObjectParameterAPPLE(Int32 objectType, UInt32 name, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterivAPPLE != null, "pglGetObjectParameterivAPPLE not implemented");
					Delegates.pglGetObjectParameterivAPPLE(objectType, name, pname, p_params);
					LogCommand("glGetObjectParameterivAPPLE", null, objectType, name, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glObjectPurgeableAPPLE", ExactSpelling = true)]
			internal extern static Int32 glObjectPurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glObjectUnpurgeableAPPLE", ExactSpelling = true)]
			internal extern static Int32 glObjectUnpurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetObjectParameterivAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectParameterivAPPLE(Int32 objectType, UInt32 name, Int32 pname, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_object_purgeable")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate Int32 glObjectPurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option);

			[RequiredByFeature("GL_APPLE_object_purgeable")]
			[ThreadStatic]
			internal static glObjectPurgeableAPPLE pglObjectPurgeableAPPLE;

			[RequiredByFeature("GL_APPLE_object_purgeable")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate Int32 glObjectUnpurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option);

			[RequiredByFeature("GL_APPLE_object_purgeable")]
			[ThreadStatic]
			internal static glObjectUnpurgeableAPPLE pglObjectUnpurgeableAPPLE;

			[RequiredByFeature("GL_APPLE_object_purgeable")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetObjectParameterivAPPLE(Int32 objectType, UInt32 name, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_APPLE_object_purgeable")]
			[ThreadStatic]
			internal static glGetObjectParameterivAPPLE pglGetObjectParameterivAPPLE;

		}
	}

}
