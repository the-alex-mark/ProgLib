﻿using System;

namespace Un4seen.Bass.AddOn.Midi
{
	public enum BASSMIDIEvent
	{
		MIDI_EVENT_NONE,
		MIDI_EVENT_NOTE,
		MIDI_EVENT_PROGRAM,
		MIDI_EVENT_CHANPRES,
		MIDI_EVENT_PITCH,
		MIDI_EVENT_PITCHRANGE,
		MIDI_EVENT_DRUMS,
		MIDI_EVENT_FINETUNE,
		MIDI_EVENT_COARSETUNE,
		MIDI_EVENT_MASTERVOL,
		MIDI_EVENT_BANK,
		MIDI_EVENT_MODULATION,
		MIDI_EVENT_VOLUME,
		MIDI_EVENT_PAN,
		MIDI_EVENT_EXPRESSION,
		MIDI_EVENT_SUSTAIN,
		MIDI_EVENT_SOUNDOFF,
		MIDI_EVENT_RESET,
		MIDI_EVENT_NOTESOFF,
		MIDI_EVENT_PORTAMENTO,
		MIDI_EVENT_PORTATIME,
		MIDI_EVENT_PORTANOTE,
		MIDI_EVENT_MODE,
		MIDI_EVENT_REVERB,
		MIDI_EVENT_CHORUS,
		MIDI_EVENT_CUTOFF,
		MIDI_EVENT_RESONANCE,
		MIDI_EVENT_RELEASE,
		MIDI_EVENT_ATTACK,
		MIDI_EVENT_REVERB_MACRO = 30,
		MIDI_EVENT_CHORUS_MACRO,
		MIDI_EVENT_REVERB_TIME,
		MIDI_EVENT_REVERB_DELAY,
		MIDI_EVENT_REVERB_LOCUTOFF,
		MIDI_EVENT_REVERB_HICUTOFF,
		MIDI_EVENT_REVERB_LEVEL,
		MIDI_EVENT_CHORUS_DELAY,
		MIDI_EVENT_CHORUS_DEPTH,
		MIDI_EVENT_CHORUS_RATE,
		MIDI_EVENT_CHORUS_FEEDBACK,
		MIDI_EVENT_CHORUS_LEVEL,
		MIDI_EVENT_CHORUS_REVERB,
		MIDI_EVENT_USERFX,
		MIDI_EVENT_USERFX_LEVEL,
		MIDI_EVENT_USERFX_REVERB,
		MIDI_EVENT_USERFX_CHORUS,
		MIDI_EVENT_DRUM_FINETUNE = 50,
		MIDI_EVENT_DRUM_COARSETUNE,
		MIDI_EVENT_DRUM_PAN,
		MIDI_EVENT_DRUM_REVERB,
		MIDI_EVENT_DRUM_CHORUS,
		MIDI_EVENT_DRUM_CUTOFF,
		MIDI_EVENT_DRUM_RESONANCE,
		MIDI_EVENT_DRUM_LEVEL,
		MIDI_EVENT_DRUM_USERFX,
		MIDI_EVENT_SOFT = 60,
		MIDI_EVENT_SYSTEM,
		MIDI_EVENT_TEMPO,
		MIDI_EVENT_SCALETUNING,
		MIDI_EVENT_CONTROL,
		MIDI_EVENT_CHANPRES_VIBRATO,
		MIDI_EVENT_CHANPRES_PITCH,
		MIDI_EVENT_CHANPRES_FILTER,
		MIDI_EVENT_CHANPRES_VOLUME,
		MIDI_EVENT_MOD_VIBRATO,
		MIDI_EVENT_MODRANGE = 69,
		MIDI_EVENT_BANK_LSB,
		MIDI_EVENT_KEYPRES,
		MIDI_EVENT_KEYPRES_VIBRATO,
		MIDI_EVENT_KEYPRES_PITCH,
		MIDI_EVENT_KEYPRES_FILTER,
		MIDI_EVENT_KEYPRES_VOLUME,
		MIDI_EVENT_SOSTENUTO,
		MIDI_EVENT_MOD_PITCH,
		MIDI_EVENT_MOD_FILTER,
		MIDI_EVENT_MOD_VOLUME,
		MIDI_EVENT_MIXLEVEL = 65536,
		MIDI_EVENT_TRANSPOSE,
		MIDI_EVENT_SYSTEMEX,
		MIDI_EVENT_END_TRACK,
		MIDI_EVENTS_NORSTATUS = 33554432,
		MIDI_EVENT_END = 0
	}
}
