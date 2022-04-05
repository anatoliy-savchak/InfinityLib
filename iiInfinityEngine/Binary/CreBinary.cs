using System;
using System.Runtime.InteropServices;

namespace iiInfinityEngine.Core.Binary
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct CreHeaderBinary
    {
        public array4 ftype;
        public array4 fversion;
        public Int32 LongName;
        public Int32 ShortName;
        public Int32 Flags;
        public Int32 XPReward;
        public Int32 PowerLevel;
        public Int32 Gold;
        public Int32 StatusFlags; // state.ids
        public Int16 CurrentHP;
        public Int16 MaximumHP;
        public Int16 Animation;
        public Int16 Unknown;
        public byte MetalColourIndex;
        public byte MinorColourIndex;
        public byte MajorColourIndex;
        public byte SkinColourIndex;
        public byte LeatherColourIndex;
        public byte ArmorColourIndex;
        public byte HairColourIndex;
        public byte EffVersion;
        public array8 SmallPortrait;
        public array8 LargePortrait;
        public byte Reputation;
        public byte HideInShadows;
        public Int16 ArmorClassNatural;
        public Int16 ArmorClassEffective; 
        public Int16 CrushingModifuer;
        public Int16 MissileModifier;
        public Int16 PiercingModifier;
        public Int16 SlashingModifier;
        public byte Thac0;
        public byte NumberOfAttacks;
        public byte SaveVsDeath;
        public byte SaveVsWanrds;
        public byte SaveVsPolymorph;
        public byte SaveVsBreath;
        public byte SaveVsSpells;
        public byte FireResistance;
        public byte ColdResistance;
        public byte ElectricityResistance;
        public byte AcidResistance;
        public byte MagicResistance;
        public byte MagicFireResistance;
        public byte MagicColdResistance;
        public byte SlashingResistance;
        public byte CrushingResistance;
        public byte PiercingResistance;
        public byte MissileResistance;
        public byte DetectIllusion;
        public byte SetTraps;
        public byte Lore;
        public byte LockPicking;
        public byte Stealth;
        public byte FindTraps;
        public byte PickPockets;
        public byte Fatigue;
        public byte Intoxication;
        public byte Luck;
        public byte UnusedLargeSwords;
        public byte UnusedSmallSwords;
        public byte UnusedBows;
        public byte UnusedSpears;
        public byte UnusedBlunt;
        public byte UnusedSpiked;
        public byte UnusedAxe;
        public byte UnusedMissile;       
        public Int32 Unknownx1;
        public Int32 Unknownx2;
        public Int32 Unknownx3;
        public byte TurnUndeadLevel;
        public byte Tracking;
        public array32 Unknownx5;
        public Int32 Strref1;
        public Int32 Strref2;
        public Int32 Strref3;
        public Int32 Strref4;
        public Int32 Strref5;
        public Int32 Strref6;
        public Int32 Strref7;
        public Int32 Strref8;
        public Int32 Strref9;
        public Int32 Strref10;
        public Int32 Strref11;
        public Int32 Strref12;
        public Int32 Strref13;
        public Int32 Strref14;
        public Int32 Strref15;
        public Int32 Strref16;
        public Int32 Strref17;
        public Int32 Strref18;
        public Int32 Strref19;
        public Int32 Strref20;
        public Int32 Strref21;
        public Int32 Strref22;
        public Int32 Strref23;
        public Int32 Strref24;
        public Int32 Strref25;
        public Int32 Strref26;
        public Int32 Strref27;
        public Int32 Strref28;
        public Int32 Strref29;
        public Int32 Strref30;
        public Int32 Strref31;
        public Int32 Strref32;
        public Int32 Strref33;
        public Int32 Strref34;
        public Int32 Strref35;
        public Int32 Strref36;
        public Int32 Strref37;
        public Int32 Strref38;
        public Int32 Strref39;
        public Int32 Strref40;
        public Int32 Strref41;
        public Int32 Strref42;
        public Int32 Strref43;
        public Int32 Strref44;
        public Int32 Strref45;
        public Int32 Strref46;
        public Int32 Strref47;
        public Int32 Strref48;
        public Int32 Strref49;
        public Int32 Strref50;
        public Int32 Strref51;
        public Int32 Strref52;
        public Int32 Strref53;
        public Int32 Strref54;
        public Int32 Strref55;
        public Int32 Strref56;
        public Int32 Strref57;
        public Int32 Strref58;
        public Int32 Strref59;
        public Int32 Strref60;
        public Int32 Strref61;
        public Int32 Strref62;
        public Int32 Strref63;
        public Int32 Strref64;
        public Int32 Strref65;
        public Int32 Strref66;
        public Int32 Strref67;
        public Int32 Strref68;
        public Int32 Strref69;
        public Int32 Strref70;
        public Int32 Strref71;
        public Int32 Strref72;
        public Int32 Strref73;
        public Int32 Strref74;
        public Int32 Strref75;
        public Int32 Strref76;
        public Int32 Strref77;
        public Int32 Strref78;
        public Int32 Strref79;
        public Int32 Strref80;
        public Int32 Strref81;
        public Int32 Strref82;
        public Int32 Strref83;
        public Int32 Strref84;
        public Int32 Strref85;
        public Int32 Strref86;
        public Int32 Strref87;
        public Int32 Strref88;
        public Int32 Strref89;
        public Int32 Strref90;
        public Int32 Strref91;
        public Int32 Strref92;
        public Int32 Strref93;
        public Int32 Strref94;
        public Int32 Strref95;
        public Int32 Strref96;
        public Int32 Strref97;
        public Int32 Strref98;
        public Int32 Strref99;
        public Int32 Strref100;
        public byte Level1;
        public byte Level2;
        public byte Level3;
        public byte Sex;
        public byte Strength;
        public byte StrengthBonus;
        public byte Intelligence;
        public byte Wisdom;
        public byte Dexterity;
        public byte Constitution;
        public byte Charisma;
        public byte Morale;
        public byte MoraleBreak;
        public byte RacialEnemy;
        public Int16 MoraleRecoveryTime;
        public Int32 Kit;
        public array8 ScriptOverride;
        public array8 ScriptClass;
        public array8 ScriptRace;
        public array8 ScriptGeneral;
        public array8 ScriptDefault;
        public byte EnemyAlly;
        public byte General;
        public byte Race;
        public byte Class;
        public byte Specific;
        public byte Gender;
        public byte ObjectIdRef1;
        public byte ObjectIdRef2;
        public byte ObjectIdRef3;
        public byte ObjectIdRef4;
        public byte ObjectIdRef5;
        public byte Alignment;
        public Int16 GlobalActorEnumeration;
        public Int16 LocalActorEnumeration;
        public array32 DeathVariable;
        public Int32 KnownSpellsoffset;
        public Int32 KnownSpellsCount;
        public Int32 SpellMemorizationOffset;
        public Int32 SpellMemorizationCount;
        public Int32 MemorizedSpellsOffset;
        public Int32 MemorizedSpellsCount;
        public Int32 ItemSlotOffset;
        public Int32 ItemOffset;
        public Int32 ItemCount;
        public Int32 EffectOffset;
        public Int32 EffectCount;
        public array8 DialogFile;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct CreHeaderBinary22
    {
        public array4 ftype;
        public array4 fversion;
        public Int32 LongName;
        public Int32 ShortName;
        public UInt32 Flags;
        public Int32 XPReward;
        public Int32 PowerLevel;
        public Int32 Gold;
        public Int32 StatusFlags; // state.ids
        public Int16 CurrentHP;
        public Int16 MaximumHP;
        public Int32 Animation;
        public byte MetalColourIndex;
        public byte MinorColourIndex;
        public byte MajorColourIndex;
        public byte SkinColourIndex;
        public byte LeatherColourIndex;
        public byte ArmorColourIndex;
        public byte HairColourIndex;
        public byte EffVersion;
        public array8 SmallPortrait;
        public array8 LargePortrait;
        public byte Reputation;
        public byte HideInShadows;
        public Int16 ArmorClassNatural;
        public Int16 CrushingModifuer; //Bludgeoning AC modifier
        public Int16 MissileModifier;
        public Int16 PiercingModifier;
        public Int16 SlashingModifier;
        public byte Thac0; //bab
        public byte NumberOfAttacks;
        public byte SaveVsDeath; //fortitude
        public byte SaveVsWanrds; // reflex
        public byte SaveVsPolymorph; // will

        public byte FireResistance;
        public byte ColdResistance;
        public byte ElectricityResistance;
        public byte AcidResistance;
        public byte MagicResistance;
        public byte MagicFireResistance;
        public byte MagicColdResistance;
        public byte SlashingResistance;
        public byte CrushingResistance;
        public byte PiercingResistance;
        public byte MissileResistance;
        public byte ResistMagicDamage;
        public Int32 Unknowny1; 
        public byte Fatigue; 
        public byte Intoxication; 
        public byte Luck; 
        public byte TurnUndeadLevel; 
        public Int64 Unknowny33_1; //! in total 33:8
        public Int64 Unknowny33_2; //! in total 33:16
        public Int64 Unknowny33_3; //! in total 33:24
        public Int32 Unknowny33_4; //! in total 33:28
        public Int32 Unknowny33_5; //! in total 33:32
        public byte Unknowny33_6; //! in total 33:33
        public byte LevelTotal;
        public byte LevelBarbarian;
        public byte LevelBard;
        public byte LevelCleric;
        public byte LevelDruid;
        public byte LevelFighter;
        public byte LevelMonk;
        public byte LevelPaladin;
        public byte LevelRanger;
        public byte LevelRogue;
        public byte LevelSorcerer;
        public byte LevelWizard;

        public Int64 Unknowny22_1; //! in total 22:8
        public Int64 Unknowny22_2; //! in total 22:16
        public Int32 Unknowny22_3; //! in total 22:20
        public Int16 Unknowny22_4; //! in total 22:22

        public CreSoundSlots Sounds;
        public array8 ScriptTeam;
        public array8 ScriptSpecial;
        public byte EnchantmentLevel;

        public Int16 Unknowny3_1; //! in total 3:2
        public byte Unknowny3_2; //! in total 3:1

        public UInt32 Feats1;
        public UInt32 Feats2;
        public UInt32 Feats3;
        public UInt32 Feats4;
        public UInt32 Feats5;
        public UInt32 Feats6;

        public byte FeatWeaponProBow;
        public byte FeatWeaponProCrossbow;
        public byte FeatWeaponProMissle;
        public byte FeatWeaponProAxe;
        public byte FeatWeaponProMace;
        public byte FeatWeaponProFlail;
        public byte FeatWeaponProPolearm;
        public byte FeatWeaponProHammer;
        public byte FeatWeaponProQuarterstaff;
        public byte FeatWeaponProGreatsword;
        public byte FeatWeaponProLargeSword;
        public byte FeatWeaponProSmallBlade;

        public byte FeatToughness;
        public byte FeatArmoredArcana;
        public byte FeatCleave;
        public byte FeatArmorPreficiency; //good

        public byte FeatSpellFocusEnchantment;
        public byte FeatSpellFocusEvocation;
        public byte FeatSpellFocusNecromancy;
        public byte FeatSpellFocusTransmutation;
        public byte FeatSpellPenetration;

        public byte FeatExtraRage;
        public byte FeatExtraWildShape;
        public byte FeatExtraExtraSmiting;
        public byte FeatExtraExtraTurning;
        public byte FeatWeaponProExoticBastardSword;

        public Int64 Unknowny38_1; //! in total 38:8
        public Int64 Unknowny38_2; //! in total 38:16
        public Int64 Unknowny38_3; //! in total 38:24
        public Int64 Unknowny38_4; //! in total 38:34
        public Int32 Unknowny38_5; //! in total 38:36
        public Int16 Unknowny38_6; //! in total 38:38

        public byte SkillAlchemy;
        public byte SkillAnimalEmpathy;
        public byte SkillBluff;
        public byte SkillConcentration;
        public byte SkillDiplomacy;
        public byte SkillDisableDevice;
        public byte SkillHide;
        public byte SkillIntimidate;
        public byte SkillKnowledgeArcana;
        public byte SkillMoveSilently;
        public byte SkillOpenLock;
        public byte SkillPickPocket;
        public byte SkillSearch;
        public byte SkillSpellcraft;
        public byte SkillUseMagicDevice;
        public byte SkillWildernessLaw;

        public Int64 Unknowny50_1; //! in total 50:8
        public Int64 Unknowny50_2; //! in total 50:16
        public Int64 Unknowny50_3; //! in total 50:24
        //public Int32 Unknowny50_4; //! in total 50:28
        //public Int32 Unknowny50_5; //! in total 50:32
        public Int64 Unknowny50_4; //! in total 50:32
        public Int64 Unknowny50_5; //! in total 50:40
        public Int64 Unknowny50_6; //! in total 50:48
        public Int16 Unknowny50_7; //! in total 50:50

        public byte ChallangeRating; // good
        public byte FavouredEnemy1;
        public byte FavouredEnemy2;
        public byte FavouredEnemy3;
        public byte FavouredEnemy4;
        public byte FavouredEnemy5;
        public byte FavouredEnemy6;
        public byte FavouredEnemy7;
        public byte FavouredEnemy8;

        public byte Subrace;
        public Int16 Unknown2;

        public byte Strength;
        public byte Intelligence;
        public byte Wisdom;
        public byte Dexterity;
        public byte Constitution;
        public byte Charisma;

        public byte Morale;
        public byte MoraleBreak;
        public Int16 MoraleRecoveryTime;
        public UInt32 Kit;

        public array8 ScriptOverride;
        public array8 ScriptSpecial2;
        public array8 ScriptCombat;
        public array8 ScriptSpecial3;
        public array8 ScriptMovement;

        public byte Hidden;
        public byte OnDeathSetExtraVariable;
        public byte IncrementKillCount;
        public byte Unknown1;
        
        public Int16 VariableInternal1;
        public Int16 VariableInternal2;
        public Int16 VariableInternal3;
        public Int16 VariableInternal4;
        public Int16 VariableInternal5;

        public array32 DeathVariable2;
        public array32 DeathVariable3;

        public Int16 IsLocationSaved;
        public Int16 SavedLocationX;
        public Int16 SavedLocationY;
        public Int16 SavedOrientation;

        public Int64 Unknowny15_1; //! in total 15:8
        public Int32 Unknowny15_2; //! in total 15:12
        public Int16 Unknowny15_3; //! in total 15:14
        public byte Unknowny15_4; //! in total 15:15

        public byte FadeAmount;
        public byte FadeSpeed;
        public byte Attributes;
        public byte Visibility;

        public byte Unknown1_2;
        public byte Unknown1_3;

        public byte SkillPointsRemain;

        public Int64 Unknowny124_1; //! in total 124:8
        public Int64 Unknowny124_2; //! in total 124:16
        public Int64 Unknowny124_3; //! in total 124:24
        public Int64 Unknowny124_4; //! in total 124:32
        public Int64 Unknowny124_5; //! in total 124:40
        public Int64 Unknowny124_6; //! in total 124:48
        public Int64 Unknowny124_7; //! in total 124:56
        public Int64 Unknowny124_8; //! in total 124:64
        public Int64 Unknowny124_9; //! in total 124:72
        public Int64 Unknowny124_10; //! in total 124:80
        public Int64 Unknowny124_11; //! in total 124:88
        public Int64 Unknowny124_12; //! in total 124:96
        public Int64 Unknowny124_13; //! in total 124:104
        public Int64 Unknowny124_14; //! in total 124:112
        public Int64 Unknowny124_15; //! in total 124:120
        public Int32 Unknowny124_16; //! in total 124:124

        public byte EnemyAlly;
        public byte General;
        public byte Race;
        public byte Class;
        public byte Specific;
        public byte Gender;

        public byte ObjectIdRef1;
        public byte ObjectIdRef2;
        public byte ObjectIdRef3;
        public byte ObjectIdRef4;
        public byte ObjectIdRef5;

        public byte Alignment;
        public Int16 GlobalActorEnumeration;
        public Int16 LocalActorEnumeration;
        public array32 DeathVariable;
        public UInt16 Class2;
        public UInt16 ClassMsk;

        public Int16 Unknown2_2;

        public CreLevels9 SpellsOffsetBard;
        public CreLevels9 SpellsOffsetCleric;
        public CreLevels9 SpellsOffsetDruid;
        public CreLevels9 SpellsOffsetPaladin;
        public CreLevels9 SpellsOffsetRanger;
        public CreLevels9 SpellsOffsetSorcerer;
        public CreLevels9 SpellsOffsetWizard;
        public CreLevels9 SpellsCountBard;
        public CreLevels9 SpellsCountCleric;
        public CreLevels9 SpellsCountDruid;
        public CreLevels9 SpellsCountPaladin;
        public CreLevels9 SpellsCountRanger;
        public CreLevels9 SpellsCountSorcerer;
        public CreLevels9 SpellsCountWizard;
        public CreLevels9 SpellsOffsetDomain;
        public CreLevels9 SpellsCountDomain;
        public Int32 AbilitiesOffset;
        public Int32 AbilitiesCount;
        public Int32 SongOffset;
        public Int32 SongCount;
        public Int32 ShapesOffset;
        public Int32 ShapesCount;
        public Int32 ItemSlotOffset;
        public Int32 ItemOffset;
        public Int32 ItemCount;
        public Int32 EffectsOffset;
        public Int32 EffectsCount;

        public array8 DialogFile;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct CreSoundSlots
    {
        public Int32 Sound01;
        public Int32 Sound02;
        public Int32 Sound03;
        public Int32 Sound04;
        public Int32 Sound05;
        public Int32 Sound06;
        public Int32 Sound07;
        public Int32 Sound08;
        public Int32 Sound09;
        public Int32 Sound10;
        public Int32 Sound11;
        public Int32 Sound12;
        public Int32 Sound13;
        public Int32 Sound14;
        public Int32 Sound15;
        public Int32 Sound16;
        public Int32 Sound17;
        public Int32 Sound18;
        public Int32 Sound19;
        public Int32 Sound20;
        public Int32 Sound21;
        public Int32 Sound22;
        public Int32 Sound23;
        public Int32 Sound24;
        public Int32 Sound25;
        public Int32 Sound26;
        public Int32 Sound27;
        public Int32 Sound28;
        public Int32 Sound29;
        public Int32 Sound30;
        public Int32 Sound31;
        public Int32 Sound32;
        public Int32 Sound33;
        public Int32 Sound34;
        public Int32 Sound35;
        public Int32 Sound36;
        public Int32 Sound37;
        public Int32 Sound38;
        public Int32 Sound39;
        public Int32 Sound40;
        public Int32 Sound41;
        public Int32 Sound42;
        public Int32 Sound43;
        public Int32 Sound44;
        public Int32 Sound45;
        public Int32 Sound46;
        public Int32 Sound47;
        public Int32 Sound48;
        public Int32 Sound49;
        public Int32 Sound50;
        public Int32 Sound51;
        public Int32 Sound52;
        public Int32 Sound53;
        public Int32 Sound54;
        public Int32 Sound55;
        public Int32 Sound56;
        public Int32 Sound57;
        public Int32 Sound58;
        public Int32 Sound59;
        public Int32 Sound60;
        public Int32 Sound61;
        public Int32 Sound62;
        public Int32 Sound63;
        public Int32 Sound64;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct CreLevels9
    {
        public Int32 Level01;
        public Int32 Level02;
        public Int32 Level03;
        public Int32 Level04;
        public Int32 Level05;
        public Int32 Level06;
        public Int32 Level07;
        public Int32 Level08;
        public Int32 Level09;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct CreKnownSpellBinary
    {
        public array8 Filename { get; set; }
        public Int16 SpellLevel { get; set; }
        public Int16 SpellType { get; set; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct CreSpellMemorisationInfoBinary
    {
        public Int16 SpellLevel { get; set; }
        public Int16 SlotCount { get; set; }
        public Int16 CurrentSlotCount { get; set; }
        public Int16 SpellType { get; set; }
        public Int32 SpellOffset { get; set; }
        public Int32 SpellCount { get; set; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct CreMemorisedSpellBinary
    {
        public array8 Filename { get; set; }
        public Int32 Memorised { get; set; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct CreItemBinary
    {
        public array8 Filename { get; set; }
        public byte ExpiryHour { get; set; }
        public byte ExpiryValue { get; set; }
        public Int16 Charges1 { get; set; }
        public Int16 Charges2 { get; set; }
        public Int16 Charges3 { get; set; }
        public UInt32 Flags { get; set; }
    }

    [Serializable]
    [Flags]
    public enum CreItemBinaryFlags : UInt32
    {
        //None = 0,
        Identified = 1 << 0,
        Unstealable = 1 << 1,
        Stolen = 1 << 2,
        Magical = 1 << 3
    }


    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct CreKnownSpell
    {
        public Int32 SpellIndex;
        public Int32 AmountMemorized;
        public Int32 AmountRemaining;
        public Int32 Unknown;
    }
}