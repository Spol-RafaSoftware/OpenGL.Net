﻿
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Test OpenGL 3.0 API.
	/// </summary>
	[TestFixture]
	[Category("GL_VERSION_3_0")]
	class Gl_VERSION_3_0 : TestBaseGL
	{
		/// <summary>
		/// Test Gl.GetString.
		/// </summary>
		[Test]
		public void TestGetStringi()
		{
			if (!HasVersion(3, 0) && !HasEsVersion(3, 0))
				Assert.Inconclusive("OpenGL 3.0 or OpenGL ES 3.0");

			#region Gl.EXTENSIONS

			int numExtensions;

			Gl.Get(GetPName.NumExtensions, out numExtensions);

			Console.WriteLine("Found {0} GL extensions:", numExtensions);

			for (uint i = 0; i < (uint)numExtensions; i++) {
				string extensionName = Gl.GetString(StringName.Extensions, i);
				Console.WriteLine("- {0}", extensionName);
			}

			#endregion
		}
	}
}
