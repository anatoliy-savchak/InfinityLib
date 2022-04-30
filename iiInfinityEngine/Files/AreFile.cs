﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iiInfinityEngine.Core.Files
{
    [Serializable]
    public class AreFile : IEFile
    {
        public List<AreActor2> actors = new List<AreActor2>();
        public List<AreRegion2> regions = new List<AreRegion2>();
        public List<AreSpawnPoint2> spawns = new List<AreSpawnPoint2>();
        public List<AreEntrance2> entrances = new List<AreEntrance2>();
        public List<AreContainer2> containers = new List<AreContainer2>();
        public List<AreItem2> items = new List<AreItem2>();
        public List<AreAmbient2> ambients = new List<AreAmbient2>();
        public List<AreVariable2> variables = new List<AreVariable2>();
        public List<AreDoor2> doors = new List<AreDoor2>();
        public List<AreAnimation2> animations = new List<AreAnimation2>();
        public List<AreNote2> notes = new List<AreNote2>();
        public List<AreTiledObject2> tiledObjects = new List<AreTiledObject2>();
        public List<AreProjectile2> projectiles = new List<AreProjectile2>();
        public List<AreSong2> songs = new List<AreSong2>();
        public List<AreInterruption2> interruptions = new List<AreInterruption2>();
        public List<bool> exploration = new List<bool>();
        public List<Int32> vertices = new List<Int32>();

        [NonSerialized]
        private string checksum;
        public string Checksum { get { return checksum; } set { checksum = value; } }
        [NonSerialized]
        private string filename;
        public string Filename { get { return filename; } set { filename = value; } }
        [NonSerialized]
        private IEFileType fileType = IEFileType.Are;
        public IEFileType FileType { get { return fileType; } }
        [NonSerialized]
        private IEFile originalFile;
        public IEFile OriginalFile { get { return originalFile; } set { originalFile = value; } }

        public string AreaWED;
        public Int32 LastSaved;
        public AreaFlags AreaFlags;
        public string AreaToTheNorth;
        [NonSerialized]
        public Int32 Unknown1;
        public string AreaToTheEast;
        [NonSerialized]
        public Int32 Unknown2;
        public string AreaToTheSouth;
        [NonSerialized]
        public Int32 Unknown3;
        public string AreaToTheWest;
        [NonSerialized]
        public Int32 Unknown4;
        public AreaTypeFlags AreaTypeFlags;
        public Int16 WeatherProbabilityRain;
        public Int16 WeatherProbabilitySnow;
        public Int16 WeatherProbabilityFog;// - not implemented 
        public Int16 WeatherProbabilityLightning;
        [NonSerialized]
        public Int16 Unknown5;
        public Int32 VertexOffset;
        public Int16 VertexCount;
        public Int32 Unknown6;
        public string AreaScript;
        public Int32 ExploredBitmaskSize;
        public Int32 ExploredBitmaskOffset;
        public string RestMovieDay;
        public string RestMovieNight;
        public array56 Unknown7;
    }

    [Serializable]
    public class AreActor2
    {
        public string Name;
        public Int16 CurrentXCoordinate;
        public Int16 CurrentYCoordinate;
        public Int16 DestinationXCoordinate;
        public Int16 DestinationYCoordinate;
        public Int16 CurrentXCoordinateSec;
        public Int16 CurrentYCoordinateSec;
        public Int16 DestinationXCoordinateSec;
        public Int16 DestinationYCoordinateSec;
        public ActorFlags ActorFlags;
        public Int16 HasBeenSpawned;
        public byte FilenameInitialCharacter;
        public byte AreaDifficultyMask;
        public Int32 ActorAnimation;
        public Int32 ActorOrientation; //should be 2 + unused 2
        public Int32 ActorRemovalTimer;
        public Int16 MovementRestrictionDistance;
        public Int16 MovementRestrictionDistanceMoveToObject;
        public Int32 ActorAppearenceSchedule;
        //bit 23 = 23:30 to 00:29
        //bit 22 = 22:30 to 23:29
        //bit 21 = 21:30 to 22:29 (Night)
        //bit 20 = 20:30 to 21:29 (Dusk)
        //bit 19 = 19:30 to 20:29
        //bit 18 = 18:30 to 19:29
        //bit 17 = 17:30 to 18:29
        //bit 16 = 16:30 to 17:29
        //bit 15 = 15:30 to 16:29
        //bit 14 = 14:30 to 15:29
        //bit 13 = 13:30 to 14:29
        //bit 12 = 12:30 to 13:29
        //bit 11 = 11:30 to 12:29
        //bit 10 = 10:30 to 11:29
        //bit 9 = 09:30 to 10:29
        //bit 8 = 08:30 to 09:29
        //bit 7 = 07:30 to 08:29
        //bit 6 = 06:30 to 07:29 (Day)
        //bit 5 = 05:30 to 06:29 (Dawn)
        //bit 4 = 04:30 to 05:29
        //bit 3 = 03:30 to 04:29
        //bit 2 = 02:30 to 03:29
        //bit 1 = 01:30 to 02:29
        //bit 0 = 00:30 to 01:29 
        public Int32 NumTimesTalkedTo;
        public string Dialog;
        public string ScriptOverride;
        public string ScriptGeneral; // special 3
        public string ScriptClass; // special 2
        public string ScriptRace; // combat
        public string ScriptDefault; // movement
        public string ScriptSpecific; // team
        public string CREFile;
        public Int32 CreOffset;
        public Int32 CreSize;
        public string ScriptSpecial1; // team
        [NonSerialized]
        public array120 Unknown2;
        public bool DefaultHiddenCalc;
    }

    [Serializable]
    public struct AreRegion2
    {
        public string Name;
        public RegionType RegionType;
        public Int16 BoundingBoxLeft;
        public Int16 BoundingBoxTop;
        public Int16 BoundingBoxRight;
        public Int16 BoundingBoxBottom;
        public Int16 VertexCount;
        public Int32 VertexIndex;
        public Int32 Unknown1;
        public Int32 Cursor;
        public string DestinationArea;
        public string DestinationEntrance;
        public RegionFlags Flags;
        public IEString InformationText;
        public Int16 TrapDetectionDifficulty;
        public Int16 TrapRemovalDifficulty;
        public Int16 IsTrap;
        public Int16 TrapDetected;
        public Int16 TrapLaunchXCoordinate;
        public Int16 TrapLaunchYCoordinate;
        public Int16 TrapLaunchXCoordinateSec;
        public Int16 TrapLaunchYCoordinateSec;
        public string KeyItem;
        public string RegionScript;
        public Int16 AlternativeUsePointXCoordinate;
        public Int16 AlternativeUsePointYCoordinate;
        public Int16 AlternativeUsePointXCoordinateSec;
        public Int16 AlternativeUsePointYCoordinateSec;
        public Int32 Unknown2;
        public array32 Unknown3;
        public string Sound;
        public Int16 TalkLocationXCoordinate;
        public Int16 TalkLocationYCoordinate;
        public Int16 TalkLocationXCoordinateSec;
        public Int16 TalkLocationYCoordinateSec;
        public IEString DialogName;
        public string DialogFile;
    }

    [Serializable]
    public struct AreSpawnPoint2
    {
        public string Name;
        public Int16 XCoordinate;
        public Int16 YCoordinate;
        public Int16 XCoordinateSec;
        public Int16 YCoordinateSec;
        public string Resref1;
        public string Resref2;
        public string Resref3;
        public string Resref4;
        public string Resref5;
        public string Resref6;
        public string Resref7;
        public string Resref8;
        public string Resref9;
        public string Resref10;
        public Int16 CreatureSpawnCount;
        public Int16 BaseCreatureNumberToSpawn;
        public Int16 Frequency;
        public Int16 SpawnMethod;
        //Bit 0: If Bit 2 is set, don't spawn
        //Bit 1: One-time-spawnpoint (checked for after the spawning, and disables the spawn point if set)
        //Bit 2: Used internally to disable the spawn point temporarily
        //Set after a spawning and cleared in two situations:
        //(1) after the CompressTime() method for the spawn point is called with a time amount of at least 16 hours
        //(2) if Bit 0 is not set and there are no living spawns in the area 
        public Int32 ActorRemovalTime;
        public Int16 MovementRestrictionDistance;
        public Int16 MovementRestrictionDistanceToObject;
        public Int16 MaximumCreaturesToSpawn;
        public Int16 Enabled;
        public Int32 SpawnPointAppearenceSchedule;
        //bit 23 = 23:30 to 00:29
        //bit 22 = 22:30 to 23:29
        //bit 21 = 21:30 to 22:29 (Night)
        //bit 20 = 20:30 to 21:29 (Dusk)
        //bit 19 = 19:30 to 20:29
        //bit 18 = 18:30 to 19:29
        //bit 17 = 17:30 to 18:29
        //bit 16 = 16:30 to 17:29
        //bit 15 = 15:30 to 16:29
        //bit 14 = 14:30 to 15:29
        //bit 13 = 13:30 to 14:29
        //bit 12 = 12:30 to 13:29
        //bit 11 = 11:30 to 12:29
        //bit 10 = 10:30 to 11:29
        //bit 9 = 09:30 to 10:29
        //bit 8 = 08:30 to 09:29
        //bit 7 = 07:30 to 08:29
        //bit 6 = 06:30 to 07:29 (Day)
        //bit 5 = 05:30 to 06:29 (Dawn)
        //bit 4 = 04:30 to 05:29
        //bit 3 = 03:30 to 04:29
        //bit 2 = 02:30 to 03:29
        //bit 1 = 01:30 to 02:29
        //bit 0 = 00:30 to 01:29 
        public Int16 ProbabilityDay;
        public Int16 ProbabilityNight;
        [NonSerialized]
        public array56 Unknown;
    }

    [Serializable]
    public struct AreEntrance2
    {
        public string Name;
        public Int16 XCoordinate;
        public Int16 YCoordinate;
        public Int16 XCoordinateSec;
        public Int16 YCoordinateSec;
        public Int16 Orientation;
        [NonSerialized]
        public array66 Unknown;
    }

    [Serializable]
    public class AreContainer2
    {
        public List<AreItem2> items = new List<AreItem2>();

        public string Name;
        public Int16 XCoordinate;
        public Int16 YCoordinate;
        public Int16 XCoordinateSec;
        public Int16 YCoordinateSec;
        public ContainerType ContainerType;
        public Int16 LockDifficulty;
        public ContainerFlags Flags;
        public Int16 TrapDetectionDifficulty;
        public Int16 TrapRemovalDifficulty;
        public Int16 IsTrap;
        public Int16 TrapDetected;
        public Int16 TrapLaunchXCoordinate;
        public Int16 TrapLaunchYCoordinate;
        public Int16 TrapLaunchXCoordinateSec;
        public Int16 TrapLaunchYCoordinateSec;
        public Int16 BoundingBoxLeft;
        public Int16 BoundingBoxTop;
        public Int16 BoundingBoxRight;
        public Int16 BoundingBoxBottom;
        public string TrapScript;
        public Int32 VertexIndex;
        public Int16 VertexCount;
        [NonSerialized]
        public array34 Unknown1;
        public string KeyItem;
        [NonSerialized]
        public Int32 Unknown2;
        public IEString LockpickString;
        [NonSerialized]
        public array56 Unknown3;
    }

    [Serializable]
    public struct AreItem2
    {
        public string ItemResref;
        public Int16 ExpirationTime;
        public Int16 Charges1;
        public Int16 Charges2;
        public Int16 Charges3;
        public AreaItemFlags Flags;
    }

    [Serializable]
    public struct AreAmbient2
    {
        public string Name;
        public Int16 XCoordinate;
        public Int16 YCoordinate;
        public Int16 XCoordinateSec;
        public Int16 YCoordinateSec;
        public Int16 Radius;
        public Int16 Height;
        [NonSerialized]
        public array6 Unknown1;
        public Int16 Volume;
        public string Resref1;
        public string Resref2;
        public string Resref3;
        public string Resref4;
        public string Resref5;
        public string Resref6;
        public string Resref7;
        public string Resref8;
        public string Resref9;
        public string Resref10;
        public Int16 ResRefCount;
        [NonSerialized]
        public Int16 Unknown2;
        public Int32 FrequencyBase;
        public Int32 FrequencyVariation;
        public AmbientSchedule AmbientAppearenceSchedule;
        public string AmbientAppearenceScheduleStr { get 
            {
                string Separator = ", ";
                bool IsExactlyOneBitSet(int i)
                {
                    return i != 0 && (i & (i - 1)) == 0;
                };
                var str = new StringBuilder();

                foreach (object i in Enum.GetValues(typeof(AmbientSchedule)))
                {
                    if (IsExactlyOneBitSet((int)i) &&
                        AmbientAppearenceSchedule.HasFlag((Enum)i))
                    {
                        str.Append((AmbientSchedule)i + Separator);
                    }
                }

                if (str.Length > 0)
                {
                    str.Length -= Separator.Length;
                }

                return str.ToString();
            }
    }
        public AmbientFlags Flags;
        [NonSerialized]
        public array64 Unknown3;
    }

    [Serializable]
    [Flags]
    public enum AmbientFlags : Int32
    {
        Enabled = 0x00000001,
        Looping = 0x00000002,
        IgnoreRadius = 0x00000004,
        RandomOrder = 0x00000008,
        LowMemSounds1 = 0x00000010,
    }

    [Serializable]
    [Flags]
    public enum AmbientSchedule : Int32
    {
        From_0030_to_0129 = 1<<0,
        From_0130_to_0229 = 1<<1,
        From_0230_to_0329 = 1<<2,
        From_0330_to_0429 = 1<<3,
        From_0430_to_0529 = 1<<4,
        From_0530_to_0629 = 1<<5,
        From_0630_to_0729 = 1<<6,
        From_0730_to_0829 = 1<<7,
        From_0830_to_0929 = 1<<8,
        From_0930_to_1029 = 1<<9,
        From_1030_to_1129 = 1<<10,
        From_1130_to_1229 = 1<<11,
        From_1230_to_1329 = 1<<12,
        From_1330_to_1429 = 1<<13,
        From_1430_to_1529 = 1<<14,
        From_1530_to_1629 = 1<<15,
        From_1630_to_1729 = 1<<16,
        From_1730_to_1829 = 1<<17,
        From_1830_to_1929 = 1<<18,
        From_1930_to_2029 = 1<<19,
        From_2030_to_2129 = 1<<20,
        From_2130_to_2229 = 1<<21,
        From_2230_to_2329 = 1<<22,
        From_2330_to_0029 = 1<<23,
        ALL=-1
    }


    [Serializable]
    public struct AreVariable2
    {
        public string Name;
        public array8 Unknown1;
        public Int32 Value;
        public array40 Unknown2;
    }

    [Serializable]
    public struct AreDoor2
    {
        public string Name;
        public string DoorId;
        public Int32 Flags;
        //bit 0: Door open
        //bit 1: Door locked
        //bit 2: Reset trap
        //bit 3: Trap detectable
        //bit 4: Door has been bashed
        //bit 5: Can't close
        //bit 6: Linked
        //bit 7: Door Hidden
        //bit 8: Door Found (if hidden)
        //bit 9: Don't block line of sight
        //bit 10: Remove Key (BG2 only)
        //bit 11: Slide
        public Int32 OpenVertexIndex;
        public Int16 OpenVertexCount;
        public Int16 ClosedVertexCount;
        public Int32 ClosedVertexIndex;
        public Int16 OpenBoundingBoxLeft;
        public Int16 OpenBoundingBoxTop;
        public Int16 OpenBoundingBoxRight;
        public Int16 OpenBoundingBoxBottom;
        public Int16 ClosedBoundingBoxLeft;
        public Int16 ClosedBoundingBoxTop;
        public Int16 ClosedBoundingBoxRight;
        public Int16 ClosedBoundingBoxBottom;
        public Int32 OpenVertexBlockIndex;
        public Int16 OpenVertexBlockCount;
        public Int16 ClosedVertexBlockCount;
        public Int32 ClosedVertexBlockIndex;
        public Int32 Unused;
        public string DoorOpenSound;
        public string DoorCloseSound;
        public Int32 Cursor;
        public Int16 TrapDetectionDifficulty;
        public Int16 TrapRemovalDifficulty;
        public Int16 IsTrap;
        public Int16 TrapDetected;
        public Int16 TrapLaunchXCoordinate;
        public Int16 TrapLaunchYCoordinate;
        public Int16 TrapLaunchXCoordinateSec;
        public Int16 TrapLaunchYCoordinateSec;
        public string KeyItem;
        public string DoorScript;
        public Int32 SecretDoorDetectionDifficulty;
        public Int32 LockDifficulty;
        public Int16 DoorState1X;
        public Int16 DoorState1Y;
        public Int16 DoorState2X;
        public Int16 DoorState2Y;
        public IEString LockpickString;
        public string TravelTriggerName;
        public IEString DialogName;
        public string DialogResref;
        [NonSerialized]
        public array8 Unknown;
    }

    [Serializable]
    public struct AreAnimation2
    {
        public string Name;
        public Int16 XCoordinate;
        public Int16 YCoordinate;
        public Int16 XCoordinateSec;
        public Int16 YCoordinateSec;
        public Int32 AnimationAppearenceSchedule;
        public string BamAnimation;
        public Int16 BamSequence;
        public Int16 BamFrame;
        public Int32 Flags;
        public Int16 Height;
        public Int16 Transparency;
        public Int16 StartFrame;
        public byte LoopChance;
        public byte SkipCycles;
        public string Palette;
        [NonSerialized]
        public Int32 Unknown;
    }

    [Serializable]
    public struct AreNote2
    {
        public Int16 XCoordinate;
        public Int16 YCoordinate;
        public Int16 XCoordinateSec;
        public Int16 YCoordinateSec;
        public IEString Text;
        public Int16 Location;
        public Int16 Colour;
        [NonSerialized]
        public array36 Unknown;
    }

    [Serializable]
    public struct AreTiledObject2
    {
        public string Name;
        [NonSerialized]
        public array32 Unknown1;
        [NonSerialized]
        public Int32 Unknown2;
        public Int32 OpenSearchOffset;
        public Int32 OpenSearchCount;
        public Int32 ClosedSearchOffset;
        public Int32 ClosedSearchCount;
        [NonSerialized]
        public array48 Unknown3;
    }

    [Serializable]
    public struct AreProjectile2
    {
        public string Resref;
        public Int32 EffectOffset;
        public Int16 EffectSize;
        public Int16 MissileId; // missile.ids or projectile.ids - 1
        public Int16 TickUntilTriggerCheck;
        public Int16 TriggersRemaining;
        public Int16 XCoordinate;
        public Int16 YCoordinate;
        public Int16 XCoordinateSec;
        public Int16 YCoordinateSec;
        public Int16 ZCoordinate;
        public byte EATarget;
        public byte PartyOwnerIndex;
    }

    [Serializable]
    public struct AreSong2
    {
        public Int32 DaySong;
        public Int32 NightSong;
        public Int32 WinSong;
        public Int32 BattleSong;
        public Int32 LoseSong;
        [NonSerialized]
        public Int32 Unknown1;
        [NonSerialized]
        public Int32 Unknown2;
        [NonSerialized]
        public Int32 Unknown3;
        [NonSerialized]
        public Int32 Unknown4;
        [NonSerialized]
        public Int32 Unknown5;
        public string DayAmbient1Wav;
        public string DayAmbient2Wav;
        public Int32 DayAmbientVolume;
        public string NightAmbient1Wav;
        public string NightAmbient2Wav;
        public Int32 NightAmbientVolume;
        public Int32 Reverb;
        [NonSerialized]
        public array60 Unknown6;
    }

    [Serializable]
    public struct AreInterruption2
    {
        public string Name;
        public Int32 Text1;
        public Int32 Text2;
        public Int32 Text3;
        public Int32 Text4;
        public Int32 Text5;
        public Int32 Text6;
        public Int32 Text7;
        public Int32 Text8;
        public Int32 Text9;
        public Int32 Text10;
        public string ResRef1;
        public string ResRef2;
        public string ResRef3;
        public string ResRef4;
        public string ResRef5;
        public string ResRef6;
        public string ResRef7;
        public string ResRef8;
        public string ResRef9;
        public string ResRef10;
        public Int16 CreatureCount;
        public Int16 Difficulty;
        public Int32 RemovalTime;
        public Int16 RestrictionDistance;
        public Int16 RestrictionDistanceToObject;
        public Int16 MaximumCreaturesToSpawn;
        public Int16 Enabled;
        public Int16 DayProbability;
        public Int16 NightProbability;
        [NonSerialized]
        public array56 Unknown;
    }

    [Serializable]
    public struct AreaFlags
    {
        public bool SaveAllowed { get; set; }
        public bool TutorialArea { get; set; }
        public bool DeadMagicZone { get; set; }
        public bool Dream { get; set; }
        public bool Bit04 { get; set; }
        public bool Bit05 { get; set; }
        public bool Bit06 { get; set; }
        public bool Bit07 { get; set; }
        public bool Bit08 { get; set; }
        public bool Bit09 { get; set; }
        public bool Bit10 { get; set; }
        public bool Bit11 { get; set; }
        public bool Bit12 { get; set; }
        public bool Bit13 { get; set; }
        public bool Bit14 { get; set; }
        public bool Bit15 { get; set; }
        public bool Bit16 { get; set; }
        public bool Bit17 { get; set; }
        public bool Bit18 { get; set; }
        public bool Bit19 { get; set; }
        public bool Bit20 { get; set; }
        public bool Bit21 { get; set; }
        public bool Bit22 { get; set; }
        public bool Bit23 { get; set; }
        public bool Bit24 { get; set; }
        public bool Bit25 { get; set; }
        public bool Bit26 { get; set; }
        public bool Bit27 { get; set; }
        public bool Bit28 { get; set; }
        public bool Bit29 { get; set; }
        public bool Bit30 { get; set; }
        public bool Bit31 { get; set; }
    }

    [Serializable]
    public struct AreaTypeFlags
    {
        public bool Outdoor { get; set; }
        public bool DayNight { get; set; }
        public bool Weather { get; set; }
        public bool City { get; set; }
        public bool Forest { get; set; }
        public bool Dungeon { get; set; }
        public bool ExtendedNight { get; set; }
        public bool CanRestIndoors { get; set; }
        public bool Bit08 { get; set; }
        public bool Bit09 { get; set; }
        public bool Bit10 { get; set; }
        public bool Bit11 { get; set; }
        public bool Bit12 { get; set; }
        public bool Bit13 { get; set; }
        public bool Bit14 { get; set; }
        public bool Bit15 { get; set; }
    }

    [Serializable]
    public struct ActorFlags
    {
        public bool CreAttached { get; set; }
        public bool Bit01 { get; set; }
        public bool Bit02 { get; set; }
        public bool OverrideScriptName { get; set; }
        public bool Bit04 { get; set; }
        public bool Bit05 { get; set; }
        public bool Bit06 { get; set; }
        public bool Bit07 { get; set; }
        public bool Bit08 { get; set; }
        public bool Bit09 { get; set; }
        public bool Bit10 { get; set; }
        public bool Bit11 { get; set; }
        public bool Bit12 { get; set; }
        public bool Bit13 { get; set; }
        public bool Bit14 { get; set; }
        public bool Bit15 { get; set; }
        public bool Bit16 { get; set; }
        public bool Bit17 { get; set; }
        public bool Bit18 { get; set; }
        public bool Bit19 { get; set; }
        public bool Bit20 { get; set; }
        public bool Bit21 { get; set; }
        public bool Bit22 { get; set; }
        public bool Bit23 { get; set; }
        public bool Bit24 { get; set; }
        public bool Bit25 { get; set; }
        public bool Bit26 { get; set; }
        public bool Bit27 { get; set; }
        public bool Bit28 { get; set; }
        public bool Bit29 { get; set; }
        public bool Bit30 { get; set; }
        public bool Bit31 { get; set; }
    }

    [Serializable]
    public struct RegionFlags
    {
        public bool InvisibleTrap { get; set; }
        public bool ResetTrap { get; set; }
        public bool PartyRequired { get; set; }
        public bool Detectable { get; set; }
        public bool Bit04 { get; set; }
        public bool Bit05 { get; set; }
        public bool NPCCanTrigger { get; set; }
        public bool Bit07 { get; set; }
        public bool Deactivated { get; set; }
        public bool NPCCannotPass { get; set; }
        public bool AlternativePoint { get; set; }
        public bool UsedByDoor { get; set; }
        public bool Bit12 { get; set; }
        public bool Bit13 { get; set; }
        public bool Bit14 { get; set; }
        public bool Bit15 { get; set; }
        public bool Bit16 { get; set; }
        public bool Bit17 { get; set; }
        public bool Bit18 { get; set; }
        public bool Bit19 { get; set; }
        public bool Bit20 { get; set; }
        public bool Bit21 { get; set; }
        public bool Bit22 { get; set; }
        public bool Bit23 { get; set; }
        public bool Bit24 { get; set; }
        public bool Bit25 { get; set; }
        public bool Bit26 { get; set; }
        public bool Bit27 { get; set; }
        public bool Bit28 { get; set; }
        public bool Bit29 { get; set; }
        public bool Bit30 { get; set; }
        public bool Bit31 { get; set; }
    }

    [Serializable]
    public struct AreaItemFlags
    {
        public bool Identified { get; set; }
        public bool Unstealable { get; set; }
        public bool Stolen { get; set; }
        public bool Undroppable { get; set; }
        public bool Bit04 { get; set; }
        public bool Bit05 { get; set; }
        public bool Bit06 { get; set; }
        public bool Bit07 { get; set; }
        public bool Bit08 { get; set; }
        public bool Bit09 { get; set; }
        public bool Bit10 { get; set; }
        public bool Bit11 { get; set; }
        public bool Bit12 { get; set; }
        public bool Bit13 { get; set; }
        public bool Bit14 { get; set; }
        public bool Bit15 { get; set; }
        public bool Bit16 { get; set; }
        public bool Bit17 { get; set; }
        public bool Bit18 { get; set; }
        public bool Bit19 { get; set; }
        public bool Bit20 { get; set; }
        public bool Bit21 { get; set; }
        public bool Bit22 { get; set; }
        public bool Bit23 { get; set; }
        public bool Bit24 { get; set; }
        public bool Bit25 { get; set; }
        public bool Bit26 { get; set; }
        public bool Bit27 { get; set; }
        public bool Bit28 { get; set; }
        public bool Bit29 { get; set; }
        public bool Bit30 { get; set; }
        public bool Bit31 { get; set; }
    }

    [Serializable]
    public struct ContainerFlags
    {
        public bool Locked { get; set; }
        public bool Bit01 { get; set; }
        public bool Bit02 { get; set; }
        public bool TrapResets { get; set; }
        public bool Bit04 { get; set; }
        public bool Disabled { get; set; }
        public bool Bit06 { get; set; }
        public bool Bit07 { get; set; }
        public bool Bit08 { get; set; }
        public bool Bit09 { get; set; }
        public bool Bit10 { get; set; }
        public bool Bit11 { get; set; }
        public bool Bit12 { get; set; }
        public bool Bit13 { get; set; }
        public bool Bit14 { get; set; }
        public bool Bit15 { get; set; }
        public bool Bit16 { get; set; }
        public bool Bit17 { get; set; }
        public bool Bit18 { get; set; }
        public bool Bit19 { get; set; }
        public bool Bit20 { get; set; }
        public bool Bit21 { get; set; }
        public bool Bit22 { get; set; }
        public bool Bit23 { get; set; }
        public bool Bit24 { get; set; }
        public bool Bit25 { get; set; }
        public bool Bit26 { get; set; }
        public bool Bit27 { get; set; }
        public bool Bit28 { get; set; }
        public bool Bit29 { get; set; }
        public bool Bit30 { get; set; }
        public bool Bit31 { get; set; }
    }

    [Serializable]
    public enum RegionType
    {
        ProximityTrigger = 0,
        InfoPoint = 1,
        TravelRegion = 2
    }

    [Serializable]
    public enum ContainerType
    {
        None,
        Bag,
        Chest,
        Drawer,
        Pile,
        Table,
        Shelf,
        Altar,
        Nonvisible,
        Spellbook,
        Body,
        Barrel,
        Crate
    }

}