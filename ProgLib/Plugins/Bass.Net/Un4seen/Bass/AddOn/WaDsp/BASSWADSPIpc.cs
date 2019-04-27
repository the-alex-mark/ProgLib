﻿using System;

namespace Un4seen.Bass.AddOn.WaDsp
{
	public enum BASSWADSPIpc
	{
		BASS_WADSP_IPC_GETOUTPUTTIME = 105,
		BASS_WADSP_IPC_ISPLAYING = 104,
		BASS_WADSP_IPC_GETVERSION = 0,
		BASS_WADSP_IPC_STARTPLAY = 102,
		BASS_WADSP_IPC_GETINFO = 126,
		BASS_WADSP_IPC_GETLISTLENGTH = 124,
		BASS_WADSP_IPC_GETLISTPOS,
		BASS_WADSP_IPC_GETPLAYLISTFILE = 211,
		BASS_WADSP_IPC_GETPLAYLISTTITLE,
		BASS_WADSP_IPC = 1024
	}
}
