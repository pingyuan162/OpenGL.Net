
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
		/// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_VERTICES_OUT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		public const int GEOMETRY_VERTICES_OUT_ARB = 0x8DDA;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_INPUT_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		public const int GEOMETRY_INPUT_TYPE_ARB = 0x8DDB;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_OUTPUT_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		public const int GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC;

		/// <summary>
		/// [GL] Value of GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB symbol.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;

		/// <summary>
		/// [GL] Value of GL_MAX_VERTEX_VARYING_COMPONENTS_ARB symbol.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_VARYING_COMPONENTS_EXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;

		/// <summary>
		/// [GL] Binding for glFramebufferTextureFaceARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="face">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		[AliasOf("glFramebufferTextureFaceEXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public static void FramebufferTextureFaceARB(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level, TextureTarget face)
		{
			Debug.Assert(Delegates.pglFramebufferTextureFaceARB != null, "pglFramebufferTextureFaceARB not implemented");
			Delegates.pglFramebufferTextureFaceARB((Int32)target, (Int32)attachment, texture, level, (Int32)face);
			LogCommand("glFramebufferTextureFaceARB", null, target, attachment, texture, level, face			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferTextureFaceARB", ExactSpelling = true)]
			internal extern static void glFramebufferTextureFaceARB(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 face);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_geometry_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTextureFaceARB(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 face);

			[AliasOf("glFramebufferTextureFaceARB")]
			[AliasOf("glFramebufferTextureFaceEXT")]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_geometry_program4")]
			[ThreadStatic]
			internal static glFramebufferTextureFaceARB pglFramebufferTextureFaceARB;

		}
	}

}
