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
    static class GoreyGirl
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed GoreyGirl",
                "Gorey Girl",
                2,
                4,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "Ahh that poor girl. Such a messy scene- though her escape was a sight to behold!",
                bloodCost: 0,
                bonesCost: 8,
                tribes: new List<Tribe>() { },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                abilities: new List<Ability>() { GutSpewer.ability, ExplodingCorpseCustom.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/goreygirl.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/goreygirl_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/goreygirl_pixel.png")
                );
        }
    }
}