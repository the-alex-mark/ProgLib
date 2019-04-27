﻿using System;

namespace Un4seen.Bass
{
	[Flags]
	public enum BASSChannelType
	{
		BASS_CTYPE_UNKNOWN = 0,
		BASS_CTYPE_SAMPLE = 1,
		BASS_CTYPE_RECORD = 2,
		BASS_CTYPE_MUSIC_MO3 = 256,
		BASS_CTYPE_STREAM = 65536,
		BASS_CTYPE_STREAM_OGG = 65538,
		BASS_CTYPE_STREAM_MP1 = 65539,
		BASS_CTYPE_STREAM_MP2 = 65540,
		BASS_CTYPE_STREAM_MP3 = 65541,
		BASS_CTYPE_STREAM_AIFF = 65542,
		BASS_CTYPE_STREAM_CA = 65543,
		BASS_CTYPE_STREAM_MF = 65544,
		BASS_CTYPE_STREAM_MIXER = 67584,
		BASS_CTYPE_STREAM_SPLIT = 67585,
		BASS_CTYPE_STREAM_WAV = 262144,
		BASS_CTYPE_STREAM_WAV_PCM = 327681,
		BASS_CTYPE_STREAM_WAV_FLOAT = 327683,
		BASS_CTYPE_MUSIC_MOD = 131072,
		BASS_CTYPE_MUSIC_MTM = 131073,
		BASS_CTYPE_MUSIC_S3M = 131074,
		BASS_CTYPE_MUSIC_XM = 131075,
		BASS_CTYPE_MUSIC_IT = 131076,
		BASS_CTYPE_STREAM_WV = 66816,
		BASS_CTYPE_STREAM_WV_H = 66817,
		BASS_CTYPE_STREAM_WV_L = 66818,
		BASS_CTYPE_STREAM_WV_LH = 66819,
		BASS_CTYPE_STREAM_CD = 66048,
		BASS_CTYPE_STREAM_WMA = 66304,
		BASS_CTYPE_STREAM_WMA_MP3 = 66305,
		BASS_CTYPE_STREAM_FLAC = 67840,
		BASS_CTYPE_STREAM_FLAC_OGG = 67841,
		BASS_CTYPE_STREAM_OFR = 67072,
		BASS_CTYPE_STREAM_APE = 67328,
		BASS_CTYPE_STREAM_MPC = 68096,
		BASS_CTYPE_STREAM_AAC = 68352,
		BASS_CTYPE_STREAM_MP4 = 68353,
		BASS_CTYPE_STREAM_SPX = 68608,
		BASS_CTYPE_STREAM_ALAC = 69120,
		BASS_CTYPE_STREAM_TTA = 69376,
		BASS_CTYPE_STREAM_AC3 = 69632,
		BASS_CTYPE_STREAM_OPUS = 70144,
		BASS_CTYPE_STREAM_WINAMP = 66560,
		BASS_CTYPE_STREAM_DSD = 71424,
		BASS_CTYPE_STREAM_MIDI = 68864,
		BASS_CTYPE_STREAM_ADX = 126976,
		BASS_CTYPE_STREAM_AIX = 126977,
		BASS_CTYPE_STREAM_TEMPO = 127488,
		BASS_CTYPE_STREAM_REVERSE = 127489,
		BASS_CTYPE_STREAM_VIDEO = 69888
	}
}
