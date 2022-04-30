using System;
using System.Collections.Generic;
using System.Linq;
using iiInfinityEngine.Core.Binary;

namespace iiInfinityEngine.Core.Files
{
    public class DlgFile : IEFile
    {
        [NonSerialized]
        private string checksum;
        public string Checksum { get { return checksum; } set { checksum = value; } }
        [NonSerialized]
        private string filename;
        public string Filename { get { return filename; } set { filename = value; } }
        [NonSerialized]
        private IEFileType fileType = IEFileType.Bif;
        public IEFileType FileType { get { return fileType; } }
        [NonSerialized]
        private IEFile originalFile;
        public IEFile OriginalFile { get { return originalFile; } set { originalFile = value; } }

        [NonSerialized]
        public UInt32 flags;
        public DlgFlags Flags => (DlgFlags)flags;

        public DlgPhrase[] Phrases;
        public DlgResponse[] Responses;
        public string[] TriggersPhrase;
        public string[] TriggersResponse;
        public string[] Actions;
    }

    [Serializable]
    public class DlgPhrase
    {
        public IEString Text;
        public int ResponsesIndexFirst;
        public int ResponsesCount;
        public int TriggerIndex;

        public int Index;

        [NonSerialized]
        private DlgFile owner;

        public DlgPhrase(DlgFile Owner) { owner = Owner; }
        public DlgResponse[] GetResponses()
        {
            return null;
        }
    }

    [Serializable]
    public class DlgResponse
    {
        [NonSerialized]
        public UInt32 flags;
        public DlgResponseFlags Flags => (DlgResponseFlags)flags;
        public IEString Text;
        public int JournalIndex;
        //public string JournalEntry;
        public int TriggerIndex;
        public int ActionIndex;
        public string NextScriptDialog;
        public int NextPhraseIndex;

        public int Index;

        [NonSerialized]
        private readonly DlgFile owner;

        public DlgResponse(DlgFile owner) { this.owner = owner; }
    }

    [Serializable]
    public class JournaMention
    {
        public string Dlg;
        public int Line;
    }

    [Serializable]
    public class JournaEntry
    {
        public string Text;
        public int Strref;
        public JournaMention LastMention;
        public List<JournaMention> OtherMentions;
    }

    [Serializable]
    public class JournaFile
    {
        public int Count => Entries != null ? Entries.Count : 0;
        public List<JournaEntry> Entries;

        public void AddEntry(int strref, string text, string dlg, int line)
        {
            JournaEntry entry = null;
            if (this.Entries != null)
            {
                entry = this.Entries.Where(e => e.Strref == strref).FirstOrDefault();
            }
            else
            {
                this.Entries = new List<JournaEntry>();
            }

            if (entry == null)
            {
                entry = new JournaEntry
                {
                    Strref = strref,
                    Text = text,
                    LastMention = new JournaMention() { Dlg = dlg, Line = line }
                };
                this.Entries.Add(entry);
            } else
            {
                if (entry.OtherMentions == null)
                {
                    entry.OtherMentions = new List<JournaMention>();
                }
                entry.OtherMentions.Add(new JournaMention() { Dlg = dlg, Line = line });
            }
        }
    }
}