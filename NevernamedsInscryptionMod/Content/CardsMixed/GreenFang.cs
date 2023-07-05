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
    static class GreenFang
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/greenfang.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed GreenFang",
                "Green Fang",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "A peculiar reptile. It controls it's firey breath with artistic precision.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Sniper, Ignition.ability },
                tribes: new List<Tribe>() { Tribe.Reptile },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                  pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/greenfang_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/greenfang_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground }
                );
        }
    }
}
