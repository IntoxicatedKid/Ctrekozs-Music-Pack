using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Triggers;
using HarmonyLib;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Stations;
using LBoL.Core.Units;
using LBoL.EntityLib.EnemyUnits.Character;
using LBoL.EntityLib.EnemyUnits.Normal;
using LBoL.EntityLib.StatusEffects.Enemy;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using static CtrekozsMusicPack.BepinexPlugin;

namespace CtrekozsMusicPack
{
    public class BgmsDef
    {
        [OverwriteVanilla]
        public sealed class SeijaBgm : BgmTemplate
        {
            public override IdContainer GetId()
            {
                return "Seija";
            }
            public override UniTask<AudioClip> LoadAudioClipAsync()
            {
                return ResourceLoader.LoadAudioClip("Demetori_-_Reverse_Ideology_The_Antinomy_of_Ideology.ogg", AudioType.OGGVORBIS, directorySource);
            }
            public override BgmConfig MakeConfig()
            {
                var config = BgmConfig.FromID(GetId());
                config.TrackName = "The Antinomy of Ideology";
                config.Artist = "Demetori";
                config.Original = "Reverse Ideology";
                config.LoopStart = (float?)6.15;
                config.LoopEnd = (float?)225.65;
                return config;
            }
        }
        [OverwriteVanilla]
        public sealed class JunkoBgm : BgmTemplate
        {
            public override IdContainer GetId()
            {
                return "Junko";
            }
            public override UniTask<AudioClip> LoadAudioClipAsync()
            {
                return ResourceLoader.LoadAudioClip("Sieudiver_-_Touhou_MetalTrancecoreTakamachi_Walk_-_Inhuman_Pure_Furies_Whereabouts_of_the_Heart_Junko.ogg", AudioType.OGGVORBIS, directorySource);
            }
            public override BgmConfig MakeConfig()
            {
                var config = BgmConfig.FromID(GetId());
                config.TrackName = "Inhuman";
                config.Artist = "Sieudiver";
                config.Original = "Pure Furies ~ Whereabouts of the Heart";
                config.LoopStart = (float?)44.9;
                config.LoopEnd = (float?)288;
                return config;
            }
        }
        /*[OverwriteVanilla]
        public sealed class SanaeBgm : BgmTemplate
        {
            public override IdContainer GetId()
            {
                return "Sanae";
            }
            public override UniTask<AudioClip> LoadAudioClipAsync()
            {
                return ResourceLoader.LoadAudioClip("-_Gensou_Shoujo_Taisen_Kou_OST_-_Motherly_Sea_One_with_the_Wind.ogg", AudioType.OGGVORBIS, directorySource);
            }
            public override BgmConfig MakeConfig()
            {
                var config = BgmConfig.FromID(GetId());
                config.TrackName = "Motherly Sea One with the Wind";
                config.Artist = "Ibiza";
                config.Original = "Faith is for the Transient People";
                config.LoopStart = (float?)79;
                config.LoopEnd = (float?)287;
                return config;
            }
        }*/
        [OverwriteVanilla]
        public sealed class RemiliaBgm : BgmTemplate
        {
            public override IdContainer GetId()
            {
                return "Remilia";
            }
            public override UniTask<AudioClip> LoadAudioClipAsync()
            {
                return ResourceLoader.LoadAudioClip("-_Gensou_Shoujo_Taisen_Kou_OST_-_Scarlet_Pressure.ogg", AudioType.OGGVORBIS, directorySource);
            }
            public override BgmConfig MakeConfig()
            {
                var config = BgmConfig.FromID(GetId());
                config.TrackName = "Scarlet Pressure";
                config.Artist = "cobu";
                config.Original = "septette for the dead princess";
                config.LoopStart = (float?)80.9;
                config.LoopEnd = (float?)355.75;
                return config;
            }
        }
    }
}
