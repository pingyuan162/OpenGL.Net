
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
		/// [GL] Binding for glMultiModeDrawArraysIBM.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="modestride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
		public static void MultiModeDrawArraysIBM(Int32[] mode, Int32[] first, Int32[] count, Int32 primcount, Int32 modestride)
		{
			unsafe {
				fixed (Int32* p_mode = mode)
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiModeDrawArraysIBM != null, "pglMultiModeDrawArraysIBM not implemented");
					Delegates.pglMultiModeDrawArraysIBM(p_mode, p_first, p_count, primcount, modestride);
					LogCommand("glMultiModeDrawArraysIBM", null, mode, first, count, primcount, modestride					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiModeDrawElementsIBM.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:DrawElementsType"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="modestride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
		public static void MultiModeDrawElementsIBM(Int32[] mode, Int32[] count, DrawElementsType type, IntPtr[] indices, Int32 primcount, Int32 modestride)
		{
			unsafe {
				fixed (Int32* p_mode = mode)
				fixed (Int32* p_count = count)
				fixed (IntPtr* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMultiModeDrawElementsIBM != null, "pglMultiModeDrawElementsIBM not implemented");
					Delegates.pglMultiModeDrawElementsIBM(p_mode, p_count, (Int32)type, p_indices, primcount, modestride);
					LogCommand("glMultiModeDrawElementsIBM", null, mode, count, type, indices, primcount, modestride					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiModeDrawArraysIBM", ExactSpelling = true)]
			internal extern static unsafe void glMultiModeDrawArraysIBM(Int32* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiModeDrawElementsIBM", ExactSpelling = true)]
			internal extern static unsafe void glMultiModeDrawElementsIBM(Int32* mode, Int32* count, Int32 type, IntPtr* indices, Int32 primcount, Int32 modestride);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiModeDrawArraysIBM(Int32* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);

			[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
			[ThreadStatic]
			internal static glMultiModeDrawArraysIBM pglMultiModeDrawArraysIBM;

			[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiModeDrawElementsIBM(Int32* mode, Int32* count, Int32 type, IntPtr* indices, Int32 primcount, Int32 modestride);

			[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
			[ThreadStatic]
			internal static glMultiModeDrawElementsIBM pglMultiModeDrawElementsIBM;

		}
	}

}
