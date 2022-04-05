using System;
using System.Runtime.InteropServices;

namespace iiInfinityEngine.Core.Binary
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct DlgHeaderBinary
    {
        public array4 ftype;
        public array4 fversion;
        public Int32 PhraseCount;
        public Int32 PhraseOffset;
        public Int32 ResponseCount;
        public Int32 ResponseOffset;
        public Int32 PhraseTriggerOffset;
        public Int32 PhraseTriggerCount;
        public Int32 ResponseTriggerOffset;
        public Int32 ResponseTriggerCount;
        public Int32 ActionOffset;
        public Int32 ActionCount;
        public UInt32 Flags;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct DlgPhraseBinary
    {
        public Int32 StrRef;
        public Int32 FirstResponseIndex;
        public Int32 ResponseCount;
        public Int32 TriggerIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct DlgResponseBinary
    {
        public UInt32 Flags;
        public Int32 StrRef;
        public Int32 JournalIndex;
        public Int32 TriggerIndex;
        public Int32 ActionIndex;
        public array8 NextScriptDialog;
        public Int32 NextPhraseIndex;
    }

    [Serializable]
    [Flags]
    public enum DlgResponseFlags: UInt32
    {
        None = 0,
        HasText = 1 << 0,
        HasTrigger = 1 << 1,
        HasAction = 1 << 2,
        HasNextDialog = 1 << 3,
        HasJournal = 1 << 4,
        Interrupt = 1 << 5,
        AddJournalUnsolved = 1 << 6,
        AddJournal = 1 << 7,
        AddJournalSolved = 1 << 8,
        ActionsImmediate = 1 << 9,
        ClearActions = 1 << 10,
    }

    [Serializable]
    [Flags]
    public enum DlgFlags : UInt32
    {
        None = 0,
        Enemy = 1 << 0,
        EscapeArea = 1 << 1,
        Nothing = 1 << 2,
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct DlgTextBinary
    {
        public Int32 Offset;
        public Int32 Length;
    }
}