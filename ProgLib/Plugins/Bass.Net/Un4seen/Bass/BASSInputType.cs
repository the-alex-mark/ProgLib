﻿using System;

namespace Un4seen.Bass
{
	[Flags]
	public enum BASSInputType
	{
		BASS_INPUT_TYPE_ERROR = -1,
		BASS_INPUT_TYPE_MASK = -16777216,
		BASS_INPUT_TYPE_UNDEF = 0,
		BASS_INPUT_TYPE_DIGITAL = 16777216,
		BASS_INPUT_TYPE_LINE = 33554432,
		BASS_INPUT_TYPE_MIC = 50331648,
		BASS_INPUT_TYPE_SYNTH = 67108864,
		BASS_INPUT_TYPE_CD = 83886080,
		BASS_INPUT_TYPE_PHONE = 100663296,
		BASS_INPUT_TYPE_SPEAKER = 117440512,
		BASS_INPUT_TYPE_WAVE = 134217728,
		BASS_INPUT_TYPE_AUX = 150994944,
		BASS_INPUT_TYPE_ANALOG = 167772160
	}
}