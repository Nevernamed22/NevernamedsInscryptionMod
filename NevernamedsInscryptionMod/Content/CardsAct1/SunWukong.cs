using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class SunWukong
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SunWukong",
                "Sun Wukong",
                2,
               2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Sun Wukong, the mischevious monkey king- his immense strength is more than enough to toss other creatures back to your hand.",
                bloodCost: 0,
                bonesCost: 4,
                abilities: new List<Ability>() {  Collector.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sunwukong.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sunwukong_emission.png")
                );
        }
    }
}