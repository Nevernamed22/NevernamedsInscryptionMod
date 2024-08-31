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
    static class IIEyes
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed IIEyes",
                "II",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "Giant eyes- no doubt from a cadaver of awe inspiring magnitude! They always come in pairs.",
                bloodCost: 0,
                bonesCost: 5,
                tribes: new List<Tribe>() { },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                abilities: new List<Ability>() { TwinBond.ability, Flighty.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/iieyes.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/iieyes_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/iieyes_pixel.png")
                );
        }
    }
}