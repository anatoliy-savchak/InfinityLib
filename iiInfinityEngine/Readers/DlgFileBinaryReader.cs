using System.Collections.Generic;
using System.IO;
using System.Text;
using iiInfinityEngine.Core.Binary;
using iiInfinityEngine.Core.Files;
using iiInfinityEngine.Core.Readers.Interfaces;

namespace iiInfinityEngine.Core.Readers
{
    public class DlgFileBinaryReader : IDlgFileReader
    {
        public TlkFile TlkFile { get; set; }

        public DlgFile Read(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                var f = Read(fs);
                f.Filename = Path.GetFileName(filename);
                return f;
            }
        }

        public DlgFile Read(Stream s)
        {
            using (BinaryReader br = new BinaryReader(s))
            {
                var dlgFile = ParseFile(br);
                //br.BaseStream.Seek(0, SeekOrigin.Begin);
                //dlgFile.OriginalFile = ParseFile(br);
                return dlgFile;
            }
        }

        private DlgFile ParseFile(BinaryReader br)
        {
            var header = (DlgHeaderBinary)Common.ReadStruct(br, typeof(DlgHeaderBinary));

            DlgFile dlgFile = new DlgFile();
            if (header.ftype.ToString().Trim() != "DLG")
                return dlgFile;
            dlgFile.flags = header.Flags;

            {
                List<DlgPhrase> phrases = new List<DlgPhrase>();
                br.BaseStream.Seek(header.PhraseOffset, SeekOrigin.Begin);
                for (int i = 0; i < header.PhraseCount; i++)
                {
                    DlgPhraseBinary phraseRec = (DlgPhraseBinary)Common.ReadStruct(br, typeof(DlgPhraseBinary));
                    DlgPhrase phrase = new DlgPhrase(dlgFile)
                    {
                        Index = i,
                        Text = Common.ReadString(phraseRec.StrRef, TlkFile),
                        ResponsesIndexFirst = phraseRec.FirstResponseIndex,
                        ResponsesCount = phraseRec.ResponseCount,
                        TriggerIndex = phraseRec.TriggerIndex
                    };
                    phrases.Add(phrase);
                }

                dlgFile.Phrases = phrases.ToArray();
            }
            {
                List<DlgResponse> recs = new List<DlgResponse>();
                br.BaseStream.Seek(header.ResponseOffset, SeekOrigin.Begin);
                for (int i = 0; i < header.ResponseCount; i++)
                {
                    DlgResponseBinary rec = (DlgResponseBinary)Common.ReadStruct(br, typeof(DlgResponseBinary));
                    DlgResponse obj = new DlgResponse(dlgFile)
                    {
                        Index = i,
                        flags = rec.Flags,
                        JournalIndex = rec.JournalIndex,
                        TriggerIndex = rec.TriggerIndex,
                        ActionIndex = rec.ActionIndex,
                        NextPhraseIndex = rec.NextPhraseIndex,
                        NextScriptDialog = rec.NextScriptDialog.ToString()
                    };
                    if (obj.Flags.HasFlag(DlgResponseFlags.HasText))
                        obj.Text = Common.ReadString(rec.StrRef, TlkFile);
                    recs.Add(obj);
                }

                dlgFile.Responses = recs.ToArray();
            }

            {
                br.BaseStream.Seek(header.PhraseTriggerOffset, SeekOrigin.Begin);
                List<DlgTextBinary> structs = new List<DlgTextBinary>();
                {
                    for (int i = 0; i < header.PhraseTriggerCount; i++)
                    {
                        var rec = (DlgTextBinary)Common.ReadStruct(br, typeof(DlgTextBinary));
                        structs.Add(rec);
                    }
                }
                List<string> recs = new List<string>();
                foreach(var rec in structs)
                {
                    br.BaseStream.Seek(rec.Offset, SeekOrigin.Begin);
                    string text = Encoding.ASCII.GetString(br.ReadBytes(rec.Length));
                    recs.Add(text);
                }

                dlgFile.TriggersPhrase = recs.ToArray();
            }

            {
                br.BaseStream.Seek(header.ResponseTriggerOffset, SeekOrigin.Begin);
                List<DlgTextBinary> structs = new List<DlgTextBinary>();
                {
                    for (int i = 0; i < header.ResponseTriggerCount; i++)
                    {
                        var rec = (DlgTextBinary)Common.ReadStruct(br, typeof(DlgTextBinary));
                        structs.Add(rec);
                    }
                }
                List<string> recs = new List<string>();
                foreach (var rec in structs)
                {
                    br.BaseStream.Seek(rec.Offset, SeekOrigin.Begin);
                    string text = Encoding.ASCII.GetString(br.ReadBytes(rec.Length));
                    recs.Add(text);
                }

                dlgFile.TriggersResponse = recs.ToArray();
            }

            {
                br.BaseStream.Seek(header.ActionOffset, SeekOrigin.Begin);
                List<DlgTextBinary> structs = new List<DlgTextBinary>();
                {
                    for (int i = 0; i < header.ActionCount; i++)
                    {
                        var rec = (DlgTextBinary)Common.ReadStruct(br, typeof(DlgTextBinary));
                        structs.Add(rec);
                    }
                }
                List<string> recs = new List<string>();
                foreach (var rec in structs)
                {
                    br.BaseStream.Seek(rec.Offset, SeekOrigin.Begin);
                    string text = Encoding.ASCII.GetString(br.ReadBytes(rec.Length));
                    recs.Add(text);
                }

                dlgFile.Actions = recs.ToArray();
            }

            //dlgFile.Checksum = MD5HashGenerator.GenerateKey(dlgFile);
            return dlgFile;
        }
    }
}