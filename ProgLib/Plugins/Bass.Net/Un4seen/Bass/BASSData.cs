﻿using System;

namespace Un4seen.Bass
{
	[Flags]
	public enum BASSData
	{
		BASS_DATA_AVAILABLE = 0,
		BASS_DATA_FFT_INDIVIDUAL = 16,
		BASS_DATA_FFT_NOWINDOW = 32,
		BASS_DATA_FFT_REMOVEDC = 64,
		BASS_DATA_FFT_COMPLEX = 128,
		BASS_DATA_FIXED = 536870912,
		BASS_DATA_FLOAT = 1073741824,
		BASS_DATA_FFT256 = -2147483648,
		BASS_DATA_FFT512 = -2147483647,
		BASS_DATA_FFT1024 = -2147483646,
		BASS_DATA_FFT2048 = -2147483645,
		BASS_DATA_FFT4096 = -2147483644,
		BASS_DATA_FFT8192 = -2147483643,
		BASS_DATA_FFT16384 = -2147483642,
		BASS_DATA_FFT32768 = -2147483641
	}
}
