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
                string outDir = @"D:\Dev.Home\GitHub\anatoliy-savchak\toee.zmod.iwd2\resources\iwd2_exp";

                string outAreaDir = Path.Combine(outDir, "Areas");
                if (!Directory.Exists(outAreaDir)) Directory.CreateDirectory(outAreaDir);

                string outCreDir = Path.Combine(outDir, "Creatures");
                if (!Directory.Exists(outCreDir)) Directory.CreateDirectory(outCreDir);

                string outDlgDir = Path.Combine(outDir, "Dialogs");
                if (!Directory.Exists(outDlgDir)) Directory.CreateDirectory(outDlgDir);

                LoadDim("LISTSPLL");
                game.LoadResources(IEFileType.Tlk);
                game.LoadResources(IEFileType.Spl);
                string dir;
                List<CreFile> alreadyCre = new List<CreFile>();
                Dictionary<string, DlgFile> alreadyDlg = new Dictionary<string, DlgFile>();
                foreach (var area in game.Areas.ToArray())
                {
                    string nameArea = area.Filename.Replace(".Are", string.Empty);
                    dir = Path.Combine(outAreaDir, nameArea);
                    if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                    foreach (AreActor2 actor in area.actors)
                    {
                        string nameActor = actor.Name;
                        string content = JsonConvert.SerializeObject(actor, Formatting.Indented);
                        string fileName = Path.Combine(dir, nameActor) + ".json";
                        string logStr = fileName.Substring(outDir.Length);
                        //Console.WriteLine(logStr);
                        Debug.WriteLine(logStr);
                        File.WriteAllText(fileName, content);

                        CreFile cre = LoadCre(actor.CREFile);
                        if (cre != null)
                        {
                            if (!alreadyCre.Contains(cre))
                            {
                                string nameCre = cre.Filename.Replace(".Cre", string.Empty);
                                content = JsonConvert.SerializeObject(cre, Formatting.Indented);
                                fileName = Path.Combine(outCreDir, nameCre) + ".json";
                                Debug.WriteLine($"{fileName.Substring(outDir.Length)}");
                                File.WriteAllText(fileName, content);

                                alreadyCre.Add(cre);
                            }

                            {
                                var dialogFile = ((CreFile22)cre).DialogFile;
                                if (!string.IsNullOrWhiteSpace(dialogFile) && dialogFile.ToLowerInvariant() != "none" && !alreadyDlg.ContainsKey(dialogFile))
                                {
                                    DlgFile dlg = LoadDlg(dialogFile);

                                    if (dlg != null)
                                    {
                                        string nameDlg = dlg.Filename.Replace(".Dlg", string.Empty);
                                        content = JsonConvert.SerializeObject(dlg, Formatting.Indented,
                                            new Newtonsoft.Json.JsonSerializerSettings()
                                            {
                                                Converters = new List<Newtonsoft.Json.JsonConverter>
                                                {
                                                    new Newtonsoft.Json.Converters.StringEnumConverter()
                                                }
                                            }
                                            );
                                        fileName = Path.Combine(outDlgDir, nameDlg) + ".json";
                                        Debug.WriteLine($"{fileName.Substring(outDir.Length)}");
                                        File.WriteAllText(fileName, content);

                                        alreadyDlg.Add(dialogFile, dlg);
                                    } else
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
            }


            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
