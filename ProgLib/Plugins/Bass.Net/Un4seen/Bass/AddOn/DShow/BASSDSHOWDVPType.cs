﻿using System;

namespace Un4seen.Bass.AddOn.DShow
{
	[Flags]
	public enum BASSDSHOWDVPType
	{
		BASS_DSHOW_TYPE_RGB24 = 1,
		BASS_DSHOW_TYPE_RGB32 = 2,
		BASS_DSHOW_TYPE_YUYV = 3,
		BASS_DSHOW_TYPE_IYUV = 4,
		BASS_DSHOW_TYPE_YVU9 = 5,
		BASS_DSHOW_TYPE_YV12 = 6,
		BASS_DSHOW_TYPE_NV12 = 7,
		BASS_DSHOW_TYPE_UYVY = 8
	}
}