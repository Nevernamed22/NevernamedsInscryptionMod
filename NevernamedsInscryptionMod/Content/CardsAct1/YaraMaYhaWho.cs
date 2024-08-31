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
    static class YaraMaYhaWho
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/yaramayhawho.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed YaraMaYhaWho",
                "Yara-Ma-Yha-Who",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Nature,
                description: "The bloated arboreal Yara-Ma-Yha-Who. Practically ballooned with blood from it's gluttonous feeding...",
                bloodCost: 1,
                bonesCost: 2,
                defaultTex: tex,
                abilities: new List<Ability>() { ExceptionalSacrifice.ability, Visceral.ability },
                tribes: new List<Tribe>() { Tribe.Reptile },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/yaramayawho_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/yaramayhawho_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground }
                );
        }
    }
}