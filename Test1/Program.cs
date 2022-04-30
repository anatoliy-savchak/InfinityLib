using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using iiInfinityEngine.Core;
using iiInfinityEngine.Core.Files;
using Newtonsoft.Json;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(@"F:\GOG Games\Icewind Dale 2");
            game.LoadResources(IEFileType.Are);
            //game.LoadResources(IEFileType.Cre);
            if (false)
            {
                foreach (AreFile area_ in game.Areas)
                {
                    Console.WriteLine(area_.Filename);
                }
            }

            CreFile LoadCre(string creName)
            {
                string creNameLower = creName.ToLowerInvariant();
                var cre = game.Creatures.Where(b => b.Filename.ToLowerInvariant() == $"{creNameLower}.cre").SingleOrDefault();
                if (cre == null)
                    game.LoadResouce(creNameLower, IEFileType.Cre);
                cre = game.Creatures.Where(b => b.Filename.ToLowerInvariant() == $"{creNameLower}.cre").SingleOrDefault();
                return cre;
            };

            DimensionalArrayFile LoadDim(string name)
            {
                string nameLower = name.ToLowerInvariant();
                var obj = game.DimensionalArrays.Where(b => !String.IsNullOrEmpty(b.Filename) && b.Filename.ToLowerInvariant() == $"{nameLower}.2da").SingleOrDefault();
                if (obj == null)
                    game.LoadResouce(nameLower, IEFileType.DimensionalArray);
                obj = game.DimensionalArrays.Where(b => !String.IsNullOrEmpty(b.Filename) && b.Filename.ToLowerInvariant() == $"{nameLower}.2da").SingleOrDefault();
                return obj;
            };

            DlgFile LoadDlg(string name)
            {
                string nameLower = name.ToLowerInvariant();
                var obj = game.Dlgs.Where(b => !String.IsNullOrEmpty(b.Filename) && b.Filename.ToLowerInvariant() == $"{nameLower}.dlg").SingleOrDefault();
                if (obj == null)
                    game.LoadResouce(nameLower, IEFileType.Dlg);
                obj = game.Dlgs.Where(b => !String.IsNullOrEmpty(b.Filename) && b.Filename.ToLowerInvariant() == $"{nameLower}.dlg").SingleOrDefault();
                return obj;
            };

            ItmFile LoadItem(string name)
            {
                string nameLower = name.ToLowerInvariant();
                var obj = game.Items.Where(b => !String.IsNullOrEmpty(b.Filename) && b.Filename.ToLowerInvariant() == $"{nameLower}.itm").SingleOrDefault();
                if (obj == null)
                    game.LoadResouce(nameLower, IEFileType.Itm);
                obj = game.Items.Where(b => !String.IsNullOrEmpty(b.Filename) && b.Filename.ToLowerInvariant() == $"{nameLower}.itm").SingleOrDefault();
                return obj;
            };

            IdsFile LoadIds(string name)
            {
                string nameLower = name.ToLowerInvariant();
                var obj = game.Identifiers.Where(b => !String.IsNullOrEmpty(b.Filename) && b.Filename.ToLowerInvariant() == $"{nameLower}.ids").SingleOrDefault();
                if (obj == null)
                    game.LoadResouce(nameLower, IEFileType.Ids);
                obj = game.Identifiers.Where(b => !String.IsNullOrEmpty(b.Filename) && b.Filename.ToLowerInvariant() == $"{nameLower}.ids").SingleOrDefault();
                return obj;
            };

            void SaveObj(object obj, string fp)
            {
                string content = JsonConvert.SerializeObject(obj, Formatting.Indented,
                    new Newtonsoft.Json.JsonSerializerSettings()
                    {
                        Converters = new List<Newtonsoft.Json.JsonConverter>
                        {
                                                        new Newtonsoft.Json.Converters.StringEnumConverter()
                        }
                    }
                    );

                File.WriteAllText(fp, content);
            };

            if (false)
            {
                var area = game.Areas.Where(a => a.Filename.ToLowerInvariant() == "ar1000.are").SingleOrDefault();
                if (area != null)
                {
                    foreach (var a in area.actors)
                    {
                        Console.WriteLine($"{a.Name}, {a.CREFile}");
                        var cre = game.Creatures.Where(b => b.Filename.ToLowerInvariant() == $"{a.CREFile.ToLowerInvariant()}.cre").SingleOrDefault();
                        if (cre == null)
                            game.LoadResouce(a.CREFile.ToLowerInvariant(), IEFileType.Cre);
                        cre = game.Creatures.Where(b => b.Filename.ToLowerInvariant() == $"{a.CREFile.ToLowerInvariant()}.cre").SingleOrDefault();
                        if (cre == null) continue;
                        game.LoadResouce(((CreFile22)cre).DialogFile.ToLowerInvariant(), IEFileType.Dlg);
                        Console.WriteLine($"{cre.ShortName}: {cre.LongName}");
                    }
                }
            }
            if (false)
            {
                var area = game.Areas.Where(a => a.Filename.ToLowerInvariant() == "ar1001.are").SingleOrDefault();
                foreach (var a in area.actors)
                {
                    Console.WriteLine($"{a.Name}, {a.CREFile}");
                    var cre = game.Creatures.Where(b => b.Filename.ToLowerInvariant() == $"{a.CREFile.ToLowerInvariant()}.cre").SingleOrDefault();
                    if (cre == null)
                        game.LoadResouce(a.CREFile.ToLowerInvariant(), IEFileType.Cre);
                    cre = game.Creatures.Where(b => b.Filename.ToLowerInvariant() == $"{a.CREFile.ToLowerInvariant()}.cre").SingleOrDefault();
                    if (cre == null) continue;
                    Console.WriteLine($"{cre.ShortName}: {cre.LongName}");
                }
            }
            if (false)
            {
                LoadDim("LISTSPLL");
                game.LoadResources(IEFileType.Tlk);
                game.LoadResources(IEFileType.Spl);
                LoadCre("12PHAEN");
            }
            if (true)
            {
                string bcsFolder = @"D:\IE\Resources\IWD2\BCS";
                string outDir = @"D:\Dev.Home\GitHub\anatoliy-savchak\toee.zmod.iwd2\resources\iwd2_exp";

                string outAreaDir = Path.Combine(outDir, "Areas");
                if (!Directory.Exists(outAreaDir)) Directory.CreateDirectory(outAreaDir);

                string outCreDir = Path.Combine(outDir, "Creatures");
                if (!Directory.Exists(outCreDir)) Directory.CreateDirectory(outCreDir);

                string outDlgDir = Path.Combine(outDir, "Dialogs");
                if (!Directory.Exists(outDlgDir)) Directory.CreateDirectory(outDlgDir);

                string outItmDir = Path.Combine(outDir, "Items");
                if (!Directory.Exists(outItmDir)) Directory.CreateDirectory(outItmDir);

                string outScrDir = Path.Combine(outDir, "Scripts");
                if (!Directory.Exists(outScrDir)) Directory.CreateDirectory(outScrDir);

                string outJournalDir = Path.Combine(outDir, "Journal");
                if (!Directory.Exists(outJournalDir)) Directory.CreateDirectory(outJournalDir);

                game.LoadResources(IEFileType.Tlk);
                bool saveCre = false;
                bool saveDlg = false;
                bool saveAre = false;
                bool saveStrRefs = true;
                Dictionary<byte, string> colorsDict = new Dictionary<byte, string>();
                Dictionary<Int32, string> animations = new Dictionary<int, string>();
                string[] races = null;
                if (saveCre)
                {
                    LoadDim("LISTSPLL");
                    game.LoadResources(IEFileType.Spl);
                    game.LoadResources(IEFileType.Ids);
                    {
                        var ids = LoadIds("clownclr");
                        foreach (string line in ids.contents.Split(Environment.NewLine))
                        {
                            int pos = line.IndexOf('\t');
                            if (pos < 0) continue;
                            string intstr = line.Substring(0, pos).Trim();
                            byte value = byte.Parse(intstr);
                            string name = line.Substring(pos + 1).Trim();
                            colorsDict[value] = name;
                        }
                    }
                    var racesIds = LoadIds("race");
                    races = racesIds.contents.Split(Environment.NewLine);
                    {
                        var animateIds = LoadIds("animate");
                        foreach (string line in animateIds.contents.Split(Environment.NewLine))
                        {
                            int pos = line.IndexOf(' ');
                            if (pos < 0) continue;
                            string hexstr = line.Substring(0, pos).Trim();
                            Int32 value = Convert.ToInt32(hexstr, 16);
                            string name = line.Substring(pos + 1).Trim();
                            animations[value] = name;
                        }
                    }
                }

                // process areas, actors and cre
                if (saveCre || saveDlg || saveAre)
                {
                    string filterActor = null;// "Hedron";

                    string dir;
                    List<CreFile> alreadyCre = new List<CreFile>();
                    Dictionary<string, DlgFile> alreadyDlg = new Dictionary<string, DlgFile>();
                    foreach (AreFile area in game.Areas.ToArray())
                    {
                        string nameArea = area.Filename.Replace(".Are", string.Empty);
                        dir = Path.Combine(outAreaDir, nameArea);
                        if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                        if (saveCre || saveDlg || saveAre)
                        {
                            foreach (AreActor2 actor in area.actors)
                            {
                                string nameActor = actor.Name;
                                if (!string.IsNullOrEmpty(filterActor) && nameActor != filterActor) continue;
                                if (nameActor == "Door_Hint_Text_00") {; }
                                string actorfileName = Path.Combine(dir, nameActor) + ".json";
                                string logStr = actorfileName.Substring(outDir.Length);
                                Console.WriteLine(logStr);
                                //Debug.WriteLine(logStr);

                                CreFile cre = LoadCre(actor.CREFile);
                                CreFile22 cre22 = (CreFile22)cre;
                                if (cre != null)
                                {
                                    actor.DefaultHiddenCalc = cre22.Hidden == 1;
                                    if (saveCre)
                                    {
                                        if (!alreadyCre.Contains(cre) && saveCre)
                                        {
                                            // post-process items
                                            if (true)
                                            {
                                                for (int i = 0; i < ((CreFile22)cre).Items.Length; i++)
                                                //foreach(var item in ((CreFile22)cre).Items)
                                                {
                                                    var item = ((CreFile22)cre).Items[i];
                                                    if ((item.Item.HasValue) && (string.IsNullOrEmpty(item.ItemNameEval)) && (!string.IsNullOrEmpty(item.Item.Value.Filename)))
                                                    {
                                                        var itemObj = LoadItem(item.Item.Value.Filename);
                                                        if (itemObj != null)
                                                        {
                                                            item.ItemNameEval = itemObj.IdentifiedName.Text;
                                                            item.ItemTypeEval = itemObj.ItemType.ToString();
                                                            item.ItemDroppableEval = itemObj.Flags.Movable;
                                                        }
                                                    }
                                                }
                                            }

                                            // post process lookups
                                            {
                                                if (cre22.Race >= 0)
                                                {
                                                    cre22.RaceName = races.Where(line => line.StartsWith(cre22.Race.ToString() + ' ')).FirstOrDefault();
                                                    if (!string.IsNullOrEmpty(cre22.RaceName))
                                                        cre22.RaceName = cre22.RaceName.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                                                    //cre22.RaceName = races[cre22.Race];
                                                }

                                                if (cre22.Animation != 0)
                                                {
                                                    string value;
                                                    if (cre22.Animation != 0 && animations.TryGetValue(cre22.Animation, out value))
                                                    {
                                                        cre22.AnimationNameCalc = value;
                                                        value = null;
                                                    }

                                                    if (colorsDict.TryGetValue(cre22.MetalColourIndex, out value))
                                                    {
                                                        cre22.MetalColourName = value;
                                                        value = null;
                                                    }
                                                    if (colorsDict.TryGetValue(cre22.MinorColourIndex, out value))
                                                    {
                                                        cre22.MinorColourName = value;
                                                        value = null;
                                                    }
                                                    if (colorsDict.TryGetValue(cre22.MajorColourIndex, out value))
                                                    {
                                                        cre22.MajorColourName = value;
                                                        value = null;
                                                    }
                                                    if (colorsDict.TryGetValue(cre22.SkinColourIndex, out value))
                                                    {
                                                        cre22.SkinColourName = value;
                                                        value = null;
                                                    }
                                                    if (colorsDict.TryGetValue(cre22.LeatherColourIndex, out value))
                                                    {
                                                        cre22.LeatherColourName = value;
                                                        value = null;
                                                    }
                                                    if (colorsDict.TryGetValue(cre22.ArmorColourIndex, out value))
                                                    {
                                                        cre22.ArmorColourName = value;
                                                        value = null;
                                                    }
                                                    if (colorsDict.TryGetValue(cre22.HairColourIndex, out value))
                                                    {
                                                        cre22.HairColourName = value;
                                                        value = null;
                                                    }
                                                }
                                            }

                                            {
                                                string nameCre = cre.Filename.Replace(".Cre", string.Empty);
                                                string content = JsonConvert.SerializeObject(cre, Formatting.Indented,
                                                    new Newtonsoft.Json.JsonSerializerSettings()
                                                    {
                                                        Converters = new List<Newtonsoft.Json.JsonConverter>
                                                        {
                                                    new Newtonsoft.Json.Converters.StringEnumConverter()
                                                        }
                                                    }
                                                    );

                                                string fileNameCre = Path.Combine(outCreDir, nameCre) + ".json";
                                                Debug.WriteLine($"{fileNameCre.Substring(outDir.Length)}");
                                                File.WriteAllText(fileNameCre, content);
                                            }

                                            alreadyCre.Add(cre);
                                        }
                                    }

                                    if (saveDlg)
                                    {
                                        var dialogFile = ((CreFile22)cre).DialogFile;
                                        if (!string.IsNullOrWhiteSpace(dialogFile) && dialogFile.ToLowerInvariant() != "none" && !alreadyDlg.ContainsKey(dialogFile))
                                        {
                                            DlgFile dlg = LoadDlg(dialogFile);

                                            if (dlg != null)
                                            {
                                                string nameDlg = dlg.Filename.Replace(".Dlg", string.Empty);
                                                string content = JsonConvert.SerializeObject(dlg, Formatting.Indented,
                                                    new Newtonsoft.Json.JsonSerializerSettings()
                                                    {
                                                        Converters = new List<Newtonsoft.Json.JsonConverter>
                                                        {
                                                    new Newtonsoft.Json.Converters.StringEnumConverter() 
                                                        }
                                                    }
                                                    );
                                                string dlgfileName = Path.Combine(outDlgDir, nameDlg) + ".json";
                                                Debug.WriteLine($"{dlgfileName.Substring(outDir.Length)}");
                                                File.WriteAllText(dlgfileName, content);

                                                alreadyDlg.Add(dialogFile, dlg);
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Dlg {dialogFile} is null!");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Cre is null!");
                                }
                            }
                        }

                        if (saveAre)
                        {
                            if (true)
                            {
                                string content = JsonConvert.SerializeObject(area, Formatting.Indented,
                                    new Newtonsoft.Json.JsonSerializerSettings()
                                    {
                                        Converters = new List<Newtonsoft.Json.JsonConverter>
                                        {
                                                        new Newtonsoft.Json.Converters.StringEnumConverter()
                                        }
                                    }
                                    );

                                string arefileName = Path.Combine(dir, nameArea) + ".json";
                                File.WriteAllText(arefileName, content);
                            }

                            // does not work, exception
                            if (false)
                            {
                                if (!string.IsNullOrEmpty(area.AreaScript) && area.AreaScript != "None")
                                {
                                    var decomp = new BcsDecompiler(game.Identifiers);
                                    var lines = decomp.Decompile(Path.Combine(bcsFolder, area.AreaScript + ".BCS"));
                                    string areScrfileName = Path.Combine(outScrDir, area.AreaScript) + ".txt";
                                    File.WriteAllLines(areScrfileName, lines);
                                }
                            }
                        }
                    }

                    if (saveDlg && game.journaFile != null && !string.IsNullOrEmpty(outJournalDir))
                    {
                        string content = JsonConvert.SerializeObject(game.journaFile, Formatting.Indented,
                            new Newtonsoft.Json.JsonSerializerSettings()
                            {
                                Converters = new List<Newtonsoft.Json.JsonConverter>{new Newtonsoft.Json.Converters.StringEnumConverter()}
                            }
                            );

                        string journalFilePath = Path.Combine(outJournalDir, "journal.json");
                        File.WriteAllText(journalFilePath, content);
                    }

                    // process all items
                    if (false)
                    {
                        game.LoadResources(IEFileType.Itm);
                        foreach (ItmFile item in game.Items)
                        {
                            string nameItem = item.Filename.Replace(".Are", string.Empty);
                            {
                                string content = JsonConvert.SerializeObject(item, Formatting.Indented,
                                    new Newtonsoft.Json.JsonSerializerSettings()
                                    {
                                        Converters = new List<Newtonsoft.Json.JsonConverter>
                                        {
                                                    new Newtonsoft.Json.Converters.StringEnumConverter()
                                        }
                                    }
                                    );

                                string fileName = Path.Combine(outItmDir, Path.GetFileNameWithoutExtension(nameItem)) + ".json";
                                File.WriteAllText(fileName, content);
                            }
                        }
                    }
                }

                if (saveStrRefs)
                {
                    SortedDictionary<int, string> refs = new SortedDictionary<int, string>();
                    string scrFolder = @"D:\IE\Resources\IWD2\SCR";
                    foreach(string fileNamebcs in Directory.GetFiles(scrFolder, "*.BAF"))
                    {
                        var lines = File.ReadAllLines(fileNamebcs);
                        foreach(string line in lines)
                        {
                            string lline = line.ToLowerInvariant();
                            int pos;
                            if ((pos = lline.IndexOf("floatmessage(")) >= 0)
                            {
                                var lineComm = line.Split("//", 2);
                                var afterLastComma = lineComm[0].Split(',');
                                var beforeParen = afterLastComma[afterLastComma.Length - 1].Split(')', 2);
                                string sresref = beforeParen[0].Trim();

                                int resref = int.Parse(sresref);
                                if (!refs.ContainsKey(resref))
                                {
                                    var rstr = Common.ReadString(resref, game.Tlk);
                                    string text = rstr.Text.Trim();
                                    if (text.StartsWith('"')) text = text.Remove(0, 1);
                                    if (text.EndsWith('"')) text = text.Remove(text.Length-1, 1);
                                    refs[resref] = text; // rstr.Text.Replace("\"", string.Empty);
                                    if (!string.IsNullOrEmpty(rstr.Sound))
                                    {
                                        Console.WriteLine("Has sound!!");
                                    }
                                    if (rstr.Flags.HasFlag(StringEntryType.Tagged))
                                    {
                                        Console.WriteLine("Tagged!!");
                                    }
                                }
                            }
                        }
                    }
                    SaveObj(refs, @"D:\Dev.Home\GitHub\anatoliy-savchak\toee.zmod.iwd2\resources\iwd2_exp\Text\strrefs.json");
                }

            }
        }
    }
}