/*----------------------------------------------------------------------------------------

	A-Soft Ingenieurbüro

	Copyright © 1994 - 2007. All Rights reserved.

	Related Copyrights :

			Microsoft .NET Windows Forms V2.0 library.
			Copyright (C) 2004...2006 Microsoft Corporation,
			All rights reserved.


	FILE		:	NativeMethods.cs

	PROJECT		:	A-Soft Library
	SUB			:	Standard Library
 
	SYSTEM		:	Windows-XP, (Windows 2000), C# (.NET 2.0, Visual Studio.NET 2005)

	AUTHOR		:	Joachim Holzhauer
	
	DESCRIPTION	:	Map some definitions from WIN32 native interface
 
	VERSION		:	1.0 - 2006.01.31
 * 
 * 
 *  2010/09/24　アクティブなウィンドウのキャプチャ処理を追加した。

----------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ASFTBase
{
	/// <summary>
	/// Helper class which maps some WIN32 values
	/// </summary>
	[System.Security.SuppressUnmanagedCodeSecurity()]
	[System.Runtime.InteropServices.ComVisible( false )]
	internal sealed class NativeMethods
	{
		private NativeMethods() { }

		#region RECT structure

		[StructLayout( LayoutKind.Sequential )]
		internal struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;

			public RECT( int left, int top, int right, int bottom )
			{
				this.left = left;
				this.top = top;
				this.right = right;
				this.bottom = bottom;
			}

			public Rectangle Rect 
			{ 
				get { return new Rectangle( this.left, this.top, this.right - this.left, this.bottom - this.top ); } 
			}

			public static RECT FromXYWH( int x, int y, int width, int height )
			{
				return new RECT( x, y, x + width, y + height );
			}

			public static RECT FromRectangle( Rectangle rect )
			{
				return new RECT( rect.Left, rect.Top, rect.Right, rect.Bottom );
			}
		}

		#endregion RECT structure

		/// <summary>
		/// Get a windows rectangle in a RECT structure
		/// </summary>
		/// <param name="hwnd">The window handle to look up</param>
		/// <param name="rect">The rectangle</param>
		/// <returns></returns>
		[DllImport( "user32.dll", ExactSpelling = true, CharSet = CharSet.Auto )]
		public static extern bool GetWindowRect( IntPtr hwnd, out RECT rect );

		/// <summary>
		/// The BringWindowToTop function brings the specified window to the top of the Z order. 
		/// If the window is a top-level window, it is activated. 
		/// If the window is a child window, the top-level parent window associated 
		/// with the child window is activated. 
		/// </summary>
		/// <param name="hWnd">Handle to the window to bring to the top of the Z order. </param>
		/// <returns>If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. 
		/// To get extended error information, call GetLastError. 
		/// </returns>
		[DllImport( "user32.dll", ExactSpelling = true, CharSet = CharSet.Auto )]
		public static extern bool BringWindowToTop( IntPtr hWnd );

        // insert start 2010/09/24 Ishibashi-t@ss
        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowDC(IntPtr hwnd);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("gdi32.dll")]
        private static extern int BitBlt(IntPtr hDestDC,
            int x,
            int y,
            int nWidth,
            int nHeight,
            IntPtr hSrcDC,
            int xSrc,
            int ySrc,
            int dwRop);

        [DllImport("user32.dll")]
        private static extern IntPtr ReleaseDC(IntPtr hwnd, IntPtr hdc);

        private const int SRCCOPY = 0xCC0020;
        //アクティブなウィンドウのキャプチャ処理
        public static Bitmap CaptureActiveWindow()
        {
            IntPtr hWnd = GetForegroundWindow();
            IntPtr winDC = GetWindowDC(hWnd);

            RECT rect = new RECT();
            GetWindowRect(hWnd, out rect);

            Bitmap bmp = new Bitmap(rect.right - rect.left,
                                    rect.bottom - rect.top);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                IntPtr hDC = g.GetHdc();
                BitBlt(hDC, 0, 0, bmp.Width, bmp.Height, winDC, 0, 0, SRCCOPY);
                g.ReleaseHdc(hDC);
            }
            ReleaseDC(hWnd, winDC);

            return bmp;
        }
        // insert end 2010/09/24 Ishibashi-t@ss

		/// <summary>
		/// Get a windows rectangle in a .NET structure
		/// </summary>
		/// <param name="hwnd">The window handle to look up</param>
		/// <returns>The rectangle</returns>
        public static Rectangle GetWindowRect(IntPtr hwnd)
        {
            RECT rect = new RECT();
            GetWindowRect(hwnd, out rect);
            return rect.Rect;
        }

    }

}
