using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.DirectX.AudioVideoPlayback;

namespace DS_Timer
{
	public class SoundManager
	{
		[DllImport("winmm.dll")]
		public static extern void PlaySound(string filename, int module, int flags);
		public const int SND_SYNC = 0x0000;
		public const int SND_ASYNC = 0x0001;
		public const int SND_LOOP = 0x0008;


		private Audio m_audio;

		/*
			if (cbSoundTick.Checked && now.Millisecond < 50)
			{
				// Sound in Thread
				//PlaySound(Path.Combine(Application.ExecutablePath, "\\sounds\\tada.wav"), 0, SND_SYNC);
			}
			*/
	}
}
