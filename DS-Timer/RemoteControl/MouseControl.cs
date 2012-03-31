using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.RemoteControl
{
	using System.Runtime.InteropServices;
	using System.Drawing;
	using System.Windows.Forms;
	class MouseControl
	{


		private const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
		private const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;
		[DllImport("user32.dll")]
		private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInf);
		public static void MoveMouse(int x, int y)
		{
			Cursor.Position = new Point(x, y);
			
		}

		public static void MouseClick()
		{
			mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);//make left button down
			mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);//make left button up
		}
	}
}
